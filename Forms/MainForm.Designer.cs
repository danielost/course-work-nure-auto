
namespace CourseWork
{
    partial class MainForm
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
            this.requestSupplyBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.contactsBtn = new System.Windows.Forms.Button();
            this.catalogBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminPanelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.adminPanelBtn);
            this.panel1.Controls.Add(this.requestSupplyBtn);
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Controls.Add(this.contactsBtn);
            this.panel1.Controls.Add(this.catalogBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 681);
            this.panel1.TabIndex = 0;
            // 
            // requestSupplyBtn
            // 
            this.requestSupplyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestSupplyBtn.FlatAppearance.BorderSize = 0;
            this.requestSupplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestSupplyBtn.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.requestSupplyBtn.ForeColor = System.Drawing.Color.White;
            this.requestSupplyBtn.Location = new System.Drawing.Point(0, 320);
            this.requestSupplyBtn.Name = "requestSupplyBtn";
            this.requestSupplyBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.requestSupplyBtn.Size = new System.Drawing.Size(220, 60);
            this.requestSupplyBtn.TabIndex = 4;
            this.requestSupplyBtn.Text = "Request supply";
            this.requestSupplyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestSupplyBtn.UseVisualStyleBackColor = true;
            this.requestSupplyBtn.Click += new System.EventHandler(this.requestSupplyBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpBtn.ForeColor = System.Drawing.Color.White;
            this.helpBtn.Location = new System.Drawing.Point(0, 260);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.helpBtn.Size = new System.Drawing.Size(220, 60);
            this.helpBtn.TabIndex = 3;
            this.helpBtn.Text = "Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // contactsBtn
            // 
            this.contactsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactsBtn.FlatAppearance.BorderSize = 0;
            this.contactsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactsBtn.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactsBtn.ForeColor = System.Drawing.Color.White;
            this.contactsBtn.Location = new System.Drawing.Point(0, 200);
            this.contactsBtn.Name = "contactsBtn";
            this.contactsBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.contactsBtn.Size = new System.Drawing.Size(220, 60);
            this.contactsBtn.TabIndex = 2;
            this.contactsBtn.Text = "Contacts";
            this.contactsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactsBtn.UseVisualStyleBackColor = true;
            this.contactsBtn.Click += new System.EventHandler(this.contactsBtn_Click);
            // 
            // catalogBtn
            // 
            this.catalogBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.catalogBtn.FlatAppearance.BorderSize = 0;
            this.catalogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogBtn.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catalogBtn.ForeColor = System.Drawing.Color.White;
            this.catalogBtn.Location = new System.Drawing.Point(0, 140);
            this.catalogBtn.Name = "catalogBtn";
            this.catalogBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.catalogBtn.Size = new System.Drawing.Size(220, 60);
            this.catalogBtn.TabIndex = 1;
            this.catalogBtn.Text = "Vehicles";
            this.catalogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalogBtn.UseVisualStyleBackColor = true;
            this.catalogBtn.Click += new System.EventHandler(this.catalogBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            // 
            // adminPanelBtn
            // 
            this.adminPanelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminPanelBtn.FlatAppearance.BorderSize = 0;
            this.adminPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPanelBtn.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminPanelBtn.ForeColor = System.Drawing.Color.White;
            this.adminPanelBtn.Location = new System.Drawing.Point(0, 380);
            this.adminPanelBtn.Name = "adminPanelBtn";
            this.adminPanelBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.adminPanelBtn.Size = new System.Drawing.Size(220, 60);
            this.adminPanelBtn.TabIndex = 5;
            this.adminPanelBtn.Text = "Admin panel";
            this.adminPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminPanelBtn.UseVisualStyleBackColor = true;
            this.adminPanelBtn.Click += new System.EventHandler(this.adminPanelBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button requestSupplyBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button contactsBtn;
        private System.Windows.Forms.Button catalogBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button adminPanelBtn;
    }
}