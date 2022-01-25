using ERP_TESLA.CLASS.Cost;
using ERP_TESLA.CLASS.HR;
using ERP_TESLA.CLASS.Production;
using ERP_TESLA.CLASS.Standard;
using ERP_TESLA.CLASS.WarePurchase;
using ERP_TESLA.Model;
using ERP_TESLA.Model.HR;
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
            "User Id=c##lee; Password=tiger;";
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
                   "values ('{0}', '{1}', '{2}', {3})",
                   operation.OprCode,
                   operation.OprName,
                   operation.OprDescription,
                   operation.OprManHour
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
                        int.Parse(rd["manhour"].ToString()),
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
                        int.Parse(rd["manhour"].ToString()),
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
                    "oprname = '{0}', oprdescription = '{1}', manhour = {2} where oprcode = '{3}'",
                   operation.OprName,
                   operation.OprDescription,
                   operation.OprManHour,
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
        public List<BOM> selectCMBOM(string CMCode)
        {
            string selectSql = "select cmcode, amount from bom_t, material_t";
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

        //* 인사 관리
        // 사원등록
        public List<Employee> selectEmployee()
        {
            string sql = "select ecode, ename, departure from employee_t";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Employee> employeelist = new List<Employee>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Employee employee = new Employee
                    (
                        int.Parse(rd["ecode"].ToString()),
                        rd["ename"].ToString(),
                        rd["departure"].ToString()
                    );
                    employeelist.Add(employee);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return employeelist;
        }
        public List<Employee> selectEmployeeInfo(int eCode)
        {
            string sql = "select ecode, ename, departure from employee_t";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Employee> employeelist = new List<Employee>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Employee employee = new Employee
                    (
                        int.Parse(rd["ecode"].ToString()),
                        rd["ename"].ToString(),
                        rd["departure"].ToString()
                    );
                    employeelist.Add(employee);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return employeelist;
        }
        #region 출결관리
        public void insertAttendance(AttendanceModel attendanceModel)
        {
            try
            {
                string sql = string.Format("insert into attendance_t " +
                   "values ({0}, '{1}', '{2}', '{3}', {4}, {5}, {6}, {7}, {8})",
                   attendanceModel.ECode,
                   attendanceModel.EName,
                   attendanceModel.Departure,
                   attendanceModel.Grade,
                   attendanceModel.AttendYear,
                   attendanceModel.AttendMonth,
                   attendanceModel.VacationDays,
                   attendanceModel.SickDays,
                   attendanceModel.WorkingDays
                   );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                Console.WriteLine("attendance:" + sql);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        #endregion

        #region 급여관리        
        public void insertPayroll(PayrollModel payrollModel)
        {
            try
            {
                string sql = string.Format("insert into payroll_t " +
                   "values ({0}, '{1}', '{2}', '{3}', {4}, {5}, '{6}', {7}, {8}, {9})",
                   payrollModel.ECode,
                   payrollModel.EName,
                   payrollModel.Departure,
                   payrollModel.Grade,
                   payrollModel.AttendYear,
                   payrollModel.AttendMonth,
                   payrollModel.PayMentDate,
                   payrollModel.WorkingDays,
                   payrollModel.PayMentStandard,
                   payrollModel.PayMenttotal
                   );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                Console.WriteLine("attendance:" + sql);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public List<PayrollModel> selectPayroll(string eName, int attendYear, int attendMonth)
        {
            List<PayrollModel> payrollModelList = new List<PayrollModel>();

            string sql = string.Format("select * from payroll_t " +
                "where ename = '{0}' and attendyear = {1} and attendmonth = {2}", eName, attendYear, attendMonth);
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    PayrollModel payrollModel = new PayrollModel
                    (
                        int.Parse(rd["ecode"].ToString()),
                        rd["ename"].ToString(),
                        rd["departure"].ToString(),
                        rd["grade"].ToString(),
                        int.Parse(rd["attendyear"].ToString()),
                        int.Parse(rd["attendmonth"].ToString()),
                        rd["paymentdate"].ToString(),
                        int.Parse(rd["workingdays"].ToString()),
                        int.Parse(rd["paymentstandard"].ToString()),
                        int.Parse(rd["paymenttotal"].ToString())
                    );
                    payrollModelList.Add(payrollModel);
                }
            }
            else
            {
                Console.WriteLine("급여관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return payrollModelList;
        }
        #endregion

        // * 생산관리
        // 생산계획관리
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
                    pplan.RegDate
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
        public List<SelectPPlan> selectPPlan()
        {

            string selectSql = "select pt.proplancode, mt.mcode, mt.mname, mt.unit, pt.amount, pt.ptarget, pt.regdate, et.ecode ";
            string fromSql = "from pplan_t pt, material_t mt, employee_t et ";
            string whereSql = "where pt.mcode = mt.mcode and pt.ecode = et.ecode order by proplancode desc";

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<SelectPPlan> selectPPlanList = new List<SelectPPlan>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SelectPPlan selectPPlan = new SelectPPlan
                   (
                       int.Parse(rd["proplancode"].ToString()),
                       rd["mcode"].ToString(),
                       rd["mname"].ToString(),
                       rd["unit"].ToString(),
                       int.Parse(rd["amount"].ToString()),
                       rd["ptarget"].ToString(),
                       rd["regdate"].ToString(),
                       int.Parse(rd["ecode"].ToString())
                   );
                    selectPPlanList.Add(selectPPlan);
                }
            }
            else
            {
                Console.WriteLine("생산계획 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return selectPPlanList;
        }
        public List<SelectPPlan> selectPPlan(Dictionary<string, string> search, Dictionary<string, List<string>> searchDate)
        {

            string selectSql = "select pt.proplancode, mt.mcode, mt.mname, mt.unit, pt.amount, pt.ptarget, pt.regdate, et.ecode ";
            string fromSql = "from pplan_t pt, material_t mt, employee_t et ";
            string whereSql = "where pt.mcode = mt.mcode and pt.ecode = et.ecode ";

            foreach (KeyValuePair<string, string> item in search)
            {
                if (item.Value != "")
                {
                    whereSql += string.Format("and pt.{0} = '{1}' ", item.Key, item.Value);
                }
            }
            foreach (KeyValuePair<string, List<string>> item in searchDate)
            {
                if (item.Key == "regdate")
                {
                    whereSql += string.Format("and regdate between to_date('{0}','YYYY-MM-DD') "
                        + "and to_date('{1}','YYYY-MM-DD')", item.Value[0], item.Value[1]);
                }
                if (item.Key == "ptarget")
                {
                    whereSql += string.Format("and ptarget between to_date('{0}','YYYY-MM-DD') "
                        + "and to_date('{1}','YYYY-MM-DD')", item.Value[0], item.Value[1]);
                }
            }

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<SelectPPlan> selectPPlanList = new List<SelectPPlan>();
            Console.Write(rd.HasRows);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    SelectPPlan selectPPlan = new SelectPPlan
                    (
                        int.Parse(rd["proplancode"].ToString()),
                        rd["mcode"].ToString(),
                        rd["mname"].ToString(),
                        rd["unit"].ToString(),
                        int.Parse(rd["amount"].ToString()),
                        rd["ptarget"].ToString(),
                        rd["regdate"].ToString(),
                        int.Parse(rd["ecode"].ToString())
                    );
                    selectPPlanList.Add(selectPPlan);
                }
            }
            else
            {
                Console.WriteLine("생산계획 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return selectPPlanList;
        }

        // 작업지시관리
        public void insertWOrder(WOrder wOrder)
        {
            try
            {
                string sql = string.Format("insert into worder_t " +
                   "values (workordercode_t_seq.nextval, {0}, '{1}', {2}, '{3}', {4}, '{5}')",
                   wOrder.ProPlanCode,
                   wOrder.OrderDate,
                   wOrder.CCode,
                   wOrder.EndDate,
                   wOrder.Amount,
                   wOrder.WorkStatus
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
        public List<WOrder> selectWOrder()
        {

            string selectSql = "select pt.proplancode, wt.orderdate, wt.enddate, ct.ccode, mt.mcode, mt.mname, wt.amount, wt.workstaus, wt.workordercode ";
            string fromSql = "from worder_t wt, pplan_t pt, material_t mt, company_t ct ";
            string whereSql = "where wt.proplancode = pt.proplancode and pt.mcode = mt.mcode and wt.ccode = ct.ccode ";

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<WOrder> wOrderList = new List<WOrder>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    WOrder wOrder = new WOrder
                    (
                        int.Parse(rd["proplancode"].ToString()),
                        rd["orderdate"].ToString(),
                        rd["enddate"].ToString(),
                        int.Parse(rd["ccode"].ToString()),
                        rd["mcode"].ToString(),
                        rd["mname"].ToString(),
                        int.Parse(rd["amount"].ToString()),
                        rd["workstaus"].ToString(),
                        int.Parse(rd["workordercode"].ToString())
                    );
                    wOrderList.Add(wOrder);
                }
            }
            else
            {
                Console.WriteLine("작업지시 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return wOrderList;
        }
        public List<WOrder> selectWOrder(string proPlanSelected)
        {

            string selectSql = "select pt.proplancode, wt.orderdate, wt.enddate, ct.ccode, mt.mcode, mt.mname, wt.amount, wt.workstaus, wt.workordercode ";
            string fromSql = "from worder_t wt, pplan_t pt, material_t mt, company_t ct ";
            string whereSql = string.Format("where wt.proplancode = pt.proplancode and pt.mcode = mt.mcode and wt.ccode = ct.ccode and wt.proplancode = {0}", proPlanSelected); ;

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<WOrder> wOrderList = new List<WOrder>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    WOrder wOrder = new WOrder
                    (
                        int.Parse(rd["proplancode"].ToString()),
                        rd["orderdate"].ToString(),
                        rd["enddate"].ToString(),
                        int.Parse(rd["ccode"].ToString()),
                        rd["mcode"].ToString(),
                        rd["mname"].ToString(),
                        int.Parse(rd["amount"].ToString()),
                        rd["workstaus"].ToString(),
                        int.Parse(rd["workordercode"].ToString())
                    );
                    wOrderList.Add(wOrder);
                }
            }
            else
            {
                Console.WriteLine("작업지시 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return wOrderList;
        }
        public List<WOrder> selectWOrder(Dictionary<string, string> search, Dictionary<string, List<string>> searchDate)
        {
            string selectSql = "select pt.proplancode, wt.orderdate, wt.enddate, ct.ccode, mt.mcode, mt.mname, wt.amount, wt.workstaus, wt.workordercode ";
            string fromSql = "from worder_t wt, pplan_t pt, material_t mt, company_t ct ";
            string whereSql = "where wt.proplancode = pt.proplancode and pt.mcode = mt.mcode and wt.ccode = ct.ccode ";

            foreach (KeyValuePair<string, string> item in search)
            {
                if (item.Value != "")
                {
                    if (item.Key == "mCode")
                    {
                        whereSql += string.Format("and mt.{0} = '{1}' ", item.Key, item.Value);
                    }
                    else
                    {
                        whereSql += string.Format("and wt.{0} = '{1}' ", item.Key, item.Value);
                    }
                }
            }
            foreach (KeyValuePair<string, List<string>> item in searchDate)
            {
                if (item.Key == "orderDate")
                {
                    whereSql += string.Format("and orderDate between to_date('{0}','YYYY-MM-DD') "
                        + "and to_date('{1}','YYYY-MM-DD')", item.Value[0], item.Value[1]);
                }
                if (item.Key == "endDate")
                {
                    whereSql += string.Format("and endDate between to_date('{0}','YYYY-MM-DD') "
                        + "and to_date('{1}','YYYY-MM-DD')", item.Value[0], item.Value[1]);
                }
            }

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<WOrder> wOrderList = new List<WOrder>();
            Console.Write(rd.HasRows);

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    WOrder wOrder = new WOrder
                     (
                         int.Parse(rd["proplancode"].ToString()),
                         rd["orderdate"].ToString(),
                         rd["enddate"].ToString(),
                         int.Parse(rd["ccode"].ToString()),
                         rd["mcode"].ToString(),
                         rd["mname"].ToString(),
                         int.Parse(rd["amount"].ToString()),
                         rd["workstaus"].ToString(),
                         int.Parse(rd["workordercode"].ToString())
                     );
                    wOrderList.Add(wOrder);
                }
            }
            else
            {
                Console.WriteLine("작업지시 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return wOrderList;
        }
        public void updateWOrder(string workStatus, string workOrderCode)
        {
            try
            {
                string sql = string.Format("update worder_t SET " +
                    "workstaus = '{0}' where workordercode = '{1}'",
                    workStatus,
                    workOrderCode
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

        // 자재소요계획관리
        public void insertMRU(MRP mrp)
        {
            try
            {
                string sql = string.Format("insert into mrp_t " +
                    "values ({0}, '{1}', {2}, '{3}')",
                    mrp.ProPlanCode,
                    mrp.MCode,
                    mrp.Amount,
                    mrp.RequireDate
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                Console.WriteLine("mru:" + sql);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public List<MRP> selectMRP(Dictionary<string, string> search, Dictionary<string, List<string>> searchDate)
        {
            string selectSql = "select pt.proplancode, mt.mcode, mt.mname, mt.unit, mrp.amount, mrp.requiredate ";
            string fromSql = "from pplan_t pt, material_t mt, mrp_t mrp ";
            string whereSql = "where pt.proplancode = mrp.proplancode and mt.mcode = mrp.mcode  ";

            foreach (KeyValuePair<string, string> item in search)
            {
                if (item.Value != "")
                {
                    whereSql += string.Format("and mrp.{0} = '{1}' ", item.Key, item.Value);
                }
            }
            foreach (KeyValuePair<string, List<string>> item in searchDate)
            {
                if (item.Key == "requiredate")
                {
                    whereSql += string.Format("and requiredate between to_date('{0}','YYYY-MM-DD') "
                        + "and to_date('{1}','YYYY-MM-DD')", item.Value[0], item.Value[1]);
                }
            }

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<MRP> mrpList = new List<MRP>();
            Console.Write(rd.HasRows);

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    MRP mrp = new MRP
                     (
                         int.Parse(rd["proplancode"].ToString()),
                         rd["mcode"].ToString(),
                         rd["mname"].ToString(),
                         rd["unit"].ToString(),
                         int.Parse(rd["amount"].ToString()),
                         rd["requiredate"].ToString()
                     );
                    mrpList.Add(mrp);
                }
            }
            else
            {
                Console.WriteLine("자재소요계획 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return mrpList;
        }
        public List<MRP> selectMRP(string proPlanSelected)
        {
            string selectSql = "select pt.proplancode, mt.mcode, mt.mname, mt.unit, mrp.amount, mrp.requiredate ";
            string fromSql = "from pplan_t pt, material_t mt, mrp_t mrp ";
            string whereSql = string.Format("where pt.proplancode = mrp.proplancode and mt.mcode = mrp.mcode and pt.proplancode = {0}", proPlanSelected);

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<MRP> mrpList = new List<MRP>();
            Console.Write(rd.HasRows);

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    MRP mrp = new MRP
                     (
                         int.Parse(rd["proplancode"].ToString()),
                         rd["mcode"].ToString(),
                         rd["mname"].ToString(),
                         rd["unit"].ToString(),
                         int.Parse(rd["amount"].ToString()),
                         rd["requiredate"].ToString()
                     );
                    mrpList.Add(mrp);
                }
            }
            else
            {
                Console.WriteLine("자재소요계획 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return mrpList;
        }



        // 작업실적관리
        public void insertPer(Performance per)
        {
            try
            {
                string sql = string.Format("insert into performance_t " +
                    "values ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, '{8}')",
                    per.WorkOrderCode,
                    per.OrderAmount,
                    per.PerAmount,
                    per.PassAmount,
                    per.FailAmount,
                    per.WorkRemainder,
                    per.FailRate,
                    per.ECode,
                    per.OprCode
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                Console.WriteLine("performance:" + sql);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public List<Performance> selectPerformce(string workOrderCode, string eCode, string oprCode)
        {
            string selectSql = "select pt.workordercode, pt.orderamount, pt.peramount, pt.passamount, pt.failamount, pt.workremainder, pt.failrate, ot.oprcode, ot.manhour, et.ecode ";
            string fromSql = "from performance_t pt, operation_t ot, employee_t et ";
            string whereSql = "where pt.oprcode = ot.oprcode and pt.ecode = et.ecode ";

            if (workOrderCode != "" && eCode == "")
            {
                whereSql += string.Format("and workOrderCode = {0}", workOrderCode);
            }
            else if (workOrderCode == "" && eCode != "")
            {
                whereSql += string.Format("and eCode = {0}", eCode);
            }
            else if (workOrderCode != "" && eCode != "")
            {
                whereSql += string.Format("and workOrderCode = {0} and eCode = {1}", workOrderCode, eCode);
            }

            if (oprCode != "")
            {
                whereSql += string.Format("and oprCode = '{0}'", oprCode);
            }

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Performance> perList = new List<Performance>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Performance per = new Performance
                     (
                         int.Parse(rd["workOrderCode"].ToString()),
                         int.Parse(rd["orderAmount"].ToString()),
                         int.Parse(rd["perAmount"].ToString()),
                         int.Parse(rd["passAmount"].ToString()),
                         int.Parse(rd["failAmount"].ToString()),
                         int.Parse(rd["workRemainder"].ToString()),
                         double.Parse(rd["failRate"].ToString()),
                         rd["oprcode"].ToString(),
                         rd["manhour"].ToString(),
                         int.Parse(rd["eCode"].ToString())
                );
                    perList.Add(per);
                }
            }
            else
            {
                Console.WriteLine("작업실적 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return perList;
        }

        // 자재 출고 요청
        public void insertOutputReq(OutputReq outputReq)
        {
            try
            {
                string sql = string.Format("insert into outputReq_t " +
                    "values (outputReq_t_seq.nextval, {0}, '{1}', '{2}', '{3}', {4}, {5}, '{6}', '{7}')",
                    outputReq.WorkOrderCode,
                    outputReq.PMCode1,
                    outputReq.OprCode,
                    outputReq.MMCode1,
                    outputReq.Amount,
                    outputReq.ECode,
                    outputReq.ReqDate,
                    outputReq.ReqStatus
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                Console.WriteLine("outputReq:" + sql);
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public List<OutputReq> selectRequest(Dictionary<string, string> search, Dictionary<string, List<string>> searchDate)
        {
            string selectSql = "select ot.reqcode, ot.workordercode, ot.mcode1, pm.mname as 제품명, ot.mcode2, cm.mname as 원자재명, oprt.oprname, ot.amount, ot.reqdate, ot.reqstatus, et.ecode ";
            string fromSql = "from material_t pm, material_t cm, outputreq_t ot, operation_t oprt, worder_t wt, employee_t et ";
            string whereSql = "where ot.mcode1 = pm.mcode and ot.mcode2 = cm.mcode and ot.oprcode = oprt.oprcode and ot.ecode = et.ecode and ot.workordercode = wt.workordercode ";

            foreach (KeyValuePair<string, string> item in search)
            {
                if (item.Value != "")
                {
                    whereSql += string.Format("and ot.{0} = '{1}' ", item.Key, item.Value);
                }
            }
            foreach (KeyValuePair<string, List<string>> item in searchDate)
            {
                if (item.Key == "reqdate")
                {
                    whereSql += string.Format("and reqdate between to_date('{0}','YYYY-MM-DD') "
                        + "and to_date('{1}','YYYY-MM-DD')", item.Value[0], item.Value[1]);
                }
            }

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<OutputReq> reqList = new List<OutputReq>();
            Console.Write(rd.HasRows);

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    OutputReq req = new OutputReq
                     (
                         int.Parse(rd["reqcode"].ToString()),
                         int.Parse(rd["workordercode"].ToString()),
                         rd["mcode1"].ToString(),
                         rd["제품명"].ToString(),
                         rd["oprname"].ToString(),
                         rd["mcode2"].ToString(),
                         rd["원자재명"].ToString(),
                         int.Parse(rd["amount"].ToString()),
                         rd["reqdate"].ToString(),
                         int.Parse(rd["ecode"].ToString()),
                         rd["reqstatus"].ToString()
                     );
                    reqList.Add(req);
                }
            }
            else
            {
                Console.WriteLine("자재소요계획 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return reqList;
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
        public string selectMName(string MCode)
        {
            string sql =
                string.Format("select mname from material_t where mcode = '{0}'", MCode);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            string MName = string.Empty;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    MName = rd["mname"].ToString();
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return MName;
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

        // 매입 관리
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

        // * 영업 모듈
        // 수주 관리
        #region 수주관리
        // 등록
        public void insertContract(ContractModel contractModel)
        {
            try
            {
                string sql = string.Format("insert into sorder_t " +
                    "(sordercode, sorderdate, ccode, ecode, mcode, amount, deliverydate, price," +
                    "supplyprice, vat, sumprice)" +
                    "values (sorder_t_seq.nextval, " +
                    "'{0}',{1},{2},'{3}',{4},'{5}',{6},{7},{8},{9})",
                    contractModel.SOrderDate,
                    contractModel.CCode,
                    contractModel.Manager,
                    contractModel.MCode,
                    contractModel.Amount,
                    contractModel.DeliveryDate,
                    contractModel.Price,
                    contractModel.SupplyPrice,
                    contractModel.Vat,
                    contractModel.SumPrice
                    );
                Console.WriteLine(sql);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        // 조회 
        public List<ContractModel> selectContract()
        {
            string selectSql =
                "select distinct sordercode as 번호, sorderdate as 주문일, ccode as 거래처, ecode as 사번, " +
                "sorder_t.mcode as 품번, material_t.mname as 품명, material_t.unit as 단위," +
                "amount as 수량, deliverydate as 납기일, price as 단가, supplyprice as 공급가, " +
                "vat as 부가세, sumprice as 합계액, SALESSTATUS as 상태";
            string fromSql = " from sorder_t, material_t";
            string whereSql = " where sorder_t.mcode = material_t.mcode";

            string sql = selectSql + fromSql + whereSql;
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<ContractModel> contrancmodel = new List<ContractModel>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    ContractModel contracnt = new ContractModel
                    (
                        int.Parse(rd["번호"].ToString()),
                        rd["주문일"].ToString(),
                        int.Parse(rd["거래처"].ToString()),
                        int.Parse(rd["사번"].ToString()),
                        rd["품번"].ToString(),
                        rd["품명"].ToString(),
                        rd["단위"].ToString(),
                        int.Parse(rd["수량"].ToString()),
                        rd["납기일"].ToString(),
                        int.Parse(rd["단가"].ToString()),
                        int.Parse(rd["공급가"].ToString()),
                        int.Parse(rd["부가세"].ToString()),
                        int.Parse(rd["합계액"].ToString()),
                        rd["상태"].ToString()
                    );
                    contrancmodel.Add(contracnt);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return contrancmodel;
        }
        #endregion

        // 계약 확정
        public void updateContract(ContractModel contract)
        {
            try
            {
                string updateSql =
                    string.Format("update sorder_t " +
                        " set salesstatus = '1'" +
                        " where sordercode = {0}",
                        contract.SOrderCode
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

        // 원가관리
        public List<ProductCost> selectMCodeCost(Dictionary<string,string> searchCondition, string[,] searchDate)
        {
            string selectSql =
                "select pt.mcode as 품번, mt.mname as 품명, mt.standard as 규격," +
                "sum(et.passamount) as 실적수량, sum(et.failamount) as 불량수량, wt.enddate as 실적일";
            string fromSql =
                " from pPlan_t pt, worder_t wt, material_t mt, performance_t et";
            string whereSql =
                string.Format(" where pt.proplancode = wt.proplancode and pt.mcode = mt.mcode and wt.workordercode = et.workordercode");
            string groupbySql = " group by pt.mcode, mt.mname, mt.standard, wt.enddate";
            foreach (KeyValuePair<string, string> pair in searchCondition)
            {
                if (pair.Key == "mCode")
                {
                    whereSql += string.Format(" and " +
                        "pt.{0} = {1}", pair.Key, pair.Value);
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

            string sql = selectSql + fromSql + whereSql + groupbySql;
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<ProductCost> productcostList = new List<ProductCost>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    ProductCost productCost = new ProductCost
                    (
                        rd["품번"].ToString(),
                        rd["품명"].ToString(),
                        rd["규격"].ToString(),
                        int.Parse(rd["실적수량"].ToString()),
                        int.Parse(rd["불량수량"].ToString())
                    );
                    productcostList.Add(productCost);
                }
            }
            else
            {
                Console.WriteLine("재고관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return productcostList;

        }
        public int selectBuyingCost(string mcode, string[,] searchDate)
        {
            string selectSql =
                "select mcode, (sum(price) / count(price)) as 평균 , confirmdate";
            string fromSql =
                " from buying_t";
            string groupbySql = " group by mcode, confirmdate";
            string havingSql = 
                string.Format(" having {0} between '{1}' and '{2}'",searchDate[0,0],searchDate[0,1],searchDate[0,2]);

            string sql = selectSql + fromSql + groupbySql + havingSql;
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int cost = 0;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    cost = int.Parse(rd["평균"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return cost;
        }
        public int selectOperationCost(string mcode)
        {
            string selectSql =
                "select distinct pplan_t.mcode as 품번, performance_t.oprcode as 공정, operation_t.manhour as 공수";
            string fromSql =
                " from performance_t, operation_t, worder_t, pplan_t";
            string whereSql =
                string.Format(" where performance_t.workordercode = worder_t.workordercode and" +
                " worder_t.proplancode = pplan_t.proplancode and" +
                " performance_t.oprcode = operation_t.oprcode",mcode);


            string sql = selectSql + fromSql + whereSql;
            Console.WriteLine(sql);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int opertation = 0;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    opertation = int.Parse(rd["공수"].ToString());
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return opertation;
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

        // 팝업
        public List<Employee> selectPOPemployee(int start, int end)
        {
            string selectSql = "SELECT T2.ecode, T2.ename, T2.departure, T2.grade ";
            string fromSql = "FROM (SELECT ROW_NUMBER() OVER(ORDER BY T1.ecode) AS ROW_NUM, T1.*FROM employee_t T1) T2 ";
            string whereSql = string.Format("WHERE T2.ROW_NUM BETWEEN {0} AND {1}", start, end);
            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Employee> empList = new List<Employee>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Employee employee = new Employee
                    (
                        int.Parse(rd["ecode"].ToString()),
                        rd["ename"].ToString(),
                        rd["departure"].ToString(),
                        rd["grade"].ToString()
                    );
                    empList.Add(employee);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return empList;
        }
        public List<Company> selectPOPcompany(int start, int end)
        {
            string selectSql = "SELECT T2.ccode, T2.cname, T2.ceoname, T2.telnum ";
            string fromSql = "FROM (SELECT ROW_NUMBER() OVER(ORDER BY T1.ccode) AS ROW_NUM, T1.*FROM company_t T1) T2 ";
            string whereSql = string.Format("WHERE T2.ROW_NUM BETWEEN {0} AND {1}", start, end);
            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Company> comList = new List<Company>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Company company = new Company
                    (
                        int.Parse(rd["ccode"].ToString()),
                        rd["cname"].ToString(),
                        rd["ceoname"].ToString(),
                        rd["telnum"].ToString()
                    );
                    comList.Add(company);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return comList;
        }
        public List<Material> selectPOPmaterial(int start, int end, string mclass)
        {
            string selectSql = "SELECT T2.mcode, T2.mclass, T2.mname, T2.unit, T2.standard ";
            string fromSql = "FROM (SELECT ROW_NUMBER() OVER(ORDER BY T1.mcode) AS ROW_NUM, T1.*FROM material_t T1 ";

            if (mclass != "")
            {
                fromSql += string.Format("where T1.mclass = '{0}') T2 ", mclass);
            }
            else
            {
                fromSql += ") T2 ";
            }

            string whereSql = string.Format("where T2.ROW_NUM BETWEEN {0} AND {1} ", start, end);

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Material> matList = new List<Material>();

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
                        rd["standard"].ToString()
                    );
                    matList.Add(material);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return matList;
        }
        public List<Operation> selectPOPoperation(int start, int end)
        {
            string selectSql = "SELECT T2.oprcode, T2.oprname, T2.oprdescription, T2.manhour ";
            string fromSql = "FROM (SELECT ROW_NUMBER() OVER(ORDER BY T1.oprcode) AS ROW_NUM, T1.*FROM operation_t T1) T2 ";
            string whereSql = string.Format("WHERE T2.ROW_NUM BETWEEN {0} AND {1}", start, end);
            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Operation> oprList = new List<Operation>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Operation operation = new Operation
                    (
                        rd["oprCode"].ToString(),
                        rd["oprName"].ToString(),
                        rd["oprDescription"].ToString(),
                        int.Parse(rd["ManHour"].ToString())
                    );
                    oprList.Add(operation);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return oprList;
        }
        public List<OutputReq> selectPOPrequest(int start, int end)
        {
            string selectSql = "select T1.reqcode, T1.workordercode, T1.mcode1, T1.제품명, T1.mcode2, T1.원자재명, T1.oprname, T1.amount, T1.reqdate, T1.reqstatus, T1.ecode  ";
            string fromSql = "from (select row_number() over(order by ot.reqcode) as row_num,  ";
            fromSql += "ot.reqcode, ot.workordercode, ot.mcode1, pm.mname as 제품명, ot.mcode2, cm.mname as 원자재명, oprt.oprname, ot.amount, ot.reqdate, ot.reqstatus, et.ecode ";
            fromSql += "from material_t pm, material_t cm, outputreq_t ot, operation_t oprt, worder_t wt, employee_t et ";
            string whereSql = "where ot.mcode1 = pm.mcode and ot.mcode2 = cm.mcode and ot.oprcode = oprt.oprcode and ot.ecode  = et.ecode and ot.workordercode = wt.workordercode) T1 ";
            whereSql += string.Format("WHERE T1.ROW_NUM BETWEEN {0} AND {1}", start, end);

            string sql = selectSql + fromSql + whereSql;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<OutputReq> reqList = new List<OutputReq>();
            Console.Write(rd.HasRows);

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    OutputReq req = new OutputReq
                     (
                         int.Parse(rd["reqcode"].ToString()),
                         int.Parse(rd["workordercode"].ToString()),
                         rd["mcode1"].ToString(),
                         rd["제품명"].ToString(),
                         rd["oprname"].ToString(),
                         rd["mcode2"].ToString(),
                         rd["원자재명"].ToString(),
                         int.Parse(rd["amount"].ToString()),
                         rd["reqdate"].ToString(),
                         int.Parse(rd["ecode"].ToString()),
                         rd["reqstatus"].ToString()
                     );
                    reqList.Add(req);
                }
            }
            else
            {
                Console.WriteLine("자재소요계획 관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();

            return reqList;
        }
    }
}
