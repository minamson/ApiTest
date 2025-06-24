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

        private void accordionControlElementEmp_Click(object sender, EventArgs e)
        {
            if (!fluentAdmContainer.Controls.Contains(CustomForms.ucEmp.Instance))
            {
                fluentAdmContainer.Controls.Add(CustomForms.ucEmp.Instance);
                CustomForms.ucEmp.Instance.Dock = DockStyle.Fill;
                CustomForms.ucEmp.Instance.BringToFront();
            }

            CustomForms.ucEmp.Instance.BringToFront();
        }

        private void accordionControlElementFuelPrice_Click(object sender, EventArgs e)
        {
            if (!fluentAdmContainer.Controls.Contains(CustomForms.ucFuelPrice.Instance))
            {
                fluentAdmContainer.Controls.Add(CustomForms.ucFuelPrice.Instance);
                CustomForms.ucFuelPrice.Instance.Dock = DockStyle.Fill;
                CustomForms.ucFuelPrice.Instance.BringToFront();
            }

            CustomForms.ucFuelPrice.Instance.BringToFront();
        }

        private void accordionControlElementReport_Click(object sender, EventArgs e)
        {
            if (!fluentAdmContainer.Controls.Contains(CustomForms.ucPrint.Instance))
            {
                fluentAdmContainer.Controls.Add(CustomForms.ucPrint.Instance);
                CustomForms.ucPrint.Instance.Dock = DockStyle.Fill;
                CustomForms.ucPrint.Instance.BringToFront();
            }

            CustomForms.ucPrint.Instance.BringToFront();
        }
    }
}
