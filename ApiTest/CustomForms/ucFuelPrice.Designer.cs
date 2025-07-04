﻿namespace ApiTest.CustomForms
{
    partial class ucFuelPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFuelPrice));
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditSelection = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonExcel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRetrieve = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControlPivot = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridFieldDayCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldDays = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlPivot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
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
            this.groupControl1.Size = new System.Drawing.Size(1066, 79);
            this.groupControl1.TabIndex = 15;
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonClose.Location = new System.Drawing.Point(958, 33);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(93, 36);
            this.simpleButtonClose.TabIndex = 15;
            this.simpleButtonClose.Text = "Close";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButtonClose_Click);
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
            this.simpleButtonExcel.Location = new System.Drawing.Point(825, 33);
            this.simpleButtonExcel.Name = "simpleButtonExcel";
            this.simpleButtonExcel.Size = new System.Drawing.Size(127, 36);
            this.simpleButtonExcel.TabIndex = 11;
            this.simpleButtonExcel.Text = "Export Excel";
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRetrieve.Location = new System.Drawing.Point(670, 33);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(149, 36);
            this.buttonRetrieve.TabIndex = 12;
            this.buttonRetrieve.Text = "Retrieve";
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // pivotGridControlPivot
            // 
            this.pivotGridControlPivot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControlPivot.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridFieldDayCode,
            this.pivotGridFieldDays,
            this.pivotGridFieldPrice});
            this.pivotGridControlPivot.Location = new System.Drawing.Point(0, 79);
            this.pivotGridControlPivot.Name = "pivotGridControlPivot";
            this.pivotGridControlPivot.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControlPivot.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.pivotGridControlPivot.Size = new System.Drawing.Size(1066, 543);
            this.pivotGridControlPivot.TabIndex = 16;
            this.pivotGridControlPivot.EditValueChanged += new DevExpress.XtraPivotGrid.EditValueChangedEventHandler(this.pivotGridControlPivot_EditValueChanged);
            this.pivotGridControlPivot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pivotGridControlPivot_MouseDown);
            // 
            // pivotGridFieldDayCode
            // 
            this.pivotGridFieldDayCode.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldDayCode.AreaIndex = 0;
            this.pivotGridFieldDayCode.Caption = "Day Code";
            dataSourceColumnBinding1.ColumnName = "Day";
            this.pivotGridFieldDayCode.DataBinding = dataSourceColumnBinding1;
            this.pivotGridFieldDayCode.MinWidth = 50;
            this.pivotGridFieldDayCode.Name = "pivotGridFieldDayCode";
            this.pivotGridFieldDayCode.Width = 150;
            // 
            // pivotGridFieldDays
            // 
            this.pivotGridFieldDays.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridFieldDays.AreaIndex = 0;
            this.pivotGridFieldDays.Caption = "Days";
            dataSourceColumnBinding2.ColumnName = "Days";
            this.pivotGridFieldDays.DataBinding = dataSourceColumnBinding2;
            this.pivotGridFieldDays.Name = "pivotGridFieldDays";
            // 
            // pivotGridFieldPrice
            // 
            this.pivotGridFieldPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridFieldPrice.AreaIndex = 0;
            this.pivotGridFieldPrice.Caption = "Price";
            dataSourceColumnBinding3.ColumnName = "Price";
            this.pivotGridFieldPrice.DataBinding = dataSourceColumnBinding3;
            this.pivotGridFieldPrice.FieldEdit = this.repositoryItemTextEdit1;
            this.pivotGridFieldPrice.Name = "pivotGridFieldPrice";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ucFuelPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControlPivot);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucFuelPrice";
            this.Size = new System.Drawing.Size(1066, 622);
            this.Load += new System.EventHandler(this.ucFuelPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlPivot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSelection;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExcel;
        private DevExpress.XtraEditors.SimpleButton buttonRetrieve;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlPivot;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldDayCode;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldDays;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
