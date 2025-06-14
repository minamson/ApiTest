namespace ApiTest.CustomForms
{
    partial class ucEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEmp));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditSelection = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonExcel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRetrieve = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlEmp = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnEmpNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDeptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButtonClose);
            this.groupControl1.Controls.Add(this.comboBoxEditSelection);
            this.groupControl1.Controls.Add(this.textEditName);
            this.groupControl1.Controls.Add(this.simpleButtonExcel);
            this.groupControl1.Controls.Add(this.buttonRetrieve);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1065, 79);
            this.groupControl1.TabIndex = 15;
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonClose.Location = new System.Drawing.Point(957, 33);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(93, 36);
            this.simpleButtonClose.TabIndex = 15;
            this.simpleButtonClose.Text = "Close";
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
            // simpleButtonExcel
            // 
            this.simpleButtonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonExcel.ImageOptions.Image")));
            this.simpleButtonExcel.Location = new System.Drawing.Point(824, 33);
            this.simpleButtonExcel.Name = "simpleButtonExcel";
            this.simpleButtonExcel.Size = new System.Drawing.Size(127, 36);
            this.simpleButtonExcel.TabIndex = 11;
            this.simpleButtonExcel.Text = "Export Excel";
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRetrieve.Location = new System.Drawing.Point(669, 33);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(149, 36);
            this.buttonRetrieve.TabIndex = 12;
            this.buttonRetrieve.Text = "Retrieve";
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // gridControlEmp
            // 
            this.gridControlEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmp.Location = new System.Drawing.Point(0, 79);
            this.gridControlEmp.MainView = this.gridViewEmp;
            this.gridControlEmp.Name = "gridControlEmp";
            this.gridControlEmp.Size = new System.Drawing.Size(1065, 487);
            this.gridControlEmp.TabIndex = 16;
            this.gridControlEmp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmp});
            // 
            // gridViewEmp
            // 
            this.gridViewEmp.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewEmp.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridViewEmp.AppearancePrint.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridViewEmp.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gridViewEmp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnEmpNo,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumnDeptNo});
            this.gridViewEmp.GridControl = this.gridControlEmp;
            this.gridViewEmp.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EmoNO", this.gridColumnEmpNo, "")});
            this.gridViewEmp.Name = "gridViewEmp";
            this.gridViewEmp.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewEmp.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // gridColumnEmpNo
            // 
            this.gridColumnEmpNo.Caption = "NO";
            this.gridColumnEmpNo.FieldName = "EmpNo";
            this.gridColumnEmpNo.Name = "gridColumnEmpNo";
            this.gridColumnEmpNo.Visible = true;
            this.gridColumnEmpNo.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumnColName";
            this.gridColumn2.FieldName = "EmpName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumnRemark";
            this.gridColumn3.FieldName = "Remark";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumnDeptNo
            // 
            this.gridColumnDeptNo.Caption = "DeptNo";
            this.gridColumnDeptNo.FieldName = "DeptNo";
            this.gridColumnDeptNo.Name = "gridColumnDeptNo";
            this.gridColumnDeptNo.Visible = true;
            this.gridColumnDeptNo.VisibleIndex = 2;
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataSource = typeof(DataAccess.Entity.Emp);
            // 
            // ucEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlEmp);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucEmp";
            this.Size = new System.Drawing.Size(1065, 566);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSelection;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExcel;
        private DevExpress.XtraEditors.SimpleButton buttonRetrieve;
        private DevExpress.XtraGrid.GridControl gridControlEmp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmp;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmpNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingSource empBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDeptNo;
    }
}
