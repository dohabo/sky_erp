using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.Utility.Method
{
    class TextBox_
    {
        public void comma(UITextBox textbox)
        {
            try //숫자 이외의 문자들 입력시, 발생하는 오류를 방지, 1000단위 콤마 표시
            {
                int num;
                string temp = textbox.Text.Replace(",", ""); //입력되는 텍스트들의 ','를 전부 삭제
                num = Convert.ToInt32(temp);                 // 문자열 temp를 int형으로 변환
                string k = string.Format("{0:#,###}", num); // num을 string으로 변환하면서 천단위 콤마 표시

                textbox.Text = k;
            }
            catch (Exception ex) { }
        }
    }
}
