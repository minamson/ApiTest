namespace ApiTest.CustomForms
{
    partial class ucSchemInfo
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
            this.simpleButtonExcel = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditSelection = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditQryOption = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.gridViewSchemInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnKind = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColomnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDataDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIsNull = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlSchemInfo = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditQryOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchemInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchemInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButtonExcel
            // 
            this.simpleButtonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButtonExcel.Appearance.Options.UseFont = true;
            this.simpleButtonExcel.Location = new System.Drawing.Point(1321, 37);
            this.simpleButtonExcel.Name = "simpleButtonExcel";
            this.simpleButtonExcel.Size = new System.Drawing.Size(175, 28);
            this.simpleButtonExcel.TabIndex = 12;
            this.simpleButtonExcel.Text = "Excel";
            this.simpleButtonExcel.Click += new System.EventHandler(this.simpleButtonExcel_Click);
            // 
            // comboBoxEditSelection
            // 
            this.comboBoxEditSelection.EditValue = "0.All";
            this.comboBoxEditSelection.Location = new System.Drawing.Point(14, 37);
            this.comboBoxEditSelection.Name = "comboBoxEditSelection";
            this.comboBoxEditSelection.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.comboBoxEditSelection.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditSelection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSelection.Properties.Items.AddRange(new object[] {
            "0.All",
            "1. Only Table",
            "2. Only View"});
            this.comboBoxEditSelection.Size = new System.Drawing.Size(139, 24);
            this.comboBoxEditSelection.TabIndex = 10;
            // 
            // comboBoxEditQryOption
            // 
            this.comboBoxEditQryOption.EditValue = "0.테이블이름";
            this.comboBoxEditQryOption.Location = new System.Drawing.Point(159, 37);
            this.comboBoxEditQryOption.Name = "comboBoxEditQryOption";
            this.comboBoxEditQryOption.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.comboBoxEditQryOption.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditQryOption.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditQryOption.Properties.Items.AddRange(new object[] {
            "0.테이블이름",
            "1.테이블 Comments",
            "2.컬럼이름",
            "3.컬럼 Comments"});
            this.comboBoxEditQryOption.Size = new System.Drawing.Size(158, 24);
            this.comboBoxEditQryOption.TabIndex = 11;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(321, 37);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Size = new System.Drawing.Size(151, 24);
            this.textEditName.TabIndex = 9;
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRetrieve.Font = new System.Drawing.Font("Tahoma", 11F);
            this.buttonRetrieve.Location = new System.Drawing.Point(1129, 37);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(176, 29);
            this.buttonRetrieve.TabIndex = 7;
            this.buttonRetrieve.Text = "Retrieve";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // gridViewSchemInfo
            // 
            this.gridViewSchemInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnTableName,
            this.gridColumnKind,
            this.gridColumnColumnId,
            this.gridColumnColomnName,
            this.gridColumnComments,
            this.gridColumnDataType,
            this.gridColumnDataDefault,
            this.gridColumnIsNull,
            this.gridColumnPK,
            this.gridColumnFK,
            this.gridColumnUQ});
            this.gridViewSchemInfo.GridControl = this.gridControlSchemInfo;
            this.gridViewSchemInfo.GroupCount = 2;
            this.gridViewSchemInfo.Name = "gridViewSchemInfo";
            this.gridViewSchemInfo.OptionsBehavior.ReadOnly = true;
            this.gridViewSchemInfo.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridViewSchemInfo.OptionsSelection.InvertSelection = true;
            this.gridViewSchemInfo.OptionsSelection.MultiSelect = true;
            this.gridViewSchemInfo.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewSchemInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewSchemInfo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnKind, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnTableName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "no";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.OptionsColumn.FixedWidth = true;
            this.gridColumnID.Visible = true;
            this.gridColumnID.VisibleIndex = 1;
            this.gridColumnID.Width = 45;
            // 
            // gridColumnTableName
            // 
            this.gridColumnTableName.Caption = "Table Name";
            this.gridColumnTableName.FieldName = "TABLE_NAME";
            this.gridColumnTableName.Name = "gridColumnTableName";
            this.gridColumnTableName.Visible = true;
            this.gridColumnTableName.VisibleIndex = 2;
            this.gridColumnTableName.Width = 191;
            // 
            // gridColumnKind
            // 
            this.gridColumnKind.Caption = "Kind";
            this.gridColumnKind.FieldName = "KIND";
            this.gridColumnKind.Name = "gridColumnKind";
            this.gridColumnKind.Visible = true;
            this.gridColumnKind.VisibleIndex = 5;
            // 
            // gridColumnColumnId
            // 
            this.gridColumnColumnId.Caption = "ColumnID";
            this.gridColumnColumnId.FieldName = "COLUMN_ID";
            this.gridColumnColumnId.Name = "gridColumnColumnId";
            this.gridColumnColumnId.OptionsColumn.FixedWidth = true;
            this.gridColumnColumnId.Visible = true;
            this.gridColumnColumnId.VisibleIndex = 2;
            this.gridColumnColumnId.Width = 60;
            // 
            // gridColumnColomnName
            // 
            this.gridColumnColomnName.Caption = "ColumnName";
            this.gridColumnColomnName.FieldName = "COLUMN_NAME";
            this.gridColumnColomnName.Name = "gridColumnColomnName";
            this.gridColumnColomnName.Visible = true;
            this.gridColumnColomnName.VisibleIndex = 3;
            this.gridColumnColomnName.Width = 177;
            // 
            // gridColumnComments
            // 
            this.gridColumnComments.Caption = "Comments";
            this.gridColumnComments.FieldName = "COMMENTS";
            this.gridColumnComments.Name = "gridColumnComments";
            this.gridColumnComments.Visible = true;
            this.gridColumnComments.VisibleIndex = 4;
            this.gridColumnComments.Width = 216;
            // 
            // gridColumnDataType
            // 
            this.gridColumnDataType.Caption = "DataType";
            this.gridColumnDataType.FieldName = "DATA_TYPE";
            this.gridColumnDataType.Name = "gridColumnDataType";
            this.gridColumnDataType.Visible = true;
            this.gridColumnDataType.VisibleIndex = 5;
            this.gridColumnDataType.Width = 234;
            // 
            // gridColumnDataDefault
            // 
            this.gridColumnDataDefault.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDataDefault.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnDataDefault.Caption = "Default";
            this.gridColumnDataDefault.FieldName = "DATA_DEFAULT";
            this.gridColumnDataDefault.Name = "gridColumnDataDefault";
            this.gridColumnDataDefault.Visible = true;
            this.gridColumnDataDefault.VisibleIndex = 6;
            // 
            // gridColumnIsNull
            // 
            this.gridColumnIsNull.Caption = "IsNull";
            this.gridColumnIsNull.FieldName = "ISNULL";
            this.gridColumnIsNull.Name = "gridColumnIsNull";
            this.gridColumnIsNull.OptionsColumn.FixedWidth = true;
            this.gridColumnIsNull.Visible = true;
            this.gridColumnIsNull.VisibleIndex = 7;
            this.gridColumnIsNull.Width = 100;
            // 
            // gridColumnPK
            // 
            this.gridColumnPK.Caption = "PK";
            this.gridColumnPK.FieldName = "PK";
            this.gridColumnPK.Name = "gridColumnPK";
            this.gridColumnPK.OptionsColumn.FixedWidth = true;
            this.gridColumnPK.Visible = true;
            this.gridColumnPK.VisibleIndex = 8;
            this.gridColumnPK.Width = 44;
            // 
            // gridColumnFK
            // 
            this.gridColumnFK.Caption = "FK";
            this.gridColumnFK.FieldName = "FK";
            this.gridColumnFK.Name = "gridColumnFK";
            this.gridColumnFK.OptionsColumn.FixedWidth = true;
            this.gridColumnFK.Visible = true;
            this.gridColumnFK.VisibleIndex = 9;
            this.gridColumnFK.Width = 39;
            // 
            // gridColumnUQ
            // 
            this.gridColumnUQ.Caption = "UQ";
            this.gridColumnUQ.FieldName = "UQ";
            this.gridColumnUQ.Name = "gridColumnUQ";
            this.gridColumnUQ.OptionsColumn.FixedWidth = true;
            this.gridColumnUQ.Visible = true;
            this.gridColumnUQ.VisibleIndex = 10;
            this.gridColumnUQ.Width = 50;
            // 
            // gridControlSchemInfo
            // 
            this.gridControlSchemInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSchemInfo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridControlSchemInfo.Location = new System.Drawing.Point(3, 85);
            this.gridControlSchemInfo.MainView = this.gridViewSchemInfo;
            this.gridControlSchemInfo.Name = "gridControlSchemInfo";
            this.gridControlSchemInfo.Size = new System.Drawing.Size(1493, 567);
            this.gridControlSchemInfo.TabIndex = 8;
            this.gridControlSchemInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSchemInfo});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEditName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1499, 79);
            this.groupControl1.TabIndex = 13;
            // 
            // ucSchemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButtonExcel);
            this.Controls.Add(this.comboBoxEditSelection);
            this.Controls.Add(this.comboBoxEditQryOption);
            this.Controls.Add(this.gridControlSchemInfo);
            this.Controls.Add(this.buttonRetrieve);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucSchemInfo";
            this.Size = new System.Drawing.Size(1499, 655);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditQryOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchemInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchemInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonExcel;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSelection;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditQryOption;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private System.Windows.Forms.Button buttonRetrieve;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSchemInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTableName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnKind;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColomnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComments;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDataType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDataDefault;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsNull;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUQ;
        private DevExpress.XtraGrid.GridControl gridControlSchemInfo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
