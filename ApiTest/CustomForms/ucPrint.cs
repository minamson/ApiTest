using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ApiTest.CustomForms
{
    public partial class ucPrint : baseUserControl
    {
        private static ucPrint _instatance;

        public static ucPrint Instance
        {
            get
            {
                if (_instatance == null || _instatance.IsDisposed)
                {
                    _instatance = new ucPrint();
                }

                return _instatance;
            }
        }

        public ucPrint()
        {
            InitializeComponent();
        }
    }
}
