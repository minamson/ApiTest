using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entity;
using DataAccess.UnitOfWork;

namespace ApiTest
{
    public partial class frmMain : Form
    {
        public frmMain()
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


            var ctx = new OracleDbContext(ORACLE.OracleConnectString);
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

                //dataGridView1.DataSource = list;

                var list = uow.Repository<Schema>().FindAll().ToList();

                gridControlSchemInfo.DataSource = list;

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

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            string cn = ORACLE.OracleConnection("localhost", 1521, "COMPANYDB","MINAM", "thsalska");

            using (var ctx = new OracleDbContext(cn))
            {
                using (var uow = new UnitOfWork(ctx))
                {

                    //var list = ctx.Database.SqlQuery<Schema>(ORACLE.SchemInfo,
                    //    new OracleParameter("tname", textEditName.Text.ToUpper().Trim()),
                    //    new OracleParameter("cname", textEditName.Text.ToUpper().Trim())).ToList();

                    string name = textEditName.Text.ToUpper().Trim();

                    //var list = new List<Schema>();

                    //if (name.Length > 0)
                    //{
                    //    if (comboBoxEditQryOption.SelectedIndex == 0)
                    //        list = uow.Repository<Schema>().FindBy(p => p.TABLE_NAME.Contains(name)).ToList<Schema>();
                    //    else if (comboBoxEditQryOption.SelectedIndex == 1)
                    //        list = uow.Repository<Schema>().FindBy(p => p.COLUMN_NAME.Contains(name)).ToList<Schema>();
                    //    else if (comboBoxEditQryOption.SelectedIndex == 2)
                    //        list = uow.Repository<Schema>().FindBy(p => p.COMMENTS.Contains(name)).ToList<Schema>();
                    //}
                    //else
                    //    list = uow.Repository<Schema>().FindAll().ToList<Schema>();

                    //gridControlSchemInfo.DataSource = list.ToList<Schema>();

                    var query = uow.Repository<Schema>().GetQuery();

                    if (name.Length > 0)
                    {
                        if (comboBoxEditQryOption.SelectedIndex == 0)
                            query = uow.Repository<Schema>().FindBy(p => p.TABLE_NAME.Contains(name));
                        else if (comboBoxEditQryOption.SelectedIndex == 1)
                            query = uow.Repository<Schema>().FindBy(p => p.COLUMN_NAME.Contains(name));
                        else if (comboBoxEditQryOption.SelectedIndex == 2)
                            query = uow.Repository<Schema>().FindBy(p => p.COMMENTS.Contains(name));

                        //if (comboBoxEditQryOption.SelectedIndex == 0)
                        //    query.Where(p => p.TABLE_NAME.Contains(name));
                        //else if (comboBoxEditQryOption.SelectedIndex == 1)
                        //    query.Where(p => p.COLUMN_NAME.Contains(name));
                        //else if (comboBoxEditQryOption.SelectedIndex == 2)
                        //    query.Where(p => p.COMMENTS.Contains(name));
                    }

                    if (comboBoxEditSelection.SelectedIndex == 1)
                        query = query.Where(p => p.KIND == "TABLE");
                    else if (comboBoxEditSelection.SelectedIndex == 2)
                        query = query.Where(p => p.KIND == "VIEW");                    
                    
                    gridControlSchemInfo.DataSource = query.ToList<Schema>();
                }
            }

        }

        private void simpleButtonExcel_Click(object sender, EventArgs e)
        {
            if (gridViewSchemInfo.RowCount < 1) { return; }

            var filename = "SchemaInfo.xlsx";

            try
            {
                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {

                    saveFileDialog1.Title = "Excel File 저장...";
                    saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog1.OverwritePrompt = true;
                    saveFileDialog1.FileName = filename;
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                        return;

                    filename = saveFileDialog1.FileName;
                }

                gridControlSchemInfo.ExportToXlsx(filename);
                Process.Start(filename);//엑셀실행...
            }
            catch (Exception ex)
            {
                MessageBox.Show(" error " + ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Util.CenterScreen(this);
        }

        private void comboBoxEditQryOption_EditValueChanged(object sender, EventArgs e)
        {
            if(comboBoxEditQryOption.Text.Trim().Length == 0)
            {
                comboBoxEditQryOption.Text = "0.테이블이름";
            }

        }

        private void comboBoxEditSelection_EditValueChanged(object sender, EventArgs e)
        {
            if (comboBoxEditSelection.Text.Trim().Length == 0)
            {
                comboBoxEditSelection.Text = "0.All";
            }
        }
    }
}
