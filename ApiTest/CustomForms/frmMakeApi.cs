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
    public partial class frmMakeApi : DevExpress.XtraEditors.XtraForm
    {
        IList<string> items;

        public frmMakeApi(IList<string> items)
        {
            InitializeComponent();
            this.items = items;
        }


    }
}