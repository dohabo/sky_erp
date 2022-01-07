using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.Utility
{
    class Date
    {
        public string getDateThisMonthFrom(DateTimePicker datetimepicker)
        {
            string dateFrom = string.Format("{0}-{1}-01", DateTime.Now.Year, DateTime.Now.Month);
            datetimepicker.Format = DateTimePickerFormat.Short;
            return dateFrom;
        }
        public string getDateThisMonthTo(DateTimePicker datetimepicker)
        {
            string dateTo = string.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToString());
            datetimepicker.Format = DateTimePickerFormat.Short;
            return dateTo;
        }
    }
}
