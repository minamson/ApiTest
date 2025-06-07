namespace ApiTest
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.gridControlSchemInfo = new DevExpress.XtraGrid.GridControl();
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
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEditQryOption = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButtonExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchemInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchemInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditQryOption.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRetrieve.Location = new System.Drawing.Point(808, 12);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(176, 29);
            this.buttonRetrieve.TabIndex = 0;
            this.buttonRetrieve.Text = "Retrieve";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // gridControlSchemInfo
            // 
            this.gridControlSchemInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSchemInfo.Location = new System.Drawing.Point(1, 47);
            this.gridControlSchemInfo.MainView = this.gridViewSchemInfo;
            this.gridControlSchemInfo.Name = "gridControlSchemInfo";
            this.gridControlSchemInfo.Size = new System.Drawing.Size(1181, 500);
            this.gridControlSchemInfo.TabIndex = 1;
            this.gridControlSchemInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSchemInfo});
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
            this.gridColumnTableName.VisibleIndex = 1;
            this.gridColumnTableName.Width = 191;
            // 
            // gridColumnKind
            // 
            this.gridColumnKind.Caption = "Kind";
            this.gridColumnKind.FieldName = "KIND";
            this.gridColumnKind.Name = "gridColumnKind";
            this.gridColumnKind.Visible = true;
            this.gridColumnKind.VisibleIndex = 1;
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
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(128, 15);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(151, 20);
            this.textEditName.TabIndex = 3;
            // 
            // comboBoxEditQryOption
            // 
            this.comboBoxEditQryOption.EditValue = "0.테이블이름";
            this.comboBoxEditQryOption.Location = new System.Drawing.Point(12, 15);
            this.comboBoxEditQryOption.Name = "comboBoxEditQryOption";
            this.comboBoxEditQryOption.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditQryOption.Properties.Items.AddRange(new object[] {
            "0.테이블이름",
            "1.테이블 Comments",
            "2.컬럼이름",
            "3.컬럼 Comments"});
            this.comboBoxEditQryOption.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditQryOption.TabIndex = 5;
            // 
            // simpleButtonExcel
            // 
            this.simpleButtonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonExcel.Location = new System.Drawing.Point(1000, 13);
            this.simpleButtonExcel.Name = "simpleButtonExcel";
            this.simpleButtonExcel.Size = new System.Drawing.Size(175, 28);
            this.simpleButtonExcel.TabIndex = 6;
            this.simpleButtonExcel.Text = "Excel";
            this.simpleButtonExcel.Click += new System.EventHandler(this.simpleButtonExcel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 548);
            this.Controls.Add(this.simpleButtonExcel);
            this.Controls.Add(this.comboBoxEditQryOption);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.gridControlSchemInfo);
            this.Controls.Add(this.buttonRetrieve);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchemInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchemInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditQryOption.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRetrieve;
        private DevExpress.XtraGrid.GridControl gridControlSchemInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSchemInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTableName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColomnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComments;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDataType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsNull;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUQ;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditQryOption;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDataDefault;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExcel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnKind;
    }
}

