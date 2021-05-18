
namespace CourseWork
{
    partial class CarUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarUnit));
            this.CarPic = new System.Windows.Forms.PictureBox();
            this.carPrice = new System.Windows.Forms.Label();
            this.carName = new System.Windows.Forms.Label();
            this.DelCarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.condLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CarPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarPic
            // 
            this.CarPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarPic.Image = ((System.Drawing.Image)(resources.GetObject("CarPic.Image")));
            this.CarPic.Location = new System.Drawing.Point(12, 8);
            this.CarPic.Name = "CarPic";
            this.CarPic.Size = new System.Drawing.Size(311, 175);
            this.CarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarPic.TabIndex = 1;
            this.CarPic.TabStop = false;
            this.CarPic.Click += new System.EventHandler(this.CarPic_Click);
            // 
            // carPrice
            // 
            this.carPrice.AutoSize = true;
            this.carPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.carPrice.Font = new System.Drawing.Font("Bebas Neue", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.carPrice.ForeColor = System.Drawing.Color.Green;
            this.carPrice.Location = new System.Drawing.Point(0, 0);
            this.carPrice.Name = "carPrice";
            this.carPrice.Size = new System.Drawing.Size(77, 41);
            this.carPrice.TabIndex = 2;
            this.carPrice.Text = "Price";
            // 
            // carName
            // 
            this.carName.AutoSize = true;
            this.carName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carName.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carName.Location = new System.Drawing.Point(12, 190);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(245, 29);
            this.carName.TabIndex = 3;
            this.carName.Text = "[Year], [Make], [Model]";
            this.carName.Click += new System.EventHandler(this.carName_Click);
            // 
            // DelCarBtn
            // 
            this.DelCarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.DelCarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelCarBtn.FlatAppearance.BorderSize = 0;
            this.DelCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelCarBtn.Font = new System.Drawing.Font("Roboto Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelCarBtn.ForeColor = System.Drawing.Color.White;
            this.DelCarBtn.Location = new System.Drawing.Point(244, 8);
            this.DelCarBtn.Name = "DelCarBtn";
            this.DelCarBtn.Size = new System.Drawing.Size(79, 32);
            this.DelCarBtn.TabIndex = 4;
            this.DelCarBtn.Text = "Delete";
            this.DelCarBtn.UseVisualStyleBackColor = false;
            this.DelCarBtn.Click += new System.EventHandler(this.DelCarBtn_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.condLbl);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.carPrice);
            this.panel1.Location = new System.Drawing.Point(10, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 47);
            this.panel1.TabIndex = 6;
            // 
            // condLbl
            // 
            this.condLbl.AutoSize = true;
            this.condLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.condLbl.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.condLbl.Location = new System.Drawing.Point(77, 0);
            this.condLbl.Name = "condLbl";
            this.condLbl.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.condLbl.Size = new System.Drawing.Size(121, 31);
            this.condLbl.TabIndex = 7;
            this.condLbl.Text = "–  [Condition]";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(124, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // CarUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DelCarBtn);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.CarPic);
            this.Name = "CarUnit";
            this.Size = new System.Drawing.Size(333, 268);
            ((System.ComponentModel.ISupportInitialize)(this.CarPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CarPic;
        private System.Windows.Forms.Label carPrice;
        private System.Windows.Forms.Label carName;
        private System.Windows.Forms.Button DelCarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label condLbl;
    }
}
