
namespace CourseWork
{
    partial class AccForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editLogin = new System.Windows.Forms.TextBox();
            this.editUserName = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.passBtn = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.editLogin);
            this.panel1.Controls.Add(this.editUserName);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.loginLbl);
            this.panel1.Controls.Add(this.usernameLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 601);
            this.panel1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(165, 226);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(113, 30);
            this.cancelBtn.TabIndex = 53;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // editLogin
            // 
            this.editLogin.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editLogin.Location = new System.Drawing.Point(94, 62);
            this.editLogin.Name = "editLogin";
            this.editLogin.PlaceholderText = "New login";
            this.editLogin.Size = new System.Drawing.Size(205, 30);
            this.editLogin.TabIndex = 52;
            // 
            // editUserName
            // 
            this.editUserName.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editUserName.Location = new System.Drawing.Point(138, 20);
            this.editUserName.Name = "editUserName";
            this.editUserName.PlaceholderText = "New username";
            this.editUserName.Size = new System.Drawing.Size(205, 30);
            this.editUserName.TabIndex = 51;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(165, 190);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(113, 30);
            this.saveBtn.TabIndex = 50;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(25, 190);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(113, 30);
            this.editBtn.TabIndex = 49;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Roboto Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLbl.ForeColor = System.Drawing.Color.Black;
            this.statusLbl.Location = new System.Drawing.Point(25, 146);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(74, 27);
            this.statusLbl.TabIndex = 5;
            this.statusLbl.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editPassword);
            this.panel2.Controls.Add(this.passBtn);
            this.panel2.Controls.Add(this.passwordLbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 33);
            this.panel2.TabIndex = 4;
            // 
            // editPassword
            // 
            this.editPassword.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPassword.Location = new System.Drawing.Point(119, 0);
            this.editPassword.Name = "editPassword";
            this.editPassword.PlaceholderText = "New password";
            this.editPassword.Size = new System.Drawing.Size(205, 30);
            this.editPassword.TabIndex = 54;
            // 
            // passBtn
            // 
            this.passBtn.AutoSize = true;
            this.passBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.passBtn.Font = new System.Drawing.Font("Roboto Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.passBtn.Location = new System.Drawing.Point(231, 0);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(153, 27);
            this.passBtn.TabIndex = 5;
            this.passBtn.Text = "(Click to show)";
            this.passBtn.Click += new System.EventHandler(this.passBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.passwordLbl.Font = new System.Drawing.Font("Roboto Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.ForeColor = System.Drawing.Color.Black;
            this.passwordLbl.Location = new System.Drawing.Point(113, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(118, 27);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "[Password]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Roboto Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLbl.ForeColor = System.Drawing.Color.Black;
            this.loginLbl.Location = new System.Drawing.Point(25, 63);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(70, 27);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "Login ";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Roboto Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLbl.ForeColor = System.Drawing.Color.Black;
            this.usernameLbl.Location = new System.Drawing.Point(25, 22);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(115, 27);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username ";
            // 
            // AccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccForm";
            this.Text = "AccForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label passBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox editLogin;
        private System.Windows.Forms.TextBox editUserName;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox editPassword;
    }
}