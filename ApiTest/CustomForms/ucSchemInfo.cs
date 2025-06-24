using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entity;
using DataAccess.UnitOfWork;


namespace ApiTest.CustomForms
{
    public partial class ucSchemInfo : baseUserControl
    {
        private static ucSchemInfo _instatance;

        public static ucSchemInfo Instance
        {
            get
            {
                if (_instatance == null || _instatance.IsDisposed)
                {
                    _instatance = new ucSchemInfo();
                }
                _instatance.Visible = true;
                return _instatance;
            }
        }

        public ucSchemInfo()
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
                        //var sp1 = new Specification<Schema>(p => p.TABLE_NAME.StartsWith(textEditName.Text.Trim()));
                        //var sp2 = new Specification<Schema>(p => p.COLUMN_NAME.StartsWith(textEditName.Text.Trim()));
                        //var sp3 = new Specification<Schema>(p => p.COMMENTS.StartsWith(textEditName.Text.Trim()));

                        //var list = uow.Repository<Schema>().FindBy(
                        //            sp1.
                        //                And(sp2).
                        //                    Or(sp3));

                        //gridControlSchemInfo.DataSource = list.ToList();

                        string name = textEditName.Text.ToUpper().Trim();
                        var query = uow.Repository<Schema>().GetQuery();

                        if (name.Length > 0)
                        {
                            if (comboBoxEditQryOption.SelectedIndex == 0)
                                query = uow.Repository<Schema>().FindBy(p => p.TABLE_NAME.Contains(name));
                            else if (comboBoxEditQryOption.SelectedIndex == 1)
                                query = uow.Repository<Schema>().FindBy(p => p.COLUMN_NAME.Contains(name));
                            else if (comboBoxEditQryOption.SelectedIndex == 2)
                                query = uow.Repository<Schema>().FindBy(p => p.COMMENTS.Contains(name));
                        }

                        if (comboBoxEditSelection.SelectedIndex == 1)
                             query.Where(p => p.KIND == "TABLE");
                        else if (comboBoxEditSelection.SelectedIndex == 2)
                             query.Where(p => p.KIND == "VIEW");

                        //if (comboBoxEditBizModule.Text.Length != 0)
                        //    query = query.Where(p => p.TABLE_NAME.StartsWith(comboBoxEditBizModule.Text.Trim()));

                        gridControlSchemInfo.DataSource = query.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" error " + ex.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                splmWait.CloseWaitForm();
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


        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

    }
}
