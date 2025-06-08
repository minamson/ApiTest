namespace ApiTest
{
    partial class frmAdmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmMain));
            this.fluentAdmContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementDB = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accdMenuTableList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accdMenuDept = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barButtonClose = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barButtonItemClose = new DevExpress.XtraBars.BarButtonItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentAdmContainer
            // 
            this.fluentAdmContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentAdmContainer.Location = new System.Drawing.Point(228, 31);
            this.fluentAdmContainer.Name = "fluentAdmContainer";
            this.fluentAdmContainer.Size = new System.Drawing.Size(644, 585);
            this.fluentAdmContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementDB});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(228, 585);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementDB
            // 
            this.accordionControlElementDB.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accdMenuTableList,
            this.accdMenuDept,
            this.accordionControlElement7});
            this.accordionControlElementDB.Expanded = true;
            this.accordionControlElementDB.Name = "accordionControlElementDB";
            this.accordionControlElementDB.Text = "Database Schema";
            // 
            // accdMenuTableList
            // 
            this.accdMenuTableList.Name = "accdMenuTableList";
            this.accdMenuTableList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accdMenuTableList.Text = "Table List";
            this.accdMenuTableList.Click += new System.EventHandler(this.accdMenuTableList_Click);
            // 
            // accdMenuDept
            // 
            this.accdMenuDept.Name = "accdMenuDept";
            this.accdMenuDept.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accdMenuDept.Text = "Dept CRUD";
            this.accdMenuDept.Click += new System.EventHandler(this.accdMenuDept_Click);
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Element7";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barMdiChildrenListItem1,
            this.barButtonClose,
            this.barMdiChildrenListItem2,
            this.barButtonItemClose});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(872, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barButtonItemClose);
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 0;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barButtonClose
            // 
            this.barButtonClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonClose.Caption = "Close";
            this.barButtonClose.Id = 1;
            this.barButtonClose.Name = "barButtonClose";
            // 
            // barMdiChildrenListItem2
            // 
            this.barMdiChildrenListItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barMdiChildrenListItem2.Caption = "barMdiChildrenListItem2";
            this.barMdiChildrenListItem2.Id = 2;
            this.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
            // 
            // barButtonItemClose
            // 
            this.barButtonItemClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemClose.Caption = "barButtonItem1";
            this.barButtonItemClose.Id = 3;
            this.barButtonItemClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemClose.ImageOptions.Image")));
            this.barButtonItemClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemClose.ImageOptions.LargeImage")));
            this.barButtonItemClose.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.barButtonItemClose.Name = "barButtonItemClose";
            this.barButtonItemClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClose_ItemClick);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barMdiChildrenListItem1,
            this.barButtonClose,
            this.barMdiChildrenListItem2,
            this.barButtonItemClose});
            this.fluentFormDefaultManager1.MaxItemId = 4;
            // 
            // frmAdmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 616);
            this.ControlContainer = this.fluentAdmContainer;
            this.Controls.Add(this.fluentAdmContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmAdmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmMain";
            this.Load += new System.EventHandler(this.frmAdmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentAdmContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementDB;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accdMenuTableList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accdMenuDept;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarDockingMenuItem barButtonClose;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClose;
    }
}