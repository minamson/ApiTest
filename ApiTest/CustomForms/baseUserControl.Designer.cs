namespace ApiTest.CustomForms
{
    partial class baseUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splmWait = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ApiTest.CustomForms.WaitForm1), true, true, typeof(System.Windows.Forms.UserControl));
            this.SuspendLayout();
            // 
            // splmWait
            // 
            this.splmWait.ClosingDelay = 500;
            // 
            // baseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "baseUserControl";
            this.Size = new System.Drawing.Size(596, 420);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraSplashScreen.SplashScreenManager splmWait;
    }
}
