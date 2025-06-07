using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ApiTest
{
    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FluentDesignForm1()
        {
            InitializeComponent();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(ucDept.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(ucDept.Instance);
                ucDept.Instance.Dock = DockStyle.Fill;
                ucDept.Instance.BringToFront();
            }
            ucDept.Instance.BringToFront();

        }
    }
}
