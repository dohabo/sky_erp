using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.Utility.Method
{
    class MessageBox_
    {
        static MessageBox_ instance;

        public static MessageBox_ Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MessageBox_();
                }
                return instance;
            }
        }

        public void grdviewCount(int count)
        {
            if (count < 1)
            {
                MessageBox.Show("검색 조건에 해당하는 내역이 없습니다.");
            }
        }
    }
}
