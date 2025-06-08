using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars;

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
            Util.CenterScreen(this);
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            if (!fluentAdmContainer.Controls.Contains(CustomForms.ucSchemInfo.Instance))
            {
                fluentAdmContainer.Controls.Add(CustomForms.ucSchemInfo.Instance);
                CustomForms.ucSchemInfo.Instance.Dock = DockStyle.Fill;
                CustomForms.ucSchemInfo.Instance.BringToFront();
            }

            CustomForms.ucSchemInfo.Instance.BringToFront();
        }
    }
}
