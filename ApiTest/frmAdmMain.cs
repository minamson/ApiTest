using System;
using System.Windows.Forms;
using ApiTest.CustomForms;

namespace ApiTest
{
    public partial class frmAdmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmAdmMain()
        {
            InitializeComponent();
        }

        private void frmAdmMain_Load(object sender, EventArgs e)
        {
            //Util.CenterScreen(this);
        }

        private void accdMenuTableList_Click(object sender, EventArgs e)
        {
            if (!fluentAdmContainer.Controls.Contains(CustomForms.ucSchemInfo.Instance))
            {
                fluentAdmContainer.Controls.Add(CustomForms.ucSchemInfo.Instance);
                CustomForms.ucSchemInfo.Instance.Dock = DockStyle.Fill;
                CustomForms.ucSchemInfo.Instance.BringToFront();
            }

            CustomForms.ucSchemInfo.Instance.BringToFront();
        }

         

        private void accdMenuDept_Click(object sender, EventArgs e)
        {
            if (!fluentAdmContainer.Controls.Contains(CustomForms.ucDept.Instance))
            {
                fluentAdmContainer.Controls.Add(CustomForms.ucDept.Instance);
                CustomForms.ucDept.Instance.Dock = DockStyle.Fill;
                CustomForms.ucDept.Instance.BringToFront();
            }

            CustomForms.ucDept.Instance.BringToFront();
        }
    }
}
