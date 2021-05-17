
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
            this.editYear = new System.Windows.Forms.NumericUpDown();
            this.editType = new System.Windows.Forms.ComboBox();
            this.editPower = new System.Windows.Forms.NumericUpDown();
            this.editCapacity = new System.Windows.Forms.NumericUpDown();
            this.editCondition = new System.Windows.Forms.ComboBox();
            this.editPrice = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.editPhotoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoFormCarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // infoFormCarPic
            // 
            this.infoFormCarPic.Image = ((System.Drawing.Image)(resources.GetObject("infoFormCarPic.Image")));
            this.infoFormCarPic.Location = new System.Drawing.Point(63, 12);
            this.infoFormCarPic.Name = "infoFormCarPic";
            this.infoFormCarPic.Size = new System.Drawing.Size(399, 225);
            this.infoFormCarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoFormCarPic.TabIndex = 0;
            this.infoFormCarPic.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(478, 12);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(140, 29);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "[Car name]";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLbl.Location = new System.Drawing.Point(478, 56);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(101, 23);
            this.yearLbl.TabIndex = 2;
            this.yearLbl.Text = "Year: [Year]";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeLbl.Location = new System.Drawing.Point(478, 90);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(109, 23);
            this.typeLbl.TabIndex = 3;
            this.typeLbl.Text = "Type: [Type]";
            // 
            // engineLbl
            // 
            this.engineLbl.AutoSize = true;
            this.engineLbl.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.engineLbl.Location = new System.Drawing.Point(478, 124);
            this.engineLbl.Name = "engineLbl";
            this.engineLbl.Size = new System.Drawing.Size(251, 23);
            this.engineLbl.TabIndex = 4;
            this.engineLbl.Text = "Engine: [Capacity] [Power] hp";
            // 
            // conditionLbl
            // 
            this.conditionLbl.AutoSize = true;
            this.conditionLbl.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conditionLbl.Location = new System.Drawing.Point(478, 157);
            this.conditionLbl.Name = "conditionLbl";
            this.conditionLbl.Size = new System.Drawing.Size(187, 23);
            this.conditionLbl.TabIndex = 5;
            this.conditionLbl.Text = "Condition: [Condition]";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.Location = new System.Drawing.Point(63, 250);
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
            this.purchaseBtn.Location = new System.Drawing.Point(63, 289);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(147, 55);
            this.purchaseBtn.TabIndex = 7;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.UseVisualStyleBackColor = false;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(928, 12);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(104, 21);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
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
            // editYear
            // 
            this.editYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editYear.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editYear.Location = new System.Drawing.Point(816, 52);
            this.editYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.editYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.editYear.Name = "editYear";
            this.editYear.Size = new System.Drawing.Size(216, 27);
            this.editYear.TabIndex = 10;
            this.editYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // editType
            // 
            this.editType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editType.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editType.FormattingEnabled = true;
            this.editType.Items.AddRange(new object[] {
            "Coupe",
            "CUV",
            "Sedan",
            "Supercar",
            "SUV",
            "Truck",
            "Van"});
            this.editType.Location = new System.Drawing.Point(816, 87);
            this.editType.Name = "editType";
            this.editType.Size = new System.Drawing.Size(216, 27);
            this.editType.Sorted = true;
            this.editType.TabIndex = 11;
            // 
            // editPower
            // 
            this.editPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPower.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPower.Location = new System.Drawing.Point(843, 124);
            this.editPower.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.editPower.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.editPower.Name = "editPower";
            this.editPower.Size = new System.Drawing.Size(189, 27);
            this.editPower.TabIndex = 18;
            this.editPower.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // editCapacity
            // 
            this.editCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editCapacity.DecimalPlaces = 1;
            this.editCapacity.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editCapacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.editCapacity.Location = new System.Drawing.Point(843, 159);
            this.editCapacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.editCapacity.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.editCapacity.Name = "editCapacity";
            this.editCapacity.Size = new System.Drawing.Size(189, 27);
            this.editCapacity.TabIndex = 19;
            this.editCapacity.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // editCondition
            // 
            this.editCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCondition.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editCondition.FormattingEnabled = true;
            this.editCondition.Items.AddRange(new object[] {
            "Brand new",
            "Used"});
            this.editCondition.Location = new System.Drawing.Point(816, 194);
            this.editCondition.Name = "editCondition";
            this.editCondition.Size = new System.Drawing.Size(216, 27);
            this.editCondition.Sorted = true;
            this.editCondition.TabIndex = 20;
            // 
            // editPrice
            // 
            this.editPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPrice.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.editPrice.Location = new System.Drawing.Point(816, 266);
            this.editPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.editPrice.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.editPrice.Name = "editPrice";
            this.editPrice.Size = new System.Drawing.Size(216, 27);
            this.editPrice.TabIndex = 21;
            this.editPrice.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(885, 301);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(147, 31);
            this.SaveBtn.TabIndex = 22;
            this.SaveBtn.Text = "Save changes";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // editPhotoBtn
            // 
            this.editPhotoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.editPhotoBtn.FlatAppearance.BorderSize = 0;
            this.editPhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPhotoBtn.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editPhotoBtn.ForeColor = System.Drawing.Color.White;
            this.editPhotoBtn.Location = new System.Drawing.Point(63, 200);
            this.editPhotoBtn.Name = "editPhotoBtn";
            this.editPhotoBtn.Size = new System.Drawing.Size(119, 37);
            this.editPhotoBtn.TabIndex = 23;
            this.editPhotoBtn.Text = "Change photo";
            this.editPhotoBtn.UseVisualStyleBackColor = false;
            this.editPhotoBtn.Click += new System.EventHandler(this.editPhotoBtn_Click);
            // 
            // CarInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.editPhotoBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.editPrice);
            this.Controls.Add(this.editCondition);
            this.Controls.Add(this.editCapacity);
            this.Controls.Add(this.editPower);
            this.Controls.Add(this.editType);
            this.Controls.Add(this.editYear);
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
            ((System.ComponentModel.ISupportInitialize)(this.editYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPrice)).EndInit();
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
        private System.Windows.Forms.NumericUpDown editYear;
        private System.Windows.Forms.ComboBox editType;
        private System.Windows.Forms.NumericUpDown editPower;
        private System.Windows.Forms.NumericUpDown editCapacity;
        private System.Windows.Forms.ComboBox editCondition;
        private System.Windows.Forms.NumericUpDown editPrice;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button editPhotoBtn;
    }
}