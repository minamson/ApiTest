namespace ApiTest.CustomForms
{
    partial class ucDept
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDept));
            this.gridControlDept = new DevExpress.XtraGrid.GridControl();
            this.gridViewDept = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDeptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonExcel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRetrieve = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEditSelection = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDept
            // 
            this.gridControlDept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDept.Location = new System.Drawing.Point(3, 109);
            this.gridControlDept.MainView = this.gridViewDept;
            this.gridControlDept.Name = "gridControlDept";
            this.gridControlDept.Size = new System.Drawing.Size(1345, 500);
            this.gridControlDept.TabIndex = 1;
            this.gridControlDept.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDept});
            // 
            // gridViewDept
            // 
            this.gridViewDept.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDeptNo,
            this.gridColumnDeptName,
            this.gridColumnRemark});
            this.gridViewDept.GridControl = this.gridControlDept;
            this.gridViewDept.Name = "gridViewDept";
            this.gridViewDept.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewDept_RowUpdated);
            // 
            // gridColumnDeptNo
            // 
            this.gridColumnDeptNo.Caption = "DeptNo";
            this.gridColumnDeptNo.FieldName = "DeptNo";
            this.gridColumnDeptNo.Name = "gridColumnDeptNo";
            this.gridColumnDeptNo.Visible = true;
            this.gridColumnDeptNo.VisibleIndex = 0;
            // 
            // gridColumnDeptName
            // 
            this.gridColumnDeptName.Caption = "DeptName";
            this.gridColumnDeptName.FieldName = "DeptName";
            this.gridColumnDeptName.Name = "gridColumnDeptName";
            this.gridColumnDeptName.Visible = true;
            this.gridColumnDeptName.VisibleIndex = 1;
            // 
            // gridColumnRemark
            // 
            this.gridColumnRemark.Caption = "Remark";
            this.gridColumnRemark.FieldName = "Remark";
            this.gridColumnRemark.Name = "gridColumnRemark";
            this.gridColumnRemark.Visible = true;
            this.gridColumnRemark.VisibleIndex = 2;
            // 
            // simpleButtonExcel
            // 
            this.simpleButtonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonExcel.ImageOptions.Image")));
            this.simpleButtonExcel.Location = new System.Drawing.Point(1110, 33);
            this.simpleButtonExcel.Name = "simpleButtonExcel";
            this.simpleButtonExcel.Size = new System.Drawing.Size(127, 36);
            this.simpleButtonExcel.TabIndex = 11;
            this.simpleButtonExcel.Text = "Export Excel";
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRetrieve.Location = new System.Drawing.Point(955, 33);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(149, 36);
            this.buttonRetrieve.TabIndex = 12;
            this.buttonRetrieve.Text = "Retrieve";
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxEditSelection);
            this.groupControl1.Controls.Add(this.textEditName);
            this.groupControl1.Controls.Add(this.simpleButtonExcel);
            this.groupControl1.Controls.Add(this.buttonRetrieve);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1351, 79);
            this.groupControl1.TabIndex = 14;
            // 
            // comboBoxEditSelection
            // 
            this.comboBoxEditSelection.EditValue = "0.All";
            this.comboBoxEditSelection.Location = new System.Drawing.Point(105, 38);
            this.comboBoxEditSelection.Name = "comboBoxEditSelection";
            this.comboBoxEditSelection.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.comboBoxEditSelection.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditSelection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSelection.Properties.Items.AddRange(new object[] {
            "0.All",
            "1. Dept Name"});
            this.comboBoxEditSelection.Size = new System.Drawing.Size(139, 24);
            this.comboBoxEditSelection.TabIndex = 13;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(250, 38);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Size = new System.Drawing.Size(151, 24);
            this.textEditName.TabIndex = 9;
            // 
            // ucDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlDept);
            this.Name = "ucDept";
            this.Size = new System.Drawing.Size(1351, 626);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlDept;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExcel;
        private DevExpress.XtraEditors.SimpleButton buttonRetrieve;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSelection;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDept;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDeptNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRemark;
    }
}
