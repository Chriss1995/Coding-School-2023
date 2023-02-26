namespace FuelGasStation.WinForm
{
    partial class TransactionForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.transactionEditDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMetod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.transactionLineEditDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValue1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddTrsasLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionEditDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineEditDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.transactionEditDtoBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(840, 250);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // transactionEditDtoBindingSource
            // 
            this.transactionEditDtoBindingSource.DataSource = typeof(FuelGasStation.Blazor.Shared.Transaction.TransactionEditDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDateTime,
            this.colPaymentMetod,
            this.colTotalValue,
            this.colCustomerID,
            this.colCustomerSurname,
            this.colEmployeeID,
            this.colEmployeeSurname});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colDateTime
            // 
            this.colDateTime.Caption = "Date  Time";
            this.colDateTime.FieldName = "DateTime";
            this.colDateTime.MinWidth = 25;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Visible = true;
            this.colDateTime.VisibleIndex = 1;
            this.colDateTime.Width = 94;
            // 
            // colPaymentMetod
            // 
            this.colPaymentMetod.Caption = "Payment Method";
            this.colPaymentMetod.FieldName = "PaymentMetod";
            this.colPaymentMetod.MinWidth = 25;
            this.colPaymentMetod.Name = "colPaymentMetod";
            this.colPaymentMetod.Visible = true;
            this.colPaymentMetod.VisibleIndex = 2;
            this.colPaymentMetod.Width = 94;
            // 
            // colTotalValue
            // 
            this.colTotalValue.Caption = "Total Value";
            this.colTotalValue.FieldName = "TotalValue";
            this.colTotalValue.MinWidth = 25;
            this.colTotalValue.Name = "colTotalValue";
            this.colTotalValue.Visible = true;
            this.colTotalValue.VisibleIndex = 3;
            this.colTotalValue.Width = 94;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "Customer Id";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 25;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Width = 94;
            // 
            // colCustomerSurname
            // 
            this.colCustomerSurname.Caption = "Customer Surname";
            this.colCustomerSurname.FieldName = "CustomerSurname";
            this.colCustomerSurname.MinWidth = 25;
            this.colCustomerSurname.Name = "colCustomerSurname";
            this.colCustomerSurname.Visible = true;
            this.colCustomerSurname.VisibleIndex = 0;
            this.colCustomerSurname.Width = 94;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.MinWidth = 25;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Width = 94;
            // 
            // colEmployeeSurname
            // 
            this.colEmployeeSurname.Caption = "Employee Surname";
            this.colEmployeeSurname.FieldName = "EmployeeSurname";
            this.colEmployeeSurname.MinWidth = 25;
            this.colEmployeeSurname.Name = "colEmployeeSurname";
            this.colEmployeeSurname.Visible = true;
            this.colEmployeeSurname.VisibleIndex = 4;
            this.colEmployeeSurname.Width = 94;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.transactionLineEditDtoBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(12, 360);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(977, 233);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // transactionLineEditDtoBindingSource
            // 
            this.transactionLineEditDtoBindingSource.DataSource = typeof(FuelGasStation.Blazor.Shared.TransactionLine.TransactionLineEditDto);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colQuantity,
            this.colItemPrice,
            this.colNetValue,
            this.colPercentDiscount,
            this.colDiscountValue,
            this.colTotalValue1,
            this.colTransactionID,
            this.colItemCode,
            this.colItemID});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.MinWidth = 25;
            this.colId1.Name = "colId1";
            this.colId1.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 0;
            this.colQuantity.Width = 94;
            // 
            // colItemPrice
            // 
            this.colItemPrice.Caption = "Item Price";
            this.colItemPrice.FieldName = "ItemPrice";
            this.colItemPrice.MinWidth = 25;
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 1;
            this.colItemPrice.Width = 94;
            // 
            // colNetValue
            // 
            this.colNetValue.Caption = "Net Value";
            this.colNetValue.FieldName = "NetValue";
            this.colNetValue.MinWidth = 25;
            this.colNetValue.Name = "colNetValue";
            this.colNetValue.Visible = true;
            this.colNetValue.VisibleIndex = 2;
            this.colNetValue.Width = 94;
            // 
            // colPercentDiscount
            // 
            this.colPercentDiscount.Caption = "Percent Discount";
            this.colPercentDiscount.FieldName = "PercentDiscount";
            this.colPercentDiscount.MinWidth = 25;
            this.colPercentDiscount.Name = "colPercentDiscount";
            this.colPercentDiscount.Visible = true;
            this.colPercentDiscount.VisibleIndex = 3;
            this.colPercentDiscount.Width = 94;
            // 
            // colDiscountValue
            // 
            this.colDiscountValue.Caption = "Discount Value";
            this.colDiscountValue.FieldName = "DiscountValue";
            this.colDiscountValue.MinWidth = 25;
            this.colDiscountValue.Name = "colDiscountValue";
            this.colDiscountValue.Visible = true;
            this.colDiscountValue.VisibleIndex = 4;
            this.colDiscountValue.Width = 94;
            // 
            // colTotalValue1
            // 
            this.colTotalValue1.Caption = "Total Value";
            this.colTotalValue1.FieldName = "TotalValue";
            this.colTotalValue1.MinWidth = 25;
            this.colTotalValue1.Name = "colTotalValue1";
            this.colTotalValue1.Visible = true;
            this.colTotalValue1.VisibleIndex = 5;
            this.colTotalValue1.Width = 94;
            // 
            // colTransactionID
            // 
            this.colTransactionID.Caption = "Transaction ID";
            this.colTransactionID.FieldName = "TransactionID";
            this.colTransactionID.MinWidth = 25;
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.Visible = true;
            this.colTransactionID.VisibleIndex = 6;
            this.colTransactionID.Width = 94;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Item Code";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.MinWidth = 25;
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 7;
            this.colItemCode.Width = 94;
            // 
            // colItemID
            // 
            this.colItemID.Caption = "Item Id";
            this.colItemID.FieldName = "ItemID";
            this.colItemID.MinWidth = 25;
            this.colItemID.Name = "colItemID";
            this.colItemID.Width = 94;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(950, 85);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(109, 49);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddTrsasLine
            // 
            this.btnAddTrsasLine.Location = new System.Drawing.Point(950, 215);
            this.btnAddTrsasLine.Name = "btnAddTrsasLine";
            this.btnAddTrsasLine.Size = new System.Drawing.Size(109, 49);
            this.btnAddTrsasLine.TabIndex = 3;
            this.btnAddTrsasLine.Text = "Add TransLine";
            this.btnAddTrsasLine.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(479, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(469, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transaction Lines";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTrsasLine);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "TransactionForm";
            this.Text = "Transaction Form";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionEditDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineEditDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private BindingSource transactionEditDtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMetod;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeSurname;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private BindingSource transactionLineEditDtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValue1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private Button btnAddCustomer;
        private Button btnAddTrsasLine;
        private Label label1;
        private Label label2;
    }
}