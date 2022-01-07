using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.Utility.Fuction
{
    class ExcelFunc
    {
        public void excelExport(DataGridView dtgviewName, string title,
            DateTimePicker dateFrom, DateTimePicker dateTo)
        {
            if (dtgviewName.Rows.Count > 1)
            {
                //쉬운 이름을 위해 시간 사용
                string nowDateTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                string pathFilename = string.Empty;

                SaveFileDialog saveFile = new SaveFileDialog
                {
                    Title = "Excel 파일 저장",
                    FileName = $"{nowDateTime}.xlsx",
                    DefaultExt = "xlsx",
                    Filter = "Xlsx files(*.xlsx)|*.xlsx"
                };

                // OK버튼을 눌렀을때의 동작
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // 경로와 파일명을 fileName에 저장
                    pathFilename = saveFile.FileName.ToString();
                }
                else
                {
                    //OK 안하면 취소
                    return;
                }
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                excel.DisplayAlerts = false;

                //1. 워크시트 선택
                //처음에는 Sheet1로 1개 있음
                Worksheet worksheet = workbook.Worksheets.Item["Sheet1"];
                //여러 시트를 하려면 인덱스를 추가해서 받아서 사용 (2번째 부터는)
                //workbook.Worksheets.Add(After: workbook.Worksheets[index - 1]);
                //Worksheet worksheet = workbook.Worksheets.Item[index];

                //2. 필요시 시트 이름 변경
                worksheet.Name = "sheet1";

                //3. 컬럼 별로 너비 변경
                Range ModRange = worksheet.Columns[1];
                //ModRange.ColumnWidth = 30;
                ModRange = worksheet.Columns[2];
                //ModRange.ColumnWidth = 30;
                //넘버포맷을 사용하면 뒤 컬럼부터는 숫자형식으로 적용
                ModRange.NumberFormat = "@";
                ModRange = worksheet.Columns[3];
                //ModRange.ColumnWidth = 30;
                ModRange = worksheet.Columns[4];
                //ModRange.ColumnWidth = 30;

                //4. 첫번째 줄 타이틀 생성 - 예쁘게 하기 위해
                //Range는 엑셀을 실행해서 참고하기 좋음 (첫줄이라 1라인)
                ModRange = (Range)worksheet.get_Range("A1", "D1");
                ModRange.Merge(true); //병합하고
                ModRange.Value = $"{title}"; //이름 입력하고
                ModRange.Font.Size = 16; //폰트 키우고
                ModRange.Font.Bold = true; //Bold 주고
                ModRange.HorizontalAlignment = XlHAlign.xlHAlignLeft; //좌측 정렬
                                                                      //테두리 까지 끝
                ModRange.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);

                //5. 2번째 줄에는 리포트 기간 및 파일 설명 추가
                ModRange = (Range)worksheet.get_Range("A2", "D2");
                ModRange.Merge(true);
                //DateTimePicker의 값을 그대로 넣어서 정보로 활용할 수 있음
                ModRange.Value = $"기간: {dateFrom.Value:yyyy-MM-dd} ~ {dateTo.Value:yyyy-MM-dd}";
                //2번째 설명은 우측 정렬
                ModRange.HorizontalAlignment = XlHAlign.xlHAlignRight;

                //ex. 테두리를 위해 그리드 축 개수를 담아두고
                int columnCount = dtgviewName.Columns.Count;
                int rowCount = dtgviewName.Rows.Count;

                //5. 헤드열 추가
                //cell은 1부터 row나 column은 일반적인 0부터라 차이가 있는 점 주의
                for (int i = 0; i < columnCount; i++)
                {
                    ModRange = (Range)worksheet.Cells[3, 1 + i];
                    ModRange.Value = dtgviewName.Columns[i].HeaderText;
                    ModRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    //data 테두리
                    ModRange.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
                    ModRange.Borders[XlBordersIndex.xlEdgeTop].Weight = XlBorderWeight.xlMedium; //위 테두리
                    if (i == 0) //시작 컬럼에서 왼쪽 테두리
                    {
                        ModRange.Borders[XlBordersIndex.xlEdgeLeft].Weight = XlBorderWeight.xlMedium;
                    }
                    else if (i == (columnCount - 1)) //마지막 컬럼에서 우측 테두리
                    {
                        ModRange.Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlMedium;
                    }
                    //아래 2줄 얇은 테두리
                    ModRange.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlDouble;
                    ModRange.Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlThick;
                }

                //6. 데이터 열 추가
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        //타이틀, 추가설명, 헤드, 0->1 때문에 i에 4를 더함
                        ModRange = (Range)worksheet.Cells[4 + i, 1 + j];
                        ModRange.Value = dtgviewName[j, i].Value == null ? string.Empty : dtgviewName[j, i].Value.ToString();

                        //data 테두리
                        ModRange.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
                        if (j == 0) //시작 컬럼에서 왼쪽 테두리
                        {
                            ModRange.Borders[XlBordersIndex.xlEdgeLeft].Weight = XlBorderWeight.xlMedium;
                        }
                        else if (j == (columnCount - 1)) //마지막 컬럼에서 우측 테두리
                        {
                            ModRange.Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlMedium;
                        }
                        if (i == (rowCount - 1)) //마지막 로우에서 우측 테두리
                        {
                            ModRange.Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
                            //결산 같은 마지막 줄 값이 존재하면 이걸 사용합니다.
                            //ModRange.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlDouble;
                        }
                    }
                }

                //7. 상단 고정필드 설정
                worksheet.Application.ActiveWindow.SplitRow = 1;
                worksheet.Application.ActiveWindow.FreezePanes = true;
                worksheet.Application.ActiveWindow.SplitRow = 2;
                worksheet.Application.ActiveWindow.FreezePanes = true;
                worksheet.Application.ActiveWindow.SplitRow = 3;
                worksheet.Application.ActiveWindow.FreezePanes = true;

                //8. 파일 저장 (앞선 SaveFileDialog로 만들어진 pathFilename 경로로 파일 저장
                workbook.SaveAs(Filename: pathFilename);
                workbook.Close();
                MessageBox.Show("출력 완료.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        // 기간 검색 없는 메쏘드. 출력일로 인쇄 되도록 표현
        public void excelExport(DataGridView dtgviewName, string title)
        {
            if (dtgviewName.Rows.Count > 0)
            {
                //쉬운 이름을 위해 시간 사용
                string nowDateTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                string nowDate = DateTime.Now.ToString("yyyyMMdd");
                string pathFilename = string.Empty;

                SaveFileDialog saveFile = new SaveFileDialog
                {
                    Title = "Excel 파일 저장",
                    FileName = $"{nowDateTime}.xlsx",
                    DefaultExt = "xlsx",
                    Filter = "Xlsx files(*.xlsx)|*.xlsx"
                };

                // OK버튼을 눌렀을때의 동작
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // 경로와 파일명을 fileName에 저장
                    pathFilename = saveFile.FileName.ToString();
                }
                else
                {
                    //OK 안하면 취소
                    return;
                }
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                excel.DisplayAlerts = false;

                //1. 워크시트 선택
                //처음에는 Sheet1로 1개 있음
                Worksheet worksheet = workbook.Worksheets.Item["Sheet1"];
                //여러 시트를 하려면 인덱스를 추가해서 받아서 사용 (2번째 부터는)
                //workbook.Worksheets.Add(After: workbook.Worksheets[index - 1]);
                //Worksheet worksheet = workbook.Worksheets.Item[index];

                //2. 필요시 시트 이름 변경
                worksheet.Name = "sheet1";

                //3. 컬럼 별로 너비 변경
                Range ModRange = worksheet.Columns[1];
                //ModRange.ColumnWidth = 30;
                ModRange = worksheet.Columns[2];
                //ModRange.ColumnWidth = 30;
                //넘버포맷을 사용하면 뒤 컬럼부터는 숫자형식으로 적용
                ModRange.NumberFormat = "@";
                ModRange = worksheet.Columns[3];
                //ModRange.ColumnWidth = 30;
                ModRange = worksheet.Columns[4];
                //ModRange.ColumnWidth = 30;

                //4. 첫번째 줄 타이틀 생성 - 예쁘게 하기 위해
                //Range는 엑셀을 실행해서 참고하기 좋음 (첫줄이라 1라인)
                ModRange = (Range)worksheet.get_Range("A1", "D1");
                ModRange.Merge(true); //병합하고
                ModRange.Value = $"{ title}"; //이름 입력하고
                ModRange.Font.Size = 16; //폰트 키우고
                ModRange.Font.Bold = true; //Bold 주고
                ModRange.HorizontalAlignment = XlHAlign.xlHAlignLeft; //좌측 정렬
                                                                      //테두리 까지 끝
                ModRange.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);

                //5. 2번째 줄에는 리포트 기간 및 파일 설명 추가
                ModRange = (Range)worksheet.get_Range("A2", "D2");
                ModRange.Merge(true);
                //DateTimePicker의 값을 그대로 넣어서 정보로 활용할 수 있음
                ModRange.Value = $"{"출력일": nowDate}";
                //2번째 설명은 우측 정렬
                ModRange.HorizontalAlignment = XlHAlign.xlHAlignRight;

                //ex. 테두리를 위해 그리드 축 개수를 담아두고
                int columnCount = dtgviewName.Columns.Count;
                int rowCount = dtgviewName.Rows.Count;

                //5. 헤드열 추가
                //cell은 1부터 row나 column은 일반적인 0부터라 차이가 있는 점 주의
                for (int i = 0; i < columnCount; i++)
                {
                    ModRange = (Range)worksheet.Cells[3, 1 + i];
                    ModRange.Value = dtgviewName.Columns[i].HeaderText;
                    ModRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    //data 테두리
                    ModRange.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
                    ModRange.Borders[XlBordersIndex.xlEdgeTop].Weight = XlBorderWeight.xlMedium; //위 테두리
                    if (i == 0) //시작 컬럼에서 왼쪽 테두리
                    {
                        ModRange.Borders[XlBordersIndex.xlEdgeLeft].Weight = XlBorderWeight.xlMedium;
                    }
                    else if (i == (columnCount - 1)) //마지막 컬럼에서 우측 테두리
                    {
                        ModRange.Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlMedium;
                    }
                    //아래 2줄 얇은 테두리
                    ModRange.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlDouble;
                    ModRange.Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlThick;
                }

                //6. 데이터 열 추가
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        //타이틀, 추가설명, 헤드, 0->1 때문에 i에 4를 더함
                        ModRange = (Range)worksheet.Cells[4 + i, 1 + j];
                        ModRange.Value = dtgviewName[j, i].Value == null ? string.Empty : dtgviewName[j, i].Value.ToString();

                        //data 테두리
                        ModRange.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
                        if (j == 0) //시작 컬럼에서 왼쪽 테두리
                        {
                            ModRange.Borders[XlBordersIndex.xlEdgeLeft].Weight = XlBorderWeight.xlMedium;
                        }
                        else if (j == (columnCount - 1)) //마지막 컬럼에서 우측 테두리
                        {
                            ModRange.Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlMedium;
                        }
                        if (i == (rowCount - 1)) //마지막 로우에서 우측 테두리
                        {
                            ModRange.Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
                            //결산 같은 마지막 줄 값이 존재하면 이걸 사용합니다.
                            //ModRange.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlDouble;
                        }
                    }
                }

                //7. 상단 고정필드 설정
                worksheet.Application.ActiveWindow.SplitRow = 1;
                worksheet.Application.ActiveWindow.FreezePanes = true;
                worksheet.Application.ActiveWindow.SplitRow = 2;
                worksheet.Application.ActiveWindow.FreezePanes = true;
                worksheet.Application.ActiveWindow.SplitRow = 3;
                worksheet.Application.ActiveWindow.FreezePanes = true;

                //8. 파일 저장 (앞선 SaveFileDialog로 만들어진 pathFilename 경로로 파일 저장
                workbook.SaveAs(Filename: pathFilename);
                workbook.Close();
                MessageBox.Show("출력 완료.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
