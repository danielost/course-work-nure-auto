
namespace CourseWork
{
    partial class VehiclesForm
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
            this.vehiclesBG = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.vehiclesNavPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddCarBtn = new System.Windows.Forms.Button();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vehiclesBG.SuspendLayout();
            this.vehiclesNavPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehiclesBG
            // 
            this.vehiclesBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.vehiclesBG.Controls.Add(this.flowLayoutPanel1);
            this.vehiclesBG.Controls.Add(this.vehiclesNavPanel);
            this.vehiclesBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehiclesBG.Location = new System.Drawing.Point(0, 0);
            this.vehiclesBG.Name = "vehiclesBG";
            this.vehiclesBG.Size = new System.Drawing.Size(1044, 601);
            this.vehiclesBG.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1044, 553);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // vehiclesNavPanel
            // 
            this.vehiclesNavPanel.BackColor = System.Drawing.Color.Gray;
            this.vehiclesNavPanel.Controls.Add(this.panel1);
            this.vehiclesNavPanel.Controls.Add(this.modelTextBox);
            this.vehiclesNavPanel.Controls.Add(this.MakeTextBox);
            this.vehiclesNavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehiclesNavPanel.Location = new System.Drawing.Point(0, 0);
            this.vehiclesNavPanel.Name = "vehiclesNavPanel";
            this.vehiclesNavPanel.Size = new System.Drawing.Size(1044, 48);
            this.vehiclesNavPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddCarBtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(673, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 48);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sort by price Ascending",
            "Sort by price Descending",
            "Sort by Name (A-Z)",
            "Sort by Name (Z-A)"});
            this.comboBox1.Location = new System.Drawing.Point(155, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 22);
            this.comboBox1.TabIndex = 3;
            // 
            // AddCarBtn
            // 
            this.AddCarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.AddCarBtn.FlatAppearance.BorderSize = 0;
            this.AddCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarBtn.ForeColor = System.Drawing.Color.White;
            this.AddCarBtn.Location = new System.Drawing.Point(25, 12);
            this.AddCarBtn.Name = "AddCarBtn";
            this.AddCarBtn.Size = new System.Drawing.Size(114, 23);
            this.AddCarBtn.TabIndex = 2;
            this.AddCarBtn.Text = "Add a car";
            this.AddCarBtn.UseVisualStyleBackColor = false;
            this.AddCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelTextBox.Location = new System.Drawing.Point(237, 9);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.PlaceholderText = "Model";
            this.modelTextBox.Size = new System.Drawing.Size(168, 30);
            this.modelTextBox.TabIndex = 1;
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakeTextBox.Location = new System.Drawing.Point(36, 9);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.PlaceholderText = "Make";
            this.MakeTextBox.Size = new System.Drawing.Size(168, 30);
            this.MakeTextBox.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel10.Location = new System.Drawing.Point(693, 178);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(224, 169);
            this.panel10.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel11.Location = new System.Drawing.Point(3, 353);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(224, 169);
            this.panel11.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel12.Location = new System.Drawing.Point(233, 353);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(224, 169);
            this.panel12.TabIndex = 9;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel13.Location = new System.Drawing.Point(410, 216);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(224, 169);
            this.panel13.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(349, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 100);
            this.panel3.TabIndex = 1;
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.vehiclesBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehiclesForm";
            this.Text = "VehiclesForm";
            this.vehiclesBG.ResumeLayout(false);
            this.vehiclesNavPanel.ResumeLayout(false);
            this.vehiclesNavPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel vehiclesBG;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel vehiclesNavPanel;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Button AddCarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}