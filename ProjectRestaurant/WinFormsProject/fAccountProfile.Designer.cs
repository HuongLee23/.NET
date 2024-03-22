namespace WinFormsProject
{
    partial class fAccountProfile
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
            panel1 = new Panel();
            btnExit = new Button();
            btnUpdate = new Button();
            panel6 = new Panel();
            txtReEnterPass = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            txtNewPass = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            txtDisplayName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtUsername = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 509);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(397, 456);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(271, 456);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtReEnterPass);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(3, 375);
            panel6.Name = "panel6";
            panel6.Size = new Size(509, 75);
            panel6.TabIndex = 5;
            // 
            // txtReEnterPass
            // 
            txtReEnterPass.Location = new Point(227, 20);
            txtReEnterPass.Name = "txtReEnterPass";
            txtReEnterPass.Size = new Size(279, 31);
            txtReEnterPass.TabIndex = 1;
            txtReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 20);
            label5.Name = "label5";
            label5.Size = new Size(114, 29);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtNewPass);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 282);
            panel5.Name = "panel5";
            panel5.Size = new Size(509, 75);
            panel5.TabIndex = 4;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(227, 20);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(279, 31);
            txtNewPass.TabIndex = 1;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 20);
            label4.Name = "label4";
            label4.Size = new Size(177, 29);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(509, 75);
            panel4.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(227, 20);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(279, 31);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 20);
            label3.Name = "label3";
            label3.Size = new Size(125, 29);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtDisplayName);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(509, 75);
            panel3.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(227, 20);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(279, 31);
            txtDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 20);
            label2.Name = "label2";
            label2.Size = new Size(157, 29);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 75);
            panel2.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(227, 20);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(279, 31);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(193, 29);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(539, 530);
            Controls.Add(panel1);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private TextBox txtPassword;
        private Label label3;
        private Panel panel3;
        private TextBox txtDisplayName;
        private Label label2;
        private Panel panel2;
        private TextBox txtUsername;
        private Label label1;
        private Button btnExit;
        private Button btnUpdate;
        private Panel panel6;
        private TextBox txtReEnterPass;
        private Label label5;
        private Panel panel5;
        private TextBox txtNewPass;
        private Label label4;
    }
}