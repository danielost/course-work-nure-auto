
namespace CourseWork
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.showBtn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WrongDataLabel = new System.Windows.Forms.Label();
            this.LoginAutoBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ToRegistrationButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.PassAutoBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.showBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.WrongDataLabel);
            this.panel1.Controls.Add(this.LoginAutoBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ToRegistrationButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SignInButton);
            this.panel1.Controls.Add(this.PassAutoBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 0;
            // 
            // showBtn
            // 
            this.showBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showBtn.AutoSize = true;
            this.showBtn.BackColor = System.Drawing.Color.White;
            this.showBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showBtn.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showBtn.Location = new System.Drawing.Point(737, 380);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(19, 15);
            this.showBtn.TabIndex = 11;
            this.showBtn.Text = "👁";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 105);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fast log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WrongDataLabel
            // 
            this.WrongDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WrongDataLabel.AutoSize = true;
            this.WrongDataLabel.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WrongDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.WrongDataLabel.Location = new System.Drawing.Point(517, 458);
            this.WrongDataLabel.Name = "WrongDataLabel";
            this.WrongDataLabel.Size = new System.Drawing.Size(230, 14);
            this.WrongDataLabel.TabIndex = 9;
            this.WrongDataLabel.Text = "Wrong login or password, please try again";
            this.WrongDataLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginAutoBox
            // 
            this.LoginAutoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginAutoBox.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginAutoBox.Location = new System.Drawing.Point(498, 339);
            this.LoginAutoBox.Name = "LoginAutoBox";
            this.LoginAutoBox.PlaceholderText = "Login";
            this.LoginAutoBox.Size = new System.Drawing.Size(265, 28);
            this.LoginAutoBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(509, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please sign in below or";
            // 
            // ToRegistrationButton
            // 
            this.ToRegistrationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToRegistrationButton.AutoSize = true;
            this.ToRegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToRegistrationButton.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ToRegistrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.ToRegistrationButton.Location = new System.Drawing.Point(643, 308);
            this.ToRegistrationButton.Name = "ToRegistrationButton";
            this.ToRegistrationButton.Size = new System.Drawing.Size(109, 15);
            this.ToRegistrationButton.TabIndex = 5;
            this.ToRegistrationButton.Text = "create an account";
            this.ToRegistrationButton.Click += new System.EventHandler(this.ToRegistrationButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(508, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Nure Automotive!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(498, 413);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(265, 31);
            this.SignInButton.TabIndex = 3;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // PassAutoBox
            // 
            this.PassAutoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassAutoBox.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassAutoBox.Location = new System.Drawing.Point(498, 374);
            this.PassAutoBox.Name = "PassAutoBox";
            this.PassAutoBox.PlaceholderText = "Password";
            this.PassAutoBox.Size = new System.Drawing.Size(265, 28);
            this.PassAutoBox.TabIndex = 2;
            this.PassAutoBox.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(784, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 105);
            this.button2.TabIndex = 12;
            this.button2.Text = "Fast log in";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nure Automotive - Sign In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox PassAutoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ToRegistrationButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginAutoBox;
        private System.Windows.Forms.Label WrongDataLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label showBtn;
        private System.Windows.Forms.Button button2;
    }
}