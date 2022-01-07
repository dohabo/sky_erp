using ERP_TESLA.CLASS.Production;
using ERP_TESLA.CLASS.Standard;
using ERP_TESLA.CLASS.WarePurchase;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.DAO
{
    class OraMgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;
        //OracleCommand cmdd;
        static OraMgr instance;

        public static OraMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OraMgr();
                }
                return instance;
            }
        }

        // 생성자
        public OraMgr()
        {
            Console.WriteLine("오라클 객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            //cmdd = new OracleCommand("ptest_proc", conn);
        }

        // 소멸자
        ~OraMgr()
        {
            closeDB();
            Console.WriteLine("오라클 객체 소멸");
        }

        public void connectDB()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: " + e.Message);
                Environment.Exit(0);
            }
        }

        public void closeDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 접속 해제");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " + e.Message);
            }
        }

        // * 기준정보 관리

        // 회사
        public void insertCompany(Company company)
        {
            try
            {
                string sql = string.Format("insert into company_t " +
                   "values (company_t_seq.nextval, '{0}', '{1}', '{2}', '{3}', '{4}')",
                   company.CName,
                   company.CeoName,
                   company.RegNum,
                   company.TelNum,
                   company.Address
                   );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public List<Company> selectCompany()
        {
            string sql = "select * from company_t";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Company> companyList = new List<Company>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Company company = new Company
                    (
                        int.Parse(rd["ccode"].ToString()),
                        rd["cname"].ToString(),
                        rd["ceoName"].ToString(),
                        rd["regnum"].ToString(),
                        rd["address"].ToString(),
                        rd["telnum"].ToString()
                    );
                    companyList.Add(company);
                }
            }
            else
            {
                Console.WriteLine("거래처관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return companyList;
        }
        public List<Company> selectCompany(int cCode)
        {
            string sql = string.Format("select * from company_t where cCode = {0}", cCode);

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Company> companyList = new List<Company>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Company company = new Company
                    (
                        int.Parse(rd["ccode"].ToString()),
                        rd["cname"].ToString(),
                        rd["ceoName"].ToString(),
                        rd["regnum"].ToString(),
                        rd["address"].ToString(),
                        rd["telnum"].ToString()
                    );
                    companyList.Add(company);
                }
            }
            else
            {
                Console.WriteLine("거래처관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return companyList;
        }
        public void deleteCompany(int cCode)
        {
            try
            {
                string sql = string.Format("delete company_t where ccode = {0}", cCode);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }
        public void updateCompany(Company company)
        {
            try
            {
                string sql = string.Format("update company_t SET " +
                    "cName = '{0}', ceoName = '{1}', regNum = '{2}', telNum = '{3}', address = '{4}' " +
                    "WHERE ccode = {5}",
                   company.CName,
                   company.CeoName,
                   company.RegNum,
                   company.TelNum,
                   company.Address,
                   company.CCode
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 오류: " + e.Message);
            }
        }

        // 자재
        public void insertMaterial(Material material)
        {
            try
            {
                string sql1 = string.Format("insert into material_t " +
                   "values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                   material.MCode,
                   material.MClass,
                   material.MName,
                   material.Unit,
                   material.Standard
                   );
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();

                string sql2 = string.Format("insert into cost_t " +
                  "values ('{0}', {1})",
                  material.MCode,
                  material.Price
                  );
                cmd.Connection = conn;
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public List<Material> selectMaterial()
        {
            string sql = "select mt.mcode, mt.mclass, mt.mname, mt.unit, mt.standard, ct.price "
                + "from material_t mt, cost_t ct "
                + "where mt.mcode = ct.mcode";

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Material> materialList = new List<Material>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Material material = new Material
                    (
                        rd["mcode"].ToString(),
                        rd["mclass"].ToString(),
                        rd["mname"].ToString(),
                        rd["unit"].ToString(),
                        rd["standard"].ToString(),
                        int.Parse(rd["price"].ToString())
                    );
                    materialList.Add(material);
                }
            }
            else
            {
                Console.WriteLine("자재 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return materialList;
        }
        public List<Material> selectMaterial(string mCode)
        {
            string sql = string.Format("select mt.mcode, mt.mclass, mt.mname, mt.unit, mt.standard, ct.price "
                + "from material_t mt, cost_t ct "
                + "where mt.mcode = ct.mcode and mt.mcode = '{0}'", mCode);

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Material> materialList = new List<Material>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Material material = new Material
                    (
                        rd["mcode"].ToString(),
                        rd["mclass"].ToString(),
                        rd["mname"].ToString(),
                        rd["unit"].ToString(),
                        rd["standard"].ToString(),
                        int.Parse(rd["price"].ToString())
                    );
                    materialList.Add(material);
                }
            }
            else
            {
                Console.WriteLine("자재 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return materialList;
        }
        public void deleteMaterial(string mCode)
        {
            try
            {
                string sql1 = string.Format("delete cost_t where mcode = '{0}'", mCode);
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();

                string sql2 = string.Format("delete material_t where mcode = '{0}'", mCode);
                cmd.Connection = conn;
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }
        public void updateMaterial(Material material)
        {
            try
            {
                string sql1 = string.Format("update material_t SET " +
                    "mclass = '{0}', mname = '{1}', unit = '{2}', standard = '{3}'" +
                    "WHERE mcode = '{4}'",
                   material.MClass,
                   material.MName,
                   material.Unit,
                   material.Standard,
                   material.MCode
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();

                string sql2 = string.Format("update cost_t SET " +
                    "price = {0} WHERE mcode = '{1}'",
                    material.Price,
                    material.MCode
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql2;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 오류: " + e.Message);
            }
        }


        // 공정
        public void insertOperation(Operation operation)
        {
            try
            {
                string sql = string.Format("insert into operation_t " +
                   "values ('{0}', '{1}', '{2}')",
                   operation.OprCode,
                   operation.OprName,
                   operation.OprDescription
                   );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public List<Operation> selectOperation()
        {
            string sql = string.Format("select * from operation_t");

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Operation> operationList = new List<Operation>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Operation operation = new Operation
                    (
                        rd["oprcode"].ToString(),
                        rd["oprname"].ToString(),
                        rd["oprdescription"].ToString()
                    );
                    operationList.Add(operation);
                }
            }
            else
            {
                Console.WriteLine("공정 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return operationList;
        }
        public List<Operation> selectOperation(string oprCode)
        {
            string sql = string.Format("select * from operation_t where oprcode = '{0}'", oprCode);

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Operation> operationList = new List<Operation>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Operation operation = new Operation
                    (
                        rd["oprcode"].ToString(),
                        rd["oprname"].ToString(),
                        rd["oprdescription"].ToString()
                    );
                    operationList.Add(operation);
                }
            }
            else
            {
                Console.WriteLine("공정 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return operationList;
        }
        public void updateOperation(Operation operation)
        {
            try
            {
                string sql = string.Format("update operation_t SET " +
                    "oprname = '{0}', oprdescription = '{1}' where oprcode = '{2}'",
                   operation.OprName,
                   operation.OprDescription,
                   operation.OprCode
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 오류: " + e.Message);
            }
        }
        public void deleteOperation(string oprCode)
        {
            try
            {
                string sql = string.Format("delete operation_t where oprCode = '{0}'", oprCode);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }


        // 창고
        public void insertWarehouse(Warehouse warehouse)
        {
            try
            {
                string sql = string.Format("insert into warehouse_t " +
                   "values (warehouse_t_seq.nextval, '{0}', '{1}')",
                   warehouse.WName,
                   warehouse.WDescription
                   );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public List<Warehouse> selectWarehouse()
        {
            string sql = string.Format("select * from warehouse_t");

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Warehouse> warehouseList = new List<Warehouse>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Warehouse warehouse = new Warehouse
                    (
                        int.Parse(rd["wcode"].ToString()),
                        rd["wname"].ToString(),
                        rd["wdescription"].ToString()
                    );
                    warehouseList.Add(warehouse);
                }
            }
            else
            {
                Console.WriteLine("창고 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return warehouseList;
        }
        public List<Warehouse> selectWarehouse(int wCode)
        {
            string sql = string.Format("select * from warehouse_t where wcode = {0}", wCode);

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Warehouse> warehouseList = new List<Warehouse>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Warehouse warehouse = new Warehouse
                    (
                        int.Parse(rd["wcode"].ToString()),
                        rd["wname"].ToString(),
                        rd["wdescription"].ToString()
                    );
                    warehouseList.Add(warehouse);
                }
            }
            else
            {
                Console.WriteLine("창고 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return warehouseList;
        }
        public void updateWarehouse(Warehouse warehouse)
        {
            try
            {
                string sql = string.Format("update warehouse_t SET " +
                    "wname = '{0}', wdescription = '{1}' where wcode = '{2}'",
                   warehouse.WName,
                   warehouse.WDescription,
                   warehouse.WCode
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 오류: " + e.Message);
            }
        }
        public void deleteWarehouse(int wCode)
        {
            try
            {
                string sql = string.Format("delete warehouse_t where wCode = {0}", wCode);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }
        // BOM
        public void insertBOM(BOM bom)
        {
            try
            {
                string sql = string.Format("insert into bom_t " +
                    "values ('{0}', '{1}', {2})",
                    bom.Pmcode,
                    bom.Cmcode,
                    bom.Amount
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public void deleteBOM(string PMCode, string CMCode)
        {
            try
            {
                string sql = string.Format("delete from bom_t " +
                    "where pmcode = '{0}' and cmcode = '{1}'",
                    PMCode,
                    CMCode
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public List<BOM> selectPBOM(string PMCode)
        {
            string selectSql = "select distinct pmcode, mname, standard, unit from bom_t, material_t";
            string whereSql = " where bom_t.pmcode = material_t.mcode";
            if (PMCode != "")
            {
                whereSql += string.Format(" and pmcode = '{0}'", PMCode);
            }
            string sql = selectSql + whereSql;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<BOM> bomList = new List<BOM>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    BOM bom = new BOM
                    (
                        rd["pmcode"].ToString(),
                        rd["mname"].ToString(),
                        rd["standard"].ToString(),
                        rd["unit"].ToString()
                    );
                    bomList.Add(bom);
                }
            }
            else
            {
                Console.WriteLine("창고 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return bomList;
        }

        public List<BOM> selectCBOM(string CMCode)
        {
            string selectSql = "select cmcode, mname, standard, unit, amount from bom_t, material_t";
            string whereSql = " where bom_t.cmcode = material_t.mcode";
            if (CMCode != "")
            {
                whereSql += string.Format(" and pmcode = '{0}'", CMCode);
            }
            string sql = selectSql + whereSql;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<BOM> bomList = new List<BOM>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    BOM bom = new BOM
                    (
                        rd["cmcode"].ToString(),
                        rd["mname"].ToString(),
                        rd["standard"].ToString(),
                        rd["unit"].ToString(),
                        int.Parse(rd["amount"].ToString())
                    );
                    bomList.Add(bom);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return bomList;
        }

        public List<BOM> selectRCBOM(string CMCode)
        {
            string sql = "select distinct bom.pmcode as 모품번, pm.mname as 모품명, bom.cmcode as 자품번, " +
                "cm.mname as 자품명, cm.standard as 규격, cm.unit as 단위, bom.amount as 소요량" +
                " from bom_t bom, material_t cm, material_t pm" +
                " where bom.cmcode = cm.mcode and bom.pmcode = pm.mcode";

            if (CMCode != "")
            {
                sql += string.Format(" and bom.cmcode = '{0}'", CMCode);
            }

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            Console.WriteLine("BOMSQL:" + sql);
            OracleDataReader rd = cmd.ExecuteReader();
            List<BOM> bomList = new List<BOM>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    BOM bom = new BOM
                    (
                        rd["모품번"].ToString(),
                        rd["모품명"].ToString(),
                        rd["자품번"].ToString(),
                        rd["자품명"].ToString(),
                        int.Parse(rd["소요량"].ToString()),
                        rd["규격"].ToString(),
                        rd["단위"].ToString()
                    );
                    bomList.Add(bom);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return bomList;
        }

        // 생산관리
        public void insertPPlan(PPlan pplan)
        {
            try
            {
                string sql = string.Format("insert into pplan_t " +
                    "values (pplan_t_seq.nextval, '{0}', {1}, '{2}', {3}, '{4}')",
                    pplan.MCode,
                    pplan.Amount,
                    pplan.PTarget,
                    pplan.ECode,
                    pplan.RedDate
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                Console.WriteLine("pplan:" + sql);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        // * 구매/자재 모듈
        // 발주 관리
        public void insertPOrder(POrder porder)
        {
            try
            {
                string sql = string.Format("insert into porder_t " +
                    "values (porder_t_seq.nextval, '{0}',{1},{2})",
                    porder.POrderDate,
                    porder.CCode,
                    porder.ECode
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                Console.WriteLine("porder:" + sql);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public void insertPOrderDetail(POrderDetail porderdetail)
        {
            try
            {
                string sql = string.Format("insert into porderdetail_t" +
                    " values (porder_t_seq.currval," +
                    "'{0}',{1},'{2}',{3},{4},{5},{6},'미납')",
                    porderdetail.MCode,
                    porderdetail.Amount,
                    porderdetail.InDueDate,
                    porderdetail.Price,
                    porderdetail.SupplyPrice,
                    porderdetail.VAT,
                    porderdetail.SumPrice
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                Console.WriteLine("porderdetail:" + sql);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public List<TPOrder> selectTPOrder(Dictionary<string, string> searchCondition, string[,] searchDate)
        {
            string selectSql =
                "select porder_t.pcode as 발주번호, porderdate, ccode,ecode,porderdetail_t.mcode as 품번,mname," +
                "unit, standard as 규격, amount,induedate,price,supplyprice,vat,sumprice,pstatus";
            string fromSql =
                " from porder_t,porderdetail_t,material_t";

            string whereSql =
                " where porder_t.pcode = porderdetail_t.pcode and porderdetail_t.mcode = material_t.mcode";
            string orderby = " order by porder_t.pcode";
            foreach (KeyValuePair<string, string> pair in searchCondition)
            {
                if (pair.Key == "pcode")
                {
                    whereSql += string.Format(" and " +
                        "porder_t.{0} = {1}", pair.Key, pair.Value);
                }
                else if (pair.Key == "mcode")
                {
                    whereSql += string.Format(" and " +
                        "porderdetail_t.{0} = '{1}'", pair.Key, pair.Value);
                }
                else
                {
                    whereSql += string.Format(" and {0} = '{1}'", pair.Key, pair.Value);
                }
            }
            for (int i = 0; i < searchDate.GetLength(0); i++)
            {
                whereSql += string.Format(" and {0} between to_date('{1}','yyyy-mm-dd')" +
                    " and to_date('{2}','yyyy-mm-dd') ",
                    searchDate[i, 0], searchDate[i, 1], searchDate[i, 2]);
            }

            string sql = selectSql + fromSql + whereSql + orderby;
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<TPOrder> tporderList = new List<TPOrder>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    TPOrder tporderAdd = new TPOrder
                    (
                        int.Parse(rd["발주번호"].ToString()),
                        rd["porderdate"].ToString(),
                        int.Parse(rd["ccode"].ToString()),
                        rd["품번"].ToString(),
                        rd["mname"].ToString(),
                        rd["규격"].ToString(),
                        int.Parse(rd["amount"].ToString()),
                        rd["unit"].ToString(),
                        rd["induedate"].ToString(),
                        int.Parse(rd["price"].ToString()),
                        int.Parse(rd["supplyprice"].ToString()),
                        int.Parse(rd["vat"].ToString()),
                        int.Parse(rd["sumprice"].ToString()),
                        int.Parse(rd["ecode"].ToString()),
                        rd["pstatus"].ToString()
                    );
                    tporderList.Add(tporderAdd);
                }
            }
            else
            {
                Console.WriteLine("불량유형관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return tporderList;
        }
        public List<Material> selectMaterialInfo(string mcode)
        {
            string selectSql = string.Format("select mCode, mName, unit, standard");
            string fromSql = " from material_t ";
            string whereSql = " where 1=1 ";
            whereSql += string.Format(" and mcode = '{0}'", mcode);
            string sql = selectSql + fromSql + whereSql;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Material> materialList = new List<Material>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Material material = new Material
                    (
                        rd["mName"].ToString(),
                        rd["unit"].ToString(),
                        rd["standard"].ToString()
                    );
                    materialList.Add(material);
                }
            }
            else
            {
                Console.WriteLine("입력하신 품번코드관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return materialList;
        }
        public List<Cost> selectPriceInfo(string mcode)
        {
            string selectSql = string.Format("select mCode, price");
            string fromSql = " from cost_t ";
            string whereSql = " where 1=1 ";
            whereSql += string.Format(" and mcode = '{0}'", mcode);
            string sql = selectSql + fromSql + whereSql;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Cost> costList = new List<Cost>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Cost cost = new Cost
                    (
                        int.Parse(rd["price"].ToString())
                    );
                    costList.Add(cost);
                }
            }
            else
            {
                Console.WriteLine("입력하신 품번코드관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return costList;
        }

        // 입고 관리
        public void insertInput(Input input)
        {
            try
            {
                string sql = string.Format("insert into input_t" +
                    " values ({0},'{1}',{2},'{3}',{4},{5},0)",
                    input.PCode,
                    input.MCode,
                    input.CCode,
                    input.InDate,
                    input.Amount,
                    input.WCode
                    );
                cmd.Connection = conn;
                Console.WriteLine("sql:" + sql);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public void updateStock(Input input)
        {
            try
            {
                string updateSql =
                    string.Format("update stock_t " +
                        "set amount = (select amount + {0} from stock_t where mcode = '{1}' and wcode = {2})" +
                        "where mcode = '{1}' and wcode = {2}",
                        input.Amount,
                        input.MCode,
                        input.WCode
                    );
                Console.WriteLine("updateSql" + updateSql);
                cmd.Connection = conn;
                cmd.CommandText = updateSql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        // 출고 관리
        public void insertOutput(Output output)
        {
            try
            {
                string sql = string.Format("insert into output_t" +
                    " values ({0},'{1}',{2},'{3}','{4}',{5},{6})",
                    output.ReqCode,
                    output.MCode,
                    output.Amount,
                    output.WCode,
                    output.ECode,
                    output.ReqDate,
                    output.OutDate
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public List<OutputReq> selectOutputReq(Dictionary<string, string> searchCondition, string[,] searchDate)
        {
            string selectSql =
                "select reqcode, outputreq_t.mcode2 as 품번, material_t.mname as 품명," +
                " amount, material_t.unit as 단위, reqdate, ecode";
            string fromSql =
                " from outputreq_t, material_t";
            string whereSql =
                " where outputreq_t.mcode2 = material_t.mcode";
            string orderby = " order by reqcode";
            foreach (KeyValuePair<string, string> pair in searchCondition)
            {
                if (pair.Key == "mCode2")
                {
                    whereSql += string.Format(" and " +
                        "material_t.{0} = {1}", pair.Key, pair.Value);
                }
                else
                {
                    whereSql += string.Format(" and {0} = '{1}'", pair.Key, pair.Value);
                }
            }
            for (int i = 0; i < searchDate.GetLength(0); i++)
            {
                whereSql += string.Format(" and {0} between '{1}' and '{2}' ",
                    searchDate[i, 0], searchDate[i, 1], searchDate[i, 2]);
            }

            string sql = selectSql + fromSql + whereSql + orderby;
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<OutputReq> outputreqlist = new List<OutputReq>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    OutputReq outputreq = new OutputReq
                    (
                        int.Parse(rd["reqcode"].ToString()),
                        rd["품번"].ToString(),
                        rd["품명"].ToString(),
                        int.Parse(rd["amount"].ToString()),
                        rd["단위"].ToString(),
                        rd["reqDate"].ToString(),
                        int.Parse(rd["eCode"].ToString())
                    );
                    outputreqlist.Add(outputreq);
                }
            }
            else
            {
                Console.WriteLine("출고요청 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return outputreqlist;
        }

        // 재고 관리
        public List<Stock> selectStock(Dictionary<string, string> searchCondition)
        {
            string selectSql =
                "select material_t.mclass as 자재구분, stock_t.mcode as 품번, material_t.mname as 품명," +
                "amount , material_t.unit as 단위, material_t.standard as 규격, wcode";
            string fromSql =
                " from stock_t,material_t";
            string whereSql =
                " where stock_t.mCode = material_t.mCode ";

            foreach (KeyValuePair<string, string> pair in searchCondition)
            {
                if (pair.Key == "mCode")
                {
                    whereSql += string.Format(" and " +
                        "stock_t.{0} = '{1}'", pair.Key, pair.Value);
                }
                else if (pair.Value == "전체")
                {
                    continue;
                }
                else
                {
                    whereSql += string.Format(" and {0} = '{1}'", pair.Key, pair.Value);
                }
            }

            string sql = selectSql + fromSql + whereSql;
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Stock> stockList = new List<Stock>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Stock stock = new Stock
                    (
                        rd["자재구분"].ToString(),
                        rd["품번"].ToString(),
                        rd["품명"].ToString(),
                        int.Parse(rd["amount"].ToString()),
                        rd["단위"].ToString(),
                        rd["규격"].ToString(),
                        int.Parse(rd["wcode"].ToString())
                    );
                    stockList.Add(stock);
                }
            }
            else
            {
                Console.WriteLine("재고관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return stockList;
        }
        public List<InOut> selectInOut(string mCode)
        {
            string selectInput =
                "select distinct '입고' as 입출고, material_t.mclass as 구분,pcode as 내역번호," +
                "input_t.mcode as 품번,material_t.mname as 품명,amount as 수량,wcode as 창고," +
                "material_t.unit as 단위, indate as 입출고일,cost_t.price as 단가," +
                "amount* cost_t.price as 공급가, amount* cost_t.price * 0.1 as 부가세, " +
                "amount* cost_t.price + amount * cost_t.price * 0.1 as 합계액";
            string fromInput =
                " from input_t, material_t, cost_t";
            string whereInput =
                string.Format(" where input_t.mcode = material_t.mcode and " +
                "input_t.mcode = cost_t.mcode and input_t.mCode = '{0}' UNION ALL ", mCode);

            string selectOutput =
                "select distinct '출고' as 입출고, material_t.mclass as 구분,reqcode as 내역번호," +
                "output_t.mcode as 품번,material_t.mname as 품명, amount as 수량,wcode as 창고," +
                "material_t.unit as 단위,outdate as 입출고일, cost_t.price as 단가, amount* cost_t.price as 공급가, " +
                "amount* cost_t.price * 0.1 as 부가세, amount* cost_t.price + amount * cost_t.price * 0.1 as 합계액";
            string fromOutput =
                " from output_t, material_t, cost_t";
            string whereOutput =
                string.Format(" where output_t.mcode = material_t.mcode and " +
                "output_t.mcode = cost_t.mcode and output_t.mCode = '{0}'", mCode);

            string sql = selectInput + fromInput + whereInput +
                selectOutput + fromOutput + whereOutput;
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<InOut> inOutList = new List<InOut>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    InOut inout = new InOut
                    (
                        rd["입출고"].ToString(),
                        rd["구분"].ToString(),
                        int.Parse(rd["내역번호"].ToString()),
                        rd["품번"].ToString(),
                        rd["품명"].ToString(),
                        int.Parse(rd["수량"].ToString()),
                        int.Parse(rd["창고"].ToString()),
                        rd["단위"].ToString(),
                        rd["입출고일"].ToString(),
                        int.Parse(rd["단가"].ToString()),
                        int.Parse(rd["공급가"].ToString()),
                        int.Parse(rd["부가세"].ToString()),
                        int.Parse(rd["합계액"].ToString())
                    );
                    inOutList.Add(inout);
                }
            }
            else
            {
                Console.WriteLine("재고관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return inOutList;
        }
        public List<InOut> selectInOut(Dictionary<string, string> searchCondition,
            string[,] searchDate, string inoutclass)
        {
            string selectInput = string.Empty;
            string fromInput = string.Empty;
            string whereInput = string.Empty;
            string inputSql = string.Empty;
            string selectOutput = string.Empty;
            string fromOutput = string.Empty;
            string whereOutput = string.Empty;
            string outputSql = string.Empty;
            string sql = string.Empty;

            selectInput =
                "select distinct '입고' as 입출고, material_t.mclass as 구분, pcode as 내역번호, " +
                "input_t.mcode as 품번, material_t.mname as 품명, amount as 수량, wcode as 창고, " +
                "material_t.unit as 단위,indate as 입출고일,cost_t.price as 단가, " +
                "amount* cost_t.price as 공급가, amount* cost_t.price * 0.1 as 부가세, " +
                "amount* cost_t.price + amount * cost_t.price * 0.1 as 합계액";

            fromInput =
            " from input_t, material_t, cost_t";

            whereInput =
                " where input_t.mcode = material_t.mcode and " +
                "input_t.mcode = cost_t.mcode";


            selectOutput =
                "select distinct '출고' as 입출고, material_t.mclass as 구분,reqcode as 내역번호," +
                "output_t.mcode as 품번,material_t.mname as 품명, amount as 수량, wcode as 창고," +
                " material_t.unit as 단위,outdate as 입출고일, cost_t.price as 단가, amount* cost_t.price as 공급가," +
                "amount* cost_t.price * 0.1 as 부가세, amount* cost_t.price + amount * cost_t.price * 0.1 as 합계액";

            fromOutput =
            " from output_t, material_t, cost_t";

            whereOutput =
                " where output_t.mcode = material_t.mcode and " +
                "output_t.mcode = cost_t.mcode";

            foreach (KeyValuePair<string, string> pair in searchCondition)
            {
                if (pair.Key == "mcode")
                {
                    whereInput += string.Format(" and " +
                        "input_t.{0} = {1}", pair.Key, pair.Value);
                    whereOutput += string.Format(" and " +
                        "output_t.{0} = {1}", pair.Key, pair.Value);
                }
                else
                {
                    whereInput += string.Format(" and {0} = '{1}'", pair.Key, pair.Value);
                }
            }
            for (int i = 0; i < searchDate.GetLength(0); i++)
            {
                whereInput += string.Format(" and indate between to_date('{0}','yyyy-mm-dd')" +
                    " and to_date('{1}','yyyy-mm-dd') ",
                    searchDate[i, 1], searchDate[i, 2]);
                whereOutput += string.Format(" and outdate between to_date('{0}','yyyy-mm-dd')" +
                    " and to_date('{1}','yyyy-mm-dd') ",
                    searchDate[i, 1], searchDate[i, 2]);
            }

            if (inoutclass == "입고")
            {
                sql = selectInput + fromInput + whereInput;
            }
            else if (inoutclass == "출고")
            {
                sql = selectOutput + fromOutput + whereOutput;
            }
            else
            {
                sql = selectInput + fromInput + whereInput + " UNION ALL " +
                    selectOutput + fromOutput + whereOutput;
            }
            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine("sql:" + sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<InOut> inOutList = new List<InOut>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    InOut inout = new InOut
                    (
                        rd["입출고"].ToString(),
                        rd["구분"].ToString(),
                        int.Parse(rd["내역번호"].ToString()),
                        rd["품번"].ToString(),
                        rd["품명"].ToString(),
                        int.Parse(rd["수량"].ToString()),
                        int.Parse(rd["창고"].ToString()),
                        rd["단위"].ToString(),
                        rd["입출고일"].ToString(),
                        int.Parse(rd["단가"].ToString()),
                        int.Parse(rd["공급가"].ToString()),
                        int.Parse(rd["부가세"].ToString()),
                        int.Parse(rd["합계액"].ToString())
                    );
                    inOutList.Add(inout);
                }
            }
            else
            {
                Console.WriteLine("재고관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return inOutList;
        }
        //매입 관리
        public List<Input> selectNoConfirmedInput(Dictionary<string, string> searchCondition, string[,] searchDate)
        {
            string selectSql =
                "select pcode as 발주번호, input_t.ccode as 거래처번호,company_t.cname as 거래처명," +
                "input_t.mcode as 품번, material_t.mname as 품명, indate as 입고일자, amount as 수량, " +
                "material_t.unit as 단위,cost_t.price as 단가,amount* cost_t.price as 공급가" +
                ",amount* cost_t.price * 0.1 as 부가세," +
                "amount* cost_t.price + amount * cost_t.price * 0.1 as 합계액";
            string fromSql =
                " from input_t,company_t,material_t,cost_t";
            string whereSql =
                " where input_t.ccode = company_t.ccode and input_t.mcode = material_t.mcode " +
                "and input_t.mcode = cost_t.mcode and confirm = 0";

            foreach (KeyValuePair<string, string> pair in searchCondition)
            {
                if (pair.Key == "pcode")
                {
                    whereSql += string.Format(" and " +
                        "input_t.{0} = {1}", pair.Key, pair.Value);
                }
                else if (pair.Key == "mcode")
                {
                    whereSql += string.Format(" and " +
                        "material_t.{0} = '{1}'", pair.Key, pair.Value);
                }
                else if (pair.Key == "ccode")
                {
                    whereSql += string.Format(" and " +
                        "company_t.{0} = {1}", pair.Key, pair.Value);
                }
                else
                {
                    whereSql += string.Format(" and {0} = '{1}'", pair.Key, pair.Value);
                }
            }
            for (int i = 0; i < searchDate.GetLength(0); i++)
            {
                whereSql += string.Format(" and {0} between '{1}' and '{2}' ",
                    searchDate[i, 0], searchDate[i, 1], searchDate[i, 2]);
            }

            string sql = selectSql + fromSql + whereSql;
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Input> inputList = new List<Input>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Input input = new Input
                    (
                        int.Parse(rd["발주번호"].ToString()),
                        int.Parse(rd["거래처번호"].ToString()),
                        rd["거래처명"].ToString(),
                        rd["품번"].ToString(),
                        rd["품명"].ToString(),
                        rd["입고일자"].ToString(),
                        int.Parse(rd["수량"].ToString()),
                        rd["단위"].ToString(),
                        int.Parse(rd["단가"].ToString()),
                        int.Parse(rd["공급가"].ToString()),
                        int.Parse(rd["부가세"].ToString()),
                        int.Parse(rd["합계액"].ToString())
                    );
                    inputList.Add(input);
                }
            }
            else
            {
                Console.WriteLine("재고관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return inputList;
        }
        public List<Input> selectConfirmedInput(Dictionary<string, string> searchCondition, string[,] searchDate)
        {
            string selectSql =
                "select confirmdate as 확정일자, input_t.pcode as 발주번호, " +
                "input_t.ccode as 거래처번호,company_t.cname as 거래처명," +
                "input_t.mcode as 품번, material_t.mname as 품명, indate as 입고일자, " +
                "input_t.amount as 수량, material_t.unit as 단위,cost_t.price as 단가," +
                "input_t.amount* cost_t.price as 공급가,input_t.amount* cost_t.price * 0.1 as 부가세," +
                "input_t.amount* cost_t.price + input_t.amount * cost_t.price * 0.1 as 합계액";
            string fromSql =
                " from input_t,company_t,material_t,cost_t, buying_t";
            string whereSql =
                " where input_t.ccode = company_t.ccode and input_t.mcode = material_t.mcode " +
                "and input_t.mcode = cost_t.mcode and confirm = 1 and input_t.pcode = buying_t.pcode and" +
                " input_t.mcode = buying_t.mcode and input_t.amount = buying_t.amount";

            foreach (KeyValuePair<string, string> pair in searchCondition)
            {
                if (pair.Key == "pcode")
                {
                    whereSql += string.Format(" and " +
                        "input_t.{0} = {1}", pair.Key, pair.Value);
                }
                else if (pair.Key == "mcode")
                {
                    whereSql += string.Format(" and " +
                        "material_t.{0} = '{1}'", pair.Key, pair.Value);
                }
                else if (pair.Key == "ccode")
                {
                    whereSql += string.Format(" and " +
                        "company_t.{0} = {1}", pair.Key, pair.Value);
                }
                else
                {
                    whereSql += string.Format(" and {0} = '{1}'", pair.Key, pair.Value);
                }
            }
            for (int i = 0; i < searchDate.GetLength(0); i++)
            {
                whereSql += string.Format(" and {0} between '{1}' and '{2}' ",
                    searchDate[i, 0], searchDate[i, 1], searchDate[i, 2]);
            }

            string sql = selectSql + fromSql + whereSql;
            Console.WriteLine("SQL:" + sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Input> inputList = new List<Input>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Input input = new Input
                    (
                        rd["확정일자"].ToString(),
                        int.Parse(rd["발주번호"].ToString()),
                        int.Parse(rd["거래처번호"].ToString()),
                        rd["거래처명"].ToString(),
                        rd["품번"].ToString(),
                        rd["품명"].ToString(),
                        rd["입고일자"].ToString(),
                        int.Parse(rd["수량"].ToString()),
                        rd["단위"].ToString(),
                        int.Parse(rd["단가"].ToString()),
                        int.Parse(rd["공급가"].ToString()),
                        int.Parse(rd["부가세"].ToString()),
                        int.Parse(rd["합계액"].ToString())
                    );
                    inputList.Add(input);
                }
            }
            else
            {
                Console.WriteLine("재고관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return inputList;
        }
        public void updateInputConfirm(Input input)
        {
            try
            {
                string updateSql =
                    string.Format("update input_t " +
                        " set confirm = 1" +
                        " where pcode = {0} and mcode = '{1}' and indate = '{2}' and amount = {3} and confirm = 0",
                        input.PCode,
                        input.MCode,
                        input.InDate,
                        input.Amount
                    );
                cmd.Connection = conn;
                cmd.CommandText = updateSql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public void insertBuying(Buying buying)
        {
            try
            {
                string sql = string.Format("insert into buying_t" +
                    " values ('{0}', {1},{2},'{3}',{4},{5},{6},{7},{8})",
                    buying.ConfirmDate,
                    buying.PCode,
                    buying.CCode,
                    buying.MCode,
                    buying.Amount,
                    buying.Price,
                    buying.SupplyPrice,
                    buying.VAT1,
                    buying.SumPrice
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                Console.WriteLine("SQL:" + sql);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        //기타
        public string selectDeparture(string IDNumber)
        {
            string sql = string.Format("select departure from employee_t where ecode = '{0}'", IDNumber);

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            //List<Input> inputList = new List<Input>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    //Input input = new Input
                    //(
                    //   rd["departure"].ToString())
                    //);
                    //inputList.Add(input);
                    IDNumber = rd["departure"].ToString();
                }
            }
            else
            {
                Console.WriteLine("재고관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return IDNumber;
        }
    }
}
