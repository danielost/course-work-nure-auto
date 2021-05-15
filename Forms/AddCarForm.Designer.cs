
namespace CourseWork
{
    partial class AddCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCarBtn = new System.Windows.Forms.Button();
            this.addType = new System.Windows.Forms.ComboBox();
            this.addPrice = new System.Windows.Forms.TextBox();
            this.addCondition = new System.Windows.Forms.TextBox();
            this.addCapacity = new System.Windows.Forms.TextBox();
            this.addPower = new System.Windows.Forms.TextBox();
            this.addYear = new System.Windows.Forms.TextBox();
            this.addModel = new System.Windows.Forms.TextBox();
            this.addMake = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.AddCarBtn);
            this.panel1.Controls.Add(this.addType);
            this.panel1.Controls.Add(this.addPrice);
            this.panel1.Controls.Add(this.addCondition);
            this.panel1.Controls.Add(this.addCapacity);
            this.panel1.Controls.Add(this.addPower);
            this.panel1.Controls.Add(this.addYear);
            this.panel1.Controls.Add(this.addModel);
            this.panel1.Controls.Add(this.addMake);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 218);
            this.panel1.TabIndex = 0;
            // 
            // AddCarBtn
            // 
            this.AddCarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AddCarBtn.FlatAppearance.BorderSize = 0;
            this.AddCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarBtn.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCarBtn.Location = new System.Drawing.Point(490, 137);
            this.AddCarBtn.Name = "AddCarBtn";
            this.AddCarBtn.Size = new System.Drawing.Size(216, 27);
            this.AddCarBtn.TabIndex = 10;
            this.AddCarBtn.Text = "Add";
            this.AddCarBtn.UseVisualStyleBackColor = false;
            this.AddCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // addType
            // 
            this.addType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addType.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addType.FormattingEnabled = true;
            this.addType.Items.AddRange(new object[] {
            "Sedan",
            "Coupe",
            "SUV",
            "CUV",
            "Van",
            "Truck",
            "Supercar"});
            this.addType.Location = new System.Drawing.Point(247, 138);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(216, 27);
            this.addType.TabIndex = 4;
            // 
            // addPrice
            // 
            this.addPrice.BackColor = System.Drawing.Color.White;
            this.addPrice.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPrice.Location = new System.Drawing.Point(490, 96);
            this.addPrice.Name = "addPrice";
            this.addPrice.PlaceholderText = "Price";
            this.addPrice.Size = new System.Drawing.Size(216, 27);
            this.addPrice.TabIndex = 8;
            // 
            // addCondition
            // 
            this.addCondition.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCondition.Location = new System.Drawing.Point(490, 54);
            this.addCondition.Name = "addCondition";
            this.addCondition.PlaceholderText = "Condition";
            this.addCondition.Size = new System.Drawing.Size(216, 27);
            this.addCondition.TabIndex = 7;
            // 
            // addCapacity
            // 
            this.addCapacity.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCapacity.Location = new System.Drawing.Point(490, 12);
            this.addCapacity.Name = "addCapacity";
            this.addCapacity.PlaceholderText = "Engine capacity";
            this.addCapacity.Size = new System.Drawing.Size(216, 27);
            this.addCapacity.TabIndex = 6;
            // 
            // addPower
            // 
            this.addPower.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPower.Location = new System.Drawing.Point(247, 180);
            this.addPower.Name = "addPower";
            this.addPower.PlaceholderText = "Horse power";
            this.addPower.Size = new System.Drawing.Size(216, 27);
            this.addPower.TabIndex = 5;
            // 
            // addYear
            // 
            this.addYear.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addYear.Location = new System.Drawing.Point(247, 96);
            this.addYear.Name = "addYear";
            this.addYear.PlaceholderText = "Year";
            this.addYear.Size = new System.Drawing.Size(216, 27);
            this.addYear.TabIndex = 3;
            // 
            // addModel
            // 
            this.addModel.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addModel.Location = new System.Drawing.Point(247, 54);
            this.addModel.Name = "addModel";
            this.addModel.PlaceholderText = "Model";
            this.addModel.Size = new System.Drawing.Size(216, 27);
            this.addModel.TabIndex = 2;
            // 
            // addMake
            // 
            this.addMake.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addMake.Location = new System.Drawing.Point(247, 12);
            this.addMake.Name = "addMake";
            this.addMake.PlaceholderText = "Make";
            this.addMake.Size = new System.Drawing.Size(216, 27);
            this.addMake.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 218);
            this.Controls.Add(this.panel1);
            this.Name = "AddCarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addYear;
        private System.Windows.Forms.TextBox addModel;
        private System.Windows.Forms.TextBox addMake;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox addCapacity;
        private System.Windows.Forms.TextBox addPower;
        private System.Windows.Forms.ComboBox addType;
        private System.Windows.Forms.TextBox addPrice;
        private System.Windows.Forms.TextBox addCondition;
        private System.Windows.Forms.Button AddCarBtn;
    }
}