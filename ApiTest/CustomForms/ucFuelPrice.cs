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
using DevExpress.Data.ChartDataSources;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPivotGrid;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ApiTest.CustomForms
{
    public partial class ucFuelPrice : baseUserControl
    {
        private static ucFuelPrice _instatance;

        public static ucFuelPrice Instance
        {
            get
            {
                if (_instatance == null || _instatance.IsDisposed)
                {
                    _instatance = new ucFuelPrice();
                }

                return _instatance;
            }
        }

        public ucFuelPrice()
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
                    var list = ctx.Database.SqlQuery<FuelPrice>(ORACLE.FuelPrice).ToList();
                    pivotGridControlPivot.DataSource = list.ToList();
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

        private void ucFuelPrice_Load(object sender, EventArgs e)
        {
            //pivotGridControlPivot.RepositoryItems.Add( riTextEdit);

        }

        private void pivotGridControlPivot_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            MessageBox.Show(e.DataField.ToString(), "e.DataField");
            MessageBox.Show(e.ColumnField.Name, "e.ColumnField");
            MessageBox.Show(e.ColumnFieldIndex.ToString(), "e.ColumnFieldIndex");
            MessageBox.Show(e.Editor.EditValue.ToString(), "Editor.EditValue");
        }

        private void pivotGridControlPivot_CellSelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
