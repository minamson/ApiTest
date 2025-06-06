using System;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entity;
using DataAccess.Service;
using DataAccess.UnitOfWork;
using Oracle.ManagedDataAccess.Client;

namespace ApiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (OracleDbContext context = new OracleDbContext())
            //{
            //    using (var uow = new UnitOfWork(context))
            //    {
            //        var empRepo = new Repository<Emp>(context);
            //        empRepo.FindAll();
            //    }
            //}

            //    Specification<Parent> specification = new Specification<Parent>(p => p.ParentName.StartsWith("P"));
            //    Specification<Parent> specification2 = new Specification<Parent>(p => p.Age >= 0);
            //    Specification<Parent> specification3 = new Specification<Parent>(p => !(p.Age >= 0));

            //var cn = new ConnectString("localhost", 1521, "testdb", "minamsno", "thsalska");
            //var cc = cn.OracleConnectString;
            string cn = @"Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = COMPANYDB))); User ID=MINAM; Password=thsalska;";

            var ctx = new OracleDbContext(ConnectString.OracleConnectString);
            //var list = ctx.Depts;

            //dataGridView1.DataSource = list.ToList();

            //foreach(var l in list)
            //{
            //    Console.WriteLine(l.DeptName);
            //}

            using (var uow = new UnitOfWork(ctx))
            {
                //var li = uow.Repository<Dept>().FindBy(p => p.DeptName.StartsWith("t")).Where( pp => pp.DeptNo == 2).Select(ppp => ppp.DeptNo);


                //dataGridView1.DataSource = li.ToList();

                //var list = uow.Repository<Parent>().GetPage(p => p.Age >= 0, 2, 4, SortEnum.Ascending);
                //parentBindingSource.DataSource = l.ToList();

                //var list = ctx.Database.SqlQuery<Dept>("select dept_no as DeptNo, dept_name as DeptName, remark as Remark from dept where dept_no = :p1", new OracleParameter("p1", 1)).ToList();
                //var list = ctx.Database.SqlQuery<Dept>(@"select dept_no as DeptNo, dept_name as DeptName, remark as Remark from dept where dept_name like '%'|| :p1 ||'%' ", new OracleParameter("p1", "t")).ToList();


                string schema_sql = @" -- CREATE VIEW SCHEM_INFO AS
    SELECT  
         ROW_NUMBER() OVER(ORDER BY AA.TABLE_NAME, AA.COLUMN_ID) AS ID,     
          
         AA.TABLE_NAME        AS TABLE_NAME,
         AA.COLUMN_ID         AS COLUMN_ID,
         AA.COLUMN_NAME       AS COLUMN_NAME,
         BB.COMMENTS          AS COMMENTS,
         AA.DATA_TYPE || 
        (case when AA.data_type like '%CHAR%' then '(' || AA.data_length || ')'
              when AA.data_type = 'NUMBER' AND AA.data_precision > 0 AND AA.data_scale > 0
                then '(' || AA.data_precision || ',' || AA.data_scale || ')'
              when AA.data_type = 'NUMBER' AND AA.data_precision > 0 
                then '(' || AA.data_precision ||')'
        end )                 AS DATA_TYPE,       -- 자릿수 표현한 데이터 유형
        
        -- AA.DATA_LENGTH       AS DATA_LENGTH,
        -- AA.NULLABLE          AS NULLABLE,
         decode(aA.nullable, 'Y', 'NULL', 'NOT NULL') AS ISNULL,-- NULL 여부
         AA.DATA_DEFAULT      AS DATA_DEFAULT,
         CC.PK                AS PK,
         CC.FK                AS FK,
         CC.UK                AS UQ
         
    FROM ALL_TAB_COLUMNS AA,
         ALL_COL_COMMENTS BB,
         (SELECT A.OWNER,
                 A.TABLE_NAME,
                 A.CONSTRAINT_TYPE,
                 COLUMN_NAME,
                 POSITION,
                 CASE WHEN A.CONSTRAINT_TYPE = 'P' THEN 'Y' END AS PK,
                 CASE WHEN A.CONSTRAINT_TYPE = 'R' THEN 'Y' END AS FK,
                 CASE WHEN A.CONSTRAINT_TYPE = 'U' THEN 'Y' END AS UK
            FROM ALL_CONSTRAINTS A, ALL_CONS_COLUMNS B
           WHERE   A.OWNER = b.OWNER
                 AND A.TABLE_NAME = B.TABLE_NAME
                  AND A.CONSTRAINT_NAME = B.CONSTRAINT_NAME
                 AND A.CONSTRAINT_TYPE IN ('P', 'R','U')) CC
   WHERE 
         AA.OWNER like 'MINAM'
         AND AA.TABLE_NAME LIKE '%'
         AND AA.OWNER = BB.OWNER
         AND AA.TABLE_NAME = BB.TABLE_NAME
         AND AA.COLUMN_NAME = BB.COLUMN_NAME
         AND AA.OWNER = CC.OWNER(+)
         AND AA.TABLE_NAME = CC.TABLE_NAME(+)
         AND AA.COLUMN_NAME = CC.COLUMN_NAME(+)
         AND AA.TABLE_NAME != 'SCHEM_INFO'
         
ORDER BY TABLE_NAME, COLUMN_ID, COLUMN_NAME
 ";

                //dataGridView1.DataSource = list;


                //var list = ctx.Database.SqlQuery<Schema>(schema_sql).ToList<Schema>();

                var list = uow.Repository<Schema>().FindAll().ToList();

                dataGridView1.DataSource = list;

            }




            //ctx.Dispose();

            //OracleConnection conn;
            //OracleCommand cmd;

            //conn = new OracleConnection(cn);
            //cmd = new OracleCommand();
            //conn.Open();
            //cmd.Connection = conn;

            //DataSet ds = new DataSet();
            //string SQL = "SELECT * FROM dept";
            //OracleDataAdapter ad = new OracleDataAdapter();
            //ad.SelectCommand = new OracleCommand(SQL, conn);
            //ad.Fill(ds, "dept");

            //dataGridView1.DataSource = ds.Tables[0];
            //conn.Close();

        }
    }
}
