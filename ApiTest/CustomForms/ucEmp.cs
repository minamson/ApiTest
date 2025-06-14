using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entity;
using DataAccess.UnitOfWork;
using DevExpress.XtraEditors;

namespace ApiTest.CustomForms
{
    public partial class ucEmp : baseUserControl
    {
        private static ucEmp _instatance;

        public static ucEmp Instance
        {
            get
            {
                if (_instatance == null || _instatance.IsDisposed)
                {
                    _instatance = new ucEmp();
                }

                return _instatance;
            }
        }

        public ucEmp()
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
                        gridControlEmp.DataSource = uow.Repository<Emp>().FindAll().ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally
            {
                splmWait.CloseWaitForm();
            }
        }
    }
}
