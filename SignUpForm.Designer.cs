
namespace CourseWork
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RegPassConfirm = new System.Windows.Forms.TextBox();
            this.ToRegistrationButton = new System.Windows.Forms.Label();
            this.RegLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.RegPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RegName);
            this.panel1.Controls.Add(this.RegPassConfirm);
            this.panel1.Controls.Add(this.ToRegistrationButton);
            this.panel1.Controls.Add(this.RegLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SignUpButton);
            this.panel1.Controls.Add(this.RegPass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 0;
            // 
            // RegName
            // 
            this.RegName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegName.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegName.Location = new System.Drawing.Point(500, 331);
            this.RegName.Name = "RegName";
            this.RegName.PlaceholderText = "Name";
            this.RegName.Size = new System.Drawing.Size(265, 28);
            this.RegName.TabIndex = 17;
            // 
            // RegPassConfirm
            // 
            this.RegPassConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegPassConfirm.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegPassConfirm.Location = new System.Drawing.Point(500, 434);
            this.RegPassConfirm.Name = "RegPassConfirm";
            this.RegPassConfirm.PlaceholderText = "Confirm password";
            this.RegPassConfirm.Size = new System.Drawing.Size(265, 28);
            this.RegPassConfirm.TabIndex = 16;
            this.RegPassConfirm.UseSystemPasswordChar = true;
            // 
            // ToRegistrationButton
            // 
            this.ToRegistrationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToRegistrationButton.AutoSize = true;
            this.ToRegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToRegistrationButton.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ToRegistrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.ToRegistrationButton.Location = new System.Drawing.Point(686, 302);
            this.ToRegistrationButton.Name = "ToRegistrationButton";
            this.ToRegistrationButton.Size = new System.Drawing.Size(90, 15);
            this.ToRegistrationButton.TabIndex = 15;
            this.ToRegistrationButton.Text = "sign in window";
            this.ToRegistrationButton.Click += new System.EventHandler(this.ToRegistrationButton_Click);
            // 
            // RegLogin
            // 
            this.RegLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegLogin.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegLogin.Location = new System.Drawing.Point(500, 365);
            this.RegLogin.Name = "RegLogin";
            this.RegLogin.PlaceholderText = "Login";
            this.RegLogin.Size = new System.Drawing.Size(265, 28);
            this.RegLogin.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(589, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(487, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Please sign up below or go back to";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(510, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome to Nure Automotive!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(500, 472);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(265, 31);
            this.SignUpButton.TabIndex = 10;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // RegPass
            // 
            this.RegPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegPass.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegPass.Location = new System.Drawing.Point(500, 400);
            this.RegPass.Name = "RegPass";
            this.RegPass.PlaceholderText = "Password";
            this.RegPass.Size = new System.Drawing.Size(265, 28);
            this.RegPass.TabIndex = 9;
            this.RegPass.UseSystemPasswordChar = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "SignUpForm";
            this.ShowIcon = false;
            this.Text = "Nure Automotive - Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RegLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox RegPass;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.TextBox RegPassConfirm;
        private System.Windows.Forms.Label ToRegistrationButton;
    }
}