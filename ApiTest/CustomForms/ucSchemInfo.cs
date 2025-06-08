using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using DataAccess.UnitOfWork;
using DataAccess.Entity;


namespace ApiTest.CustomForms
{
    public partial class ucSchemInfo : baseUserControl
    {
        private static ucSchemInfo _instatance;

        public static ucSchemInfo Instance
        {
            get
            {
                if (_instatance == null)
                {
                    _instatance = new ucSchemInfo();
                }

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
                            query = query.Where(p => p.KIND == "TABLE");
                        else if (comboBoxEditSelection.SelectedIndex == 2)
                            query = query.Where(p => p.KIND == "VIEW");

                        gridControlSchemInfo.DataSource = query.ToList<Schema>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
            
        }
    }
}
