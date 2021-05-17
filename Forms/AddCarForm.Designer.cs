
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
            this.addPrice = new System.Windows.Forms.NumericUpDown();
            this.addPower = new System.Windows.Forms.NumericUpDown();
            this.addCondition = new System.Windows.Forms.ComboBox();
            this.addCapacity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addYear = new System.Windows.Forms.NumericUpDown();
            this.AddCarBtn = new System.Windows.Forms.Button();
            this.addType = new System.Windows.Forms.ComboBox();
            this.addModel = new System.Windows.Forms.TextBox();
            this.addMake = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addPicBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.addPicBtn);
            this.panel1.Controls.Add(this.addPrice);
            this.panel1.Controls.Add(this.addPower);
            this.panel1.Controls.Add(this.addCondition);
            this.panel1.Controls.Add(this.addCapacity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addYear);
            this.panel1.Controls.Add(this.AddCarBtn);
            this.panel1.Controls.Add(this.addType);
            this.panel1.Controls.Add(this.addModel);
            this.panel1.Controls.Add(this.addMake);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 218);
            this.panel1.TabIndex = 0;
            // 
            // addPrice
            // 
            this.addPrice.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.addPrice.Location = new System.Drawing.Point(483, 96);
            this.addPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.addPrice.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(216, 27);
            this.addPrice.TabIndex = 18;
            this.addPrice.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // addPower
            // 
            this.addPower.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPower.Location = new System.Drawing.Point(483, 54);
            this.addPower.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addPower.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.addPower.Name = "addPower";
            this.addPower.Size = new System.Drawing.Size(216, 27);
            this.addPower.TabIndex = 17;
            this.addPower.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // addCondition
            // 
            this.addCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCondition.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCondition.FormattingEnabled = true;
            this.addCondition.Items.AddRange(new object[] {
            "Brand new",
            "Used"});
            this.addCondition.Location = new System.Drawing.Point(247, 179);
            this.addCondition.Name = "addCondition";
            this.addCondition.Size = new System.Drawing.Size(216, 27);
            this.addCondition.Sorted = true;
            this.addCondition.TabIndex = 16;
            // 
            // addCapacity
            // 
            this.addCapacity.DecimalPlaces = 1;
            this.addCapacity.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCapacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.addCapacity.Location = new System.Drawing.Point(483, 12);
            this.addCapacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.addCapacity.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.addCapacity.Name = "addCapacity";
            this.addCapacity.Size = new System.Drawing.Size(216, 27);
            this.addCapacity.TabIndex = 15;
            this.addCapacity.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(715, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Engine capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(715, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(715, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Horse power";
            // 
            // addYear
            // 
            this.addYear.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addYear.Location = new System.Drawing.Point(247, 96);
            this.addYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.addYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.addYear.Name = "addYear";
            this.addYear.Size = new System.Drawing.Size(216, 27);
            this.addYear.TabIndex = 3;
            this.addYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // AddCarBtn
            // 
            this.AddCarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AddCarBtn.FlatAppearance.BorderSize = 0;
            this.AddCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarBtn.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCarBtn.Location = new System.Drawing.Point(483, 178);
            this.AddCarBtn.Name = "AddCarBtn";
            this.AddCarBtn.Size = new System.Drawing.Size(216, 27);
            this.AddCarBtn.TabIndex = 9;
            this.AddCarBtn.Text = "Add the car";
            this.AddCarBtn.UseVisualStyleBackColor = false;
            this.AddCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // addType
            // 
            this.addType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addType.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addType.FormattingEnabled = true;
            this.addType.Items.AddRange(new object[] {
            "Coupe",
            "CUV",
            "Sedan",
            "Supercar",
            "SUV",
            "Truck",
            "Van"});
            this.addType.Location = new System.Drawing.Point(247, 138);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(216, 27);
            this.addType.Sorted = true;
            this.addType.TabIndex = 4;
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
            // addPicBtn
            // 
            this.addPicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.addPicBtn.FlatAppearance.BorderSize = 0;
            this.addPicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPicBtn.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPicBtn.Location = new System.Drawing.Point(483, 138);
            this.addPicBtn.Name = "addPicBtn";
            this.addPicBtn.Size = new System.Drawing.Size(216, 27);
            this.addPicBtn.TabIndex = 19;
            this.addPicBtn.Text = "Add a picture";
            this.addPicBtn.UseVisualStyleBackColor = false;
            this.addPicBtn.Click += new System.EventHandler(this.addPicBtn_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 218);
            this.Controls.Add(this.panel1);
            this.Name = "AddCarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addModel;
        private System.Windows.Forms.TextBox addMake;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox addType;
        private System.Windows.Forms.Button AddCarBtn;
        private System.Windows.Forms.NumericUpDown addYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown addCapacity;
        private System.Windows.Forms.ComboBox addCondition;
        private System.Windows.Forms.NumericUpDown addPrice;
        private System.Windows.Forms.NumericUpDown addPower;
        private System.Windows.Forms.Button addPicBtn;
    }
}