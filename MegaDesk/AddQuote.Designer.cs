namespace MegaDesk
{
    partial class AddQuote
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
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.materialForm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rushOptionsForm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numDrawersForm = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRem = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numWidthForm = new System.Windows.Forms.NumericUpDown();
            this.numDepthForm = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidthForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepthForm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullNameBox
            // 
            this.fullNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameBox.Location = new System.Drawing.Point(322, 161);
            this.fullNameBox.Margin = new System.Windows.Forms.Padding(7);
            this.fullNameBox.MaxLength = 64;
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(529, 48);
            this.fullNameBox.TabIndex = 0;
            // 
            // materialForm
            // 
            this.materialForm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.materialForm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.materialForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialForm.FormattingEnabled = true;
            this.materialForm.Location = new System.Drawing.Point(870, 457);
            this.materialForm.Margin = new System.Windows.Forms.Padding(7);
            this.materialForm.Name = "materialForm";
            this.materialForm.Size = new System.Drawing.Size(263, 48);
            this.materialForm.TabIndex = 6;
            this.materialForm.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.materialForm.Leave += new System.EventHandler(this.MaterialForm_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(931, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Material:";
            // 
            // rushOptionsForm
            // 
            this.rushOptionsForm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.rushOptionsForm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rushOptionsForm.BackColor = System.Drawing.SystemColors.Window;
            this.rushOptionsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOptionsForm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rushOptionsForm.FormattingEnabled = true;
            this.rushOptionsForm.Location = new System.Drawing.Point(530, 457);
            this.rushOptionsForm.Margin = new System.Windows.Forms.Padding(7);
            this.rushOptionsForm.Name = "rushOptionsForm";
            this.rushOptionsForm.Size = new System.Drawing.Size(263, 48);
            this.rushOptionsForm.TabIndex = 5;
            this.rushOptionsForm.Leave += new System.EventHandler(this.RushOptionsForm_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rush options:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of drawers:";
            // 
            // numDrawersForm
            // 
            this.numDrawersForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersForm.Location = new System.Drawing.Point(457, 263);
            this.numDrawersForm.Margin = new System.Windows.Forms.Padding(7);
            this.numDrawersForm.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawersForm.Name = "numDrawersForm";
            this.numDrawersForm.Size = new System.Drawing.Size(93, 48);
            this.numDrawersForm.TabIndex = 1;
            this.numDrawersForm.Click += new System.EventHandler(this.NumDepthForm_Click);
            this.numDrawersForm.Enter += new System.EventHandler(this.NumDepthForm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Full name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(419, 63);
            this.label7.TabIndex = 9;
            this.label7.Text = "Add New Quote";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(345, 709);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 69);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(658, 709);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 69);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(992, 741);
            this.lblDate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(111, 36);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "----:--:--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(457, 234);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "0 - 7";
            // 
            // lblRem
            // 
            this.lblRem.AutoSize = true;
            this.lblRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRem.Location = new System.Drawing.Point(866, 181);
            this.lblRem.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblRem.Name = "lblRem";
            this.lblRem.Size = new System.Drawing.Size(44, 31);
            this.lblRem.TabIndex = 13;
            this.lblRem.Text = "64";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(905, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(267, 31);
            this.label13.TabIndex = 14;
            this.label13.Text = "characters remaining";
            // 
            // numWidthForm
            // 
            this.numWidthForm.DecimalPlaces = 1;
            this.numWidthForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWidthForm.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWidthForm.Location = new System.Drawing.Point(168, 183);
            this.numWidthForm.Margin = new System.Windows.Forms.Padding(7);
            this.numWidthForm.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numWidthForm.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWidthForm.Name = "numWidthForm";
            this.numWidthForm.Size = new System.Drawing.Size(128, 48);
            this.numWidthForm.TabIndex = 4;
            this.numWidthForm.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWidthForm.Click += new System.EventHandler(this.NumDepthForm_Click);
            this.numWidthForm.Enter += new System.EventHandler(this.NumDepthForm_Click);
            // 
            // numDepthForm
            // 
            this.numDepthForm.DecimalPlaces = 1;
            this.numDepthForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDepthForm.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDepthForm.Location = new System.Drawing.Point(168, 78);
            this.numDepthForm.Margin = new System.Windows.Forms.Padding(7);
            this.numDepthForm.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numDepthForm.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDepthForm.Name = "numDepthForm";
            this.numDepthForm.Size = new System.Drawing.Size(128, 48);
            this.numDepthForm.TabIndex = 3;
            this.numDepthForm.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDepthForm.Click += new System.EventHandler(this.NumDepthForm_Click);
            this.numDepthForm.Enter += new System.EventHandler(this.NumDepthForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Depth:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "12 - 48";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "24 - 96";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 36);
            this.label10.TabIndex = 7;
            this.label10.Text = "in";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 199);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 36);
            this.label11.TabIndex = 8;
            this.label11.Text = "in";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numDepthForm);
            this.groupBox1.Controls.Add(this.numWidthForm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(105, 375);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(373, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensions";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 805);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblRem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDrawersForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rushOptionsForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialForm);
            this.Controls.Add(this.fullNameBox);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed_1);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.Click += new System.EventHandler(this.AddQuote_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidthForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepthForm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.ComboBox materialForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDrawersForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox rushOptionsForm;
        private System.Windows.Forms.NumericUpDown numWidthForm;
        private System.Windows.Forms.NumericUpDown numDepthForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}