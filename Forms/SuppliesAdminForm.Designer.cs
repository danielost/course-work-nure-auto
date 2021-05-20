
namespace CourseWork
{
    partial class SuppliesAdminForm
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
            this.PriceTextBox = new System.Windows.Forms.NumericUpDown();
            this.AmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.ReqButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NewReqGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewReqGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.PriceTextBox);
            this.panel1.Controls.Add(this.AmountUpDown);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LoginTextBox);
            this.panel1.Controls.Add(this.ReqButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.ModelTextBox);
            this.panel1.Controls.Add(this.MakeTextBox);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.NewReqGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 601);
            this.panel1.TabIndex = 0;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceTextBox.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceTextBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PriceTextBox.Location = new System.Drawing.Point(12, 199);
            this.PriceTextBox.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.PriceTextBox.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(205, 27);
            this.PriceTextBox.TabIndex = 54;
            this.PriceTextBox.Value = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            // 
            // AmountUpDown
            // 
            this.AmountUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountUpDown.Font = new System.Drawing.Font("Roboto Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.AmountUpDown.Location = new System.Drawing.Point(12, 159);
            this.AmountUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AmountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountUpDown.Name = "AmountUpDown";
            this.AmountUpDown.Size = new System.Drawing.Size(205, 28);
            this.AmountUpDown.TabIndex = 53;
            this.AmountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel2.Location = new System.Drawing.Point(12, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 2);
            this.panel2.TabIndex = 52;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTextBox.Location = new System.Drawing.Point(12, 23);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Supplier login";
            this.LoginTextBox.Size = new System.Drawing.Size(205, 30);
            this.LoginTextBox.TabIndex = 51;
            // 
            // ReqButton
            // 
            this.ReqButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.ReqButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReqButton.FlatAppearance.BorderSize = 0;
            this.ReqButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReqButton.ForeColor = System.Drawing.Color.White;
            this.ReqButton.Location = new System.Drawing.Point(242, 23);
            this.ReqButton.Name = "ReqButton";
            this.ReqButton.Size = new System.Drawing.Size(174, 30);
            this.ReqButton.TabIndex = 50;
            this.ReqButton.Text = "Create a request";
            this.ReqButton.UseVisualStyleBackColor = false;
            this.ReqButton.Click += new System.EventHandler(this.ReqButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(242, 197);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(174, 28);
            this.AddButton.TabIndex = 49;
            this.AddButton.Text = "Add the car";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelTextBox.Location = new System.Drawing.Point(12, 118);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.PlaceholderText = "Model";
            this.ModelTextBox.Size = new System.Drawing.Size(205, 30);
            this.ModelTextBox.TabIndex = 3;
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakeTextBox.Location = new System.Drawing.Point(12, 78);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.PlaceholderText = "Make";
            this.MakeTextBox.Size = new System.Drawing.Size(205, 30);
            this.MakeTextBox.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(432, 241);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 348);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NewReqGrid
            // 
            this.NewReqGrid.AllowUserToResizeRows = false;
            this.NewReqGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NewReqGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewReqGrid.Enabled = false;
            this.NewReqGrid.Location = new System.Drawing.Point(12, 241);
            this.NewReqGrid.Name = "NewReqGrid";
            this.NewReqGrid.RowTemplate.Height = 25;
            this.NewReqGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NewReqGrid.Size = new System.Drawing.Size(404, 348);
            this.NewReqGrid.TabIndex = 0;
            this.NewReqGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewReqGrid_CellClick);
            // 
            // SuppliesAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuppliesAdminForm";
            this.Text = "SuppliesAdminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewReqGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView NewReqGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReqButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.NumericUpDown AmountUpDown;
        private System.Windows.Forms.NumericUpDown PriceTextBox;
    }
}