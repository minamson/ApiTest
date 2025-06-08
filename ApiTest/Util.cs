using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiTest
{
    internal class Util
    {
        /// <summary>
        /// 화면중앙으로
        /// </summary>
        /// <param name="form">Form</param>
        public static void CenterScreen(Form form)
        {
            form.Location = new System.Drawing.Point(
            (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2),
            (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }


        public static void OpenChidView(Form parentForm, Form childForm)
        {
            childForm.Parent = parentForm;
            childForm.Show();
        }

        //public void IsChildFormActivated(DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer)
        //{
        //    if (!mainContainer.Controls.Contains(CustomForms.ucSchemInfo.Instance))
        //    {
        //        mainContainer.Controls.Add(CustomForms.ucSchemInfo.Instance);
        //        CustomForms.ucSchemInfo.Instance.Dock = DockStyle.Fill;
        //        CustomForms.ucSchemInfo.Instance.BringToFront();
        //    }

        //    CustomForms.ucSchemInfo.Instance.BringToFront();
        //}
    }
}
