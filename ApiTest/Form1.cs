using System;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entity;
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

            var ctx = new OracleDbContext(cn);
            //var list = ctx.Depts;

            //dataGridView1.DataSource = list.ToList();

            //foreach(var l in list)
            //{
            //    Console.WriteLine(l.DeptName);
            //}

            using (var uow = new UnitOfWork(ctx))
            {
                var li = uow.Repository<Dept>().FindBy(p => p.DeptName.EndsWith("2"));

                dataGridView1.DataSource = li.ToList();

                //var list = uow.Repository<Parent>().GetPage(p => p.Age >= 0, 2, 4, SortEnum.Ascending);
                //parentBindingSource.DataSource = l.ToList();

                //var list = ctx.Database.SqlQuery<Dept>("select dept_no as DeptNo, dept_name as DeptName, remark as Remark from dept where dept_no = :p1", new OracleParameter("p1", 1)).ToList();
                //var list = ctx.Database.SqlQuery<Dept>(@"select dept_no as DeptNo, dept_name as DeptName, remark as Remark from dept where dept_name like '%'|| :p1 ||'%' ", new OracleParameter("p1", "t")).ToList();

                //dataGridView1.DataSource = list;

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
