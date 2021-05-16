
namespace CourseWork
{
    partial class CarInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInfoForm));
            this.infoFormCarPic = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.engineLbl = new System.Windows.Forms.Label();
            this.conditionLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoFormCarPic)).BeginInit();
            this.SuspendLayout();
            // 
            // infoFormCarPic
            // 
            this.infoFormCarPic.Image = ((System.Drawing.Image)(resources.GetObject("infoFormCarPic.Image")));
            this.infoFormCarPic.Location = new System.Drawing.Point(12, 12);
            this.infoFormCarPic.Name = "infoFormCarPic";
            this.infoFormCarPic.Size = new System.Drawing.Size(355, 230);
            this.infoFormCarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoFormCarPic.TabIndex = 0;
            this.infoFormCarPic.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(383, 12);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(140, 29);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "[Car name]";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLbl.Location = new System.Drawing.Point(383, 56);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(101, 23);
            this.yearLbl.TabIndex = 2;
            this.yearLbl.Text = "Year: [Year]";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeLbl.Location = new System.Drawing.Point(383, 90);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(109, 23);
            this.typeLbl.TabIndex = 3;
            this.typeLbl.Text = "Type: [Type]";
            // 
            // engineLbl
            // 
            this.engineLbl.AutoSize = true;
            this.engineLbl.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.engineLbl.Location = new System.Drawing.Point(383, 124);
            this.engineLbl.Name = "engineLbl";
            this.engineLbl.Size = new System.Drawing.Size(251, 23);
            this.engineLbl.TabIndex = 4;
            this.engineLbl.Text = "Engine: [Capacity] [Power] hp";
            // 
            // conditionLbl
            // 
            this.conditionLbl.AutoSize = true;
            this.conditionLbl.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conditionLbl.Location = new System.Drawing.Point(383, 157);
            this.conditionLbl.Name = "conditionLbl";
            this.conditionLbl.Size = new System.Drawing.Size(187, 23);
            this.conditionLbl.TabIndex = 5;
            this.conditionLbl.Text = "Condition: [Condition]";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.Location = new System.Drawing.Point(12, 260);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(147, 29);
            this.priceLbl.TabIndex = 6;
            this.priceLbl.Text = "Price: [Price]";
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.purchaseBtn.FlatAppearance.BorderSize = 0;
            this.purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBtn.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchaseBtn.ForeColor = System.Drawing.Color.White;
            this.purchaseBtn.Location = new System.Drawing.Point(12, 301);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(147, 31);
            this.purchaseBtn.TabIndex = 7;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(928, 10);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(104, 21);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "←";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.conditionLbl);
            this.Controls.Add(this.engineLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.infoFormCarPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarInfoForm";
            this.Text = "CarInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.infoFormCarPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox infoFormCarPic;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label engineLbl;
        private System.Windows.Forms.Label conditionLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label1;
    }
}