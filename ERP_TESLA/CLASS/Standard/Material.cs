using ERP_TESLA.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.CLASS.Standard
{
    class Material
    {
        string mCode;
        string mClass;
        string mName;
        string unit;
        string standard;
        int price;

        public Material()
        {
        }

        public Material(string mCode, string mClass, string mName, string unit, string standard)
        {
            this.mCode = mCode;
            this.mClass = mClass;
            this.mName = mName;
            this.unit = unit;
            this.standard = standard;
        }

        public Material(string mCode, string mClass, string mName, string unit, string standard, int price)
        {
            this.mCode = mCode;
            this.mClass = mClass;
            this.mName = mName;
            this.unit = unit;
            this.standard = standard;
            this.price = price;
        }

        public Material(string mName, string unit, string standard)
        {
            this.mName = mName;
            this.unit = unit;
            this.standard = standard;
        }

        public string MCode { get => mCode; set => mCode = value; }
        public string MClass { get => mClass; set => mClass = value; }
        public string MName { get => mName; set => mName = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Standard { get => standard; set => standard = value; }
        public int Price { get => price; set => price = value; }
        public void MaterialGridView(List<Material> list, DataGridView dtgview)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dtgview.Rows.Add(new string[]
                {
                    list[i].mCode,
                    list[i].mName,
                    list[i].standard,
                    list[i].unit
                });
            }
        }

        public void materialInfo(DataGridView dtgviewName, int mCode, int mname, int standard, int unit)
        {
            for (int i = 0; i < dtgviewName.Rows.Count; i++)
            {
                if (dtgviewName.Rows[i].Cells[mCode].Value != null) 
                {
                    string mcode = dtgviewName.Rows[i].Cells[mCode].Value.ToString();
                    List<Material> materialInfo = OraMgr.Instance.selectMaterialInfo(mcode);
                    dtgviewName.Rows[i].Cells[mname].Value = materialInfo[0].MName;
                    dtgviewName.Rows[i].Cells[standard].Value = materialInfo[0].Standard;
                    dtgviewName.Rows[i].Cells[unit].Value = materialInfo[0].Unit;
                }
                
            }
        }
    }
}
