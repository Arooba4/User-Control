namespace SE_user_control_lab.User_Control
{
    partial class StudentControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnSearch = new Button();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtGrade = new TextBox();
            label4 = new Label();
            txtSearchName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 113);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 184);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Grade:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(225, 248);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(225, 398);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(84, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(235, 27);
            txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(84, 113);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(235, 27);
            txtAge.TabIndex = 6;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(85, 184);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(234, 27);
            txtGrade.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 287);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 8;
            label4.Text = "Search Name:";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(75, 327);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(244, 27);
            txtSearchName.TabIndex = 9;
            // 
            // StudentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearchName);
            Controls.Add(label4);
            Controls.Add(txtGrade);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentControl";
            Size = new Size(808, 505);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtGrade;
        private Label label4;
        private TextBox txtSearchName;
    }
}
