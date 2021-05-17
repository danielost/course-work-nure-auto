
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
            ((System.ComponentModel.ISupportInitialize)(this.CarPic)).BeginInit();
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
            this.carPrice.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carPrice.Location = new System.Drawing.Point(12, 242);
            this.carPrice.Name = "carPrice";
            this.carPrice.Size = new System.Drawing.Size(39, 17);
            this.carPrice.TabIndex = 2;
            this.carPrice.Text = "Price";
            // 
            // carName
            // 
            this.carName.AutoSize = true;
            this.carName.Font = new System.Drawing.Font("Roboto Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carName.Location = new System.Drawing.Point(9, 204);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(239, 29);
            this.carName.TabIndex = 3;
            this.carName.Text = "[Year], [Make], [Model]";
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
            // CarUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.DelCarBtn);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.CarPic);
            this.Name = "CarUnit";
            this.Size = new System.Drawing.Size(335, 270);
            ((System.ComponentModel.ISupportInitialize)(this.CarPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CarPic;
        private System.Windows.Forms.Label carPrice;
        private System.Windows.Forms.Label carName;
        private System.Windows.Forms.Button DelCarBtn;
    }
}
