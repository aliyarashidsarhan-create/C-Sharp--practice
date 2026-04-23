namespace project01
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
            dataGridView1 = new DataGridView();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnShowAll = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(341, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(447, 323);
            dataGridView1.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(55, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(55, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(55, 191);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(55, 269);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(243, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(243, 121);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(243, 191);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(243, 269);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 59);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 9;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 125);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 10;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 194);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 11;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 273);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 12;
            label4.Text = "Search";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnShowAll;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
