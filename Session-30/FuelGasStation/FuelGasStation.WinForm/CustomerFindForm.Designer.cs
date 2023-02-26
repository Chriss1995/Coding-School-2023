namespace FuelGasStation.WinForm
{
    partial class CustomerFindForm
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
            this.texCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnAddTransactio = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texCardNumber
            // 
            this.texCardNumber.Location = new System.Drawing.Point(245, 78);
            this.texCardNumber.Name = "texCardNumber";
            this.texCardNumber.Size = new System.Drawing.Size(194, 27);
            this.texCardNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CardNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(239, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Finding the Customer";
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(133, 132);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(94, 52);
            this.btnAddCust.TabIndex = 3;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnAddTransactio
            // 
            this.btnAddTransactio.Location = new System.Drawing.Point(294, 132);
            this.btnAddTransactio.Name = "btnAddTransactio";
            this.btnAddTransactio.Size = new System.Drawing.Size(94, 52);
            this.btnAddTransactio.TabIndex = 4;
            this.btnAddTransactio.Text = "Add Transaction";
            this.btnAddTransactio.UseVisualStyleBackColor = true;
            this.btnAddTransactio.Click += new System.EventHandler(this.btnAddTransactio_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(455, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 52);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Back";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(465, 78);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 25);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // CustomerFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 214);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddTransactio);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texCardNumber);
            this.Name = "CustomerFindForm";
            this.Text = "Customer Find Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox texCardNumber;
        private Label label1;
        private Label label2;
        private Button btnAddCust;
        private Button btnAddTransactio;
        private Button btnSave;
        private Button btnFind;
    }
}