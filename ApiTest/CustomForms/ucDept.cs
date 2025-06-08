using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entity;
using DataAccess.UnitOfWork;

namespace ApiTest.CustomForms
{
    public partial class ucDept : baseUserControl
    {
        private static ucDept _instatance;

        public static ucDept Instance
        {
            get
            {
                if( _instatance == null)
                {
                    _instatance = new ucDept();
                }

                return _instatance;
            }
        }

        public ucDept()
        {
            InitializeComponent();
        }



        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                splmWait.ShowWaitForm();
                using (var ctx = new OracleDbContext(ORACLE.OracleConnectString))
                {
                    using (var uow = new UnitOfWork(ctx))
                    {

                        string name = textEditName.Text.Trim();
                        var query = uow.Repository<Dept>().GetQuery();

                        if (comboBoxEditSelection.SelectedIndex == 1)
                        {
                            gridControlDept.DataSource = uow.Repository<Dept>().FindBy(p => p.DeptName.Contains(name)).ToList();
                        }
                        else
                            gridControlDept.DataSource = uow.Repository<Dept>().FindAll().ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
            finally
            {
                splmWait.CloseWaitForm();
            }

        }

        private void gridViewDept_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Dept p = (Dept)gridViewDept.GetRow(e.RowHandle);

            try
            {
                splmWait.ShowWaitForm();
                using (var ctx = new OracleDbContext(ORACLE.OracleConnectString))
                {
                    using (var uow = new UnitOfWork(ctx))
                    {
                        uow.Repository<Dept>().Update(p);
                        uow.Commit();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
            }
            finally
            {
                splmWait.CloseWaitForm();
            }
        }
    }
}
