using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.Utility.Print
{
    class Printing
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        public void printPreview(object sender, EventArgs e, PrintPreviewDialog ppviewdialPOrder, PrintDocument pdocPOrder,
            int cnt, int pageNo)
        {
            ppviewdialPOrder.Document = pdocPOrder;
            pdocPOrder.DefaultPageSettings.Landscape = true;    // 세로 인쇄 설정(삭제 시 가로 인쇄)
            if (ppviewdialPOrder.ShowDialog() == DialogResult.Cancel)
            {
                cnt = 0;
                pageNo = 1;
            }
        }


        public void printDoc(object sender, PrintPageEventArgs e, string title, DataGridView dtgviewOrderList, int cnt, int pageNo)
        {
            int dialogWidth = 528;//페이지 전체넓이 printPreviewDialog.Width
            int subTitile = 900; // 소제목 위치
            StringFormat sf = new StringFormat();//컬럼 안에있는 값들 가운데로 정렬하기위해서.
            sf.Alignment = StringAlignment.Center;
            int width, width1;//width 는 시작점 위치, width1은 datagrid 1개의 컬럼 가로길이
            int startWidth = 10;//시작 x좌표
            int startHeight = 140;//시작 y좌표
            int avgHeight = dtgviewOrderList.Rows[0].Height;//gridview 컬럼 하나의 높이
            int i, j;//반복문용 변수
            int temp = 0;//row개수 세어줄것. cnt의 역할
            int columsSize = 1;
            e.Graphics.DrawString(title, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, dialogWidth / 2, 40);
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("SKY ERP...", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, subTitile, 40);
            //Image img = Image.FromFile(@"..\..\test.png");
            //e.Graphics.DrawImage(img, 0, 0, 50, 50);
            e.Graphics.DrawString("인쇄일 : " + DateTime.Now.ToString("yyyy/MM/dd"), new Font("Arial", 13), Brushes.Black, subTitile, 80);
            e.Graphics.DrawString("페이지번호 : " + pageNo, new Font("Arial", 13), Brushes.Black, subTitile, 100);
            e.Graphics.DrawString("sky erp", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 1020, 780);
            for (i = 0; i < dtgviewOrderList.ColumnCount; i++)//columnCount는 일정
            {
                if (i == 0)
                {
                    width = 0;
                    width1 = dtgviewOrderList.Columns[i].Width + columsSize;
                }
                else if (i >= 1 && i <= dtgviewOrderList.ColumnCount - 2)
                {
                    width = dtgviewOrderList.Columns[i - 1].Width + columsSize;
                    width1 = dtgviewOrderList.Columns[i].Width + columsSize;
                }
                else
                {
                    width = dtgviewOrderList.Columns[i - 1].Width + columsSize;
                    width1 = dtgviewOrderList.Columns[i].Width + columsSize;
                }

                RectangleF drawRect = new RectangleF((float)(startWidth + width), (float)startHeight, (float)width1, avgHeight);

                e.Graphics.DrawRectangle(Pens.Black, (float)(startWidth + width), (float)startHeight, (float)width1, avgHeight);

                // e.Graphics.FillRectangle(Brushes.LightGray, (float)(startWidth + width), (float)startHeight, (float)width, avgHeight);
                e.Graphics.DrawString(dtgviewOrderList.Columns[i].HeaderText, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, drawRect, sf);

                startWidth += width;
            }
            startHeight += avgHeight;

            for (i = cnt; i < dtgviewOrderList.RowCount- 1; i++)
            {
                startWidth = 10;//다시 초기화
                for (j = 0; j < dtgviewOrderList.ColumnCount; j++)
                {
                    if (j == 0)
                    {
                        width = 0;
                        width1 = dtgviewOrderList.Columns[j].Width + columsSize;
                    }
                    else if (j >= 1 && j <= dtgviewOrderList.ColumnCount - 2)
                    {
                        width = dtgviewOrderList.Columns[j - 1].Width + columsSize;
                        width1 = dtgviewOrderList.Columns[j].Width + columsSize;
                    }
                    else
                    {
                        width = dtgviewOrderList.Columns[j - 1].Width + columsSize;
                        width1 = dtgviewOrderList.Columns[j].Width + columsSize;
                    }

                    RectangleF drawRect = new RectangleF((float)(startWidth + width), (float)startHeight, (float)width1, avgHeight);

                    e.Graphics.DrawRectangle(Pens.Black, (float)(startWidth + width), (float)startHeight, (float)width1, avgHeight);

                    // e.Graphics.FillRectangle(Brushes.LightGray, (float)(startWidth + width), (float)startHeight, (float)width, avgHeight);
                    e.Graphics.DrawString(dtgviewOrderList.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Arial", 9), Brushes.Black, drawRect, sf);
                    startWidth += width;
                }
                startHeight += avgHeight;
                temp++;
                cnt++;

                if (temp % 40 == 0)
                {
                    // MessageBox.Show("40으로 나눠졋다");
                    e.HasMorePages = true;
                    pageNo++;
                    return;
                }
            }
        }
    }
}
