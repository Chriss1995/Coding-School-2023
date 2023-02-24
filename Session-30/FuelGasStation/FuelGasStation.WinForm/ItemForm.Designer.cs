namespace FuelGasStation.WinForm
{
    partial class ItemForm
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
            this.grvItem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemBindSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grvItem
            // 
            this.grvItem.DataSource = this.itemBindingSource;
            this.grvItem.Location = new System.Drawing.Point(95, 37);
            this.grvItem.MainView = this.gridView1;
            this.grvItem.Name = "grvItem";
            this.grvItem.Size = new System.Drawing.Size(760, 380);
            this.grvItem.TabIndex = 0;
            this.grvItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colCost,
            this.colPrice});
            this.gridView1.GridControl = this.grvItem;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 25;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 94;
            // 
            // colItemType
            // 
            this.colItemType.Caption = "Item Type";
            this.colItemType.FieldName = "ItemType";
            this.colItemType.MinWidth = 25;
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 2;
            this.colItemType.Width = 94;
            // 
            // colCost
            // 
            this.colCost.Caption = "Cost";
            this.colCost.FieldName = "Cost";
            this.colCost.MinWidth = 25;
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 3;
            this.colCost.Width = 94;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            this.colPrice.Width = 94;
            // 
            // itemBindSource
            // 
            this.itemBindSource.DataSource = typeof(FuelGasStation.Model.Item);
            this.itemBindSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(FuelGasStation.Model.Item);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.grvItem);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grvItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private BindingSource itemBindSource;
        private BindingSource itemBindingSource;
    }
}