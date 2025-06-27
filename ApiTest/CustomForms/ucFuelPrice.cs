using System;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entity;
using DataAccess.UnitOfWork;
using DevExpress.XtraPivotGrid;

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
            MessageBox.Show(e.Value.ToString(),"col value");

            MessageBox.Show(e.ColumnFieldIndex.ToString(), "e.ColumnFieldIndex");
            MessageBox.Show(e.Editor.EditValue.ToString(), "Editor.EditValue");
            //SavePrice();

        }

        private void SavePrice(int day, int price)
        {
            using (var ctx = new OracleDbContext(ORACLE.OracleConnectString))
            {
                using (var uow = new UnitOfWork(ctx))
                {
                    var fuelPrice = uow.Repository<FuelPrice>().FindBy(p => p.Day == day).FirstOrDefault();
                    fuelPrice.Price = price;
                    uow.Repository<FuelPrice>().Update(fuelPrice);
                    uow.Commit();
                    
                    pivotGridControlPivot.DataSource = uow.Repository<Dept>().FindAll().ToList();
                }
            }

            pivotGridControlPivot.RefreshDataAsync();
        }


        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }


        private void pivotGridControlPivot_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pivotGridControlPivot_MouseDown(object sender, MouseEventArgs e)
        {
            PivotGridHitInfo hi = pivotGridControlPivot.CalcHitInfo(e.Location);

            if (hi.HitTest == PivotGridHitTest.Cell)
            {
                // Assuming you have row and column fields named 'rowField' and 'columnField'
                var rowValue = hi.CellInfo.GetFieldValue(pivotGridFieldDayCode);
                var columnValue = hi.CellInfo.GetFieldValue(pivotGridFieldDays);
                var dataValue = hi.CellInfo.GetFieldValue(pivotGridFieldPrice);
                MessageBox.Show(rowValue.ToString());
                MessageBox.Show(columnValue.ToString());
                MessageBox.Show(dataValue.ToString());

                // Do something with the values
                Console.WriteLine($"Row Value: {rowValue}, Column Value: {columnValue}, Price Value: {dataValue}");
            }
        }
    }
}
