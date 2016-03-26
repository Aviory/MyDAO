namespace MyDBOffset
{
    partial class UI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbDBType = new System.Windows.Forms.ComboBox();
            this.btnSelectDB = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(434, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(33, 359);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(130, 313);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 3;
            this.txtFName.Tag = "";
            this.txtFName.Text = "1";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(236, 313);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 4;
            this.txtLName.Text = "1";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(341, 313);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 5;
            this.txtAge.Text = "1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(33, 388);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(33, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbDBType
            // 
            this.cmbDBType.FormattingEnabled = true;
            this.cmbDBType.Items.AddRange(new object[] {
            "Mock",
            "MS_SQL",
            "My_SQL",
            "Mongo",
            "EntetyFr",
            "Redis"});
            this.cmbDBType.Location = new System.Drawing.Point(458, 49);
            this.cmbDBType.Name = "cmbDBType";
            this.cmbDBType.Size = new System.Drawing.Size(121, 21);
            this.cmbDBType.TabIndex = 8;
            this.cmbDBType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSelectDB
            // 
            this.btnSelectDB.Location = new System.Drawing.Point(504, 101);
            this.btnSelectDB.Name = "btnSelectDB";
            this.btnSelectDB.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDB.TabIndex = 9;
            this.btnSelectDB.Text = "SelectDB";
            this.btnSelectDB.UseVisualStyleBackColor = true;
            this.btnSelectDB.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(24, 313);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            this.txtId.Tag = "";
            this.txtId.Text = "1";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 508);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSelectDB);
            this.Controls.Add(this.cmbDBType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UI";
            this.Text = "DataBase";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbDBType;
        private System.Windows.Forms.Button btnSelectDB;
        private System.Windows.Forms.TextBox txtId;
    }
}

