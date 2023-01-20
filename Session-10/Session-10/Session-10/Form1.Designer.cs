namespace Session_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gvrGrades = new System.Windows.Forms.DataGridView();
            this.gvrChedule = new System.Windows.Forms.DataGridView();
            this.gdvCourses = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvrGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvrChedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStudents
            // 
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colAge,
            this.colRegnum});
            this.grvStudents.Location = new System.Drawing.Point(26, 25);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowHeadersWidth = 51;
            this.grvStudents.RowTemplate.Height = 29;
            this.grvStudents.Size = new System.Drawing.Size(755, 134);
            this.grvStudents.TabIndex = 0;
            this.grvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvStudents_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 59);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(147, 440);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(115, 59);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gvrGrades
            // 
            this.gvrGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvrGrades.Location = new System.Drawing.Point(26, 165);
            this.gvrGrades.Name = "gvrGrades";
            this.gvrGrades.RowHeadersWidth = 51;
            this.gvrGrades.RowTemplate.Height = 29;
            this.gvrGrades.Size = new System.Drawing.Size(338, 134);
            this.gvrGrades.TabIndex = 3;
            // 
            // gvrChedule
            // 
            this.gvrChedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvrChedule.Location = new System.Drawing.Point(26, 305);
            this.gvrChedule.Name = "gvrChedule";
            this.gvrChedule.RowHeadersWidth = 51;
            this.gvrChedule.RowTemplate.Height = 29;
            this.gvrChedule.Size = new System.Drawing.Size(755, 134);
            this.gvrChedule.TabIndex = 4;
            // 
            // gdvCourses
            // 
            this.gdvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCourses.Location = new System.Drawing.Point(392, 165);
            this.gdvCourses.Name = "gdvCourses";
            this.gdvCourses.RowHeadersWidth = 51;
            this.gdvCourses.RowTemplate.Height = 29;
            this.gdvCourses.Size = new System.Drawing.Size(389, 134);
            this.gdvCourses.TabIndex = 5;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.Width = 125;
            // 
            // colRegnum
            // 
            this.colRegnum.HeaderText = "Registration_Number";
            this.colRegnum.MinimumWidth = 6;
            this.colRegnum.Name = "colRegnum";
            this.colRegnum.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.gdvCourses);
            this.Controls.Add(this.gvrChedule);
            this.Controls.Add(this.gvrGrades);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvrGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvrChedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grvStudents;
        private Button btnSave;
        private Button btnLoad;
        private DataGridView gvrGrades;
        private DataGridView gvrChedule;
        private DataGridView gdvCourses;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colRegnum;
    }
}