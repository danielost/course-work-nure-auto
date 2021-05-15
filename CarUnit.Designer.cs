
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
            this.DelCarBtn = new System.Windows.Forms.Label();
            this.CarPic = new System.Windows.Forms.PictureBox();
            this.carPrice = new System.Windows.Forms.Label();
            this.carName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DelCarBtn
            // 
            this.DelCarBtn.AutoSize = true;
            this.DelCarBtn.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelCarBtn.Location = new System.Drawing.Point(283, 11);
            this.DelCarBtn.Name = "DelCarBtn";
            this.DelCarBtn.Size = new System.Drawing.Size(40, 14);
            this.DelCarBtn.TabIndex = 0;
            this.DelCarBtn.Text = "Delete";
            // 
            // CarPic
            // 
            this.CarPic.Image = ((System.Drawing.Image)(resources.GetObject("CarPic.Image")));
            this.CarPic.Location = new System.Drawing.Point(19, 28);
            this.CarPic.Name = "CarPic";
            this.CarPic.Size = new System.Drawing.Size(299, 161);
            this.CarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarPic.TabIndex = 1;
            this.CarPic.TabStop = false;
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
            // CarUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.carName);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.CarPic);
            this.Controls.Add(this.DelCarBtn);
            this.Name = "CarUnit";
            this.Size = new System.Drawing.Size(335, 270);
            ((System.ComponentModel.ISupportInitialize)(this.CarPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DelCarBtn;
        private System.Windows.Forms.PictureBox CarPic;
        private System.Windows.Forms.Label carPrice;
        private System.Windows.Forms.Label carName;
    }
}
