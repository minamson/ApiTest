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

namespace ApiTest
{
    public partial class ucDept : DevExpress.XtraEditors.XtraUserControl
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

        private void simpleButtonRetrieve_Click(object sender, EventArgs e)
        {
            using (var ctx = new OracleDbContext(ORACLE.OracleConnectString))
            {
                using (var uow = new UnitOfWork(ctx))
                {
                    var list = uow.Repository<Dept>().FindAll();

                    gridControlDept.DataSource = list.ToList();
                }
            }
        }
    }
}
