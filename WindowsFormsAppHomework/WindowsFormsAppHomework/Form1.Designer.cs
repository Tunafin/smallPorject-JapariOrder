
namespace WindowsFormsAppHomework
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listViewMenuItem = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMyClass = new System.Windows.Forms.ComboBox();
            this.comboBoxStudentName = new System.Windows.Forms.ComboBox();
            this.comboBoxMenuName = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxSubTotal = new System.Windows.Forms.GroupBox();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.groupBoxHint = new System.Windows.Forms.GroupBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxSubTotal.SuspendLayout();
            this.groupBoxHint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMenuItem
            // 
            this.listViewMenuItem.FullRowSelect = true;
            this.listViewMenuItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMenuItem.HideSelection = false;
            this.listViewMenuItem.Location = new System.Drawing.Point(35, 204);
            this.listViewMenuItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewMenuItem.MultiSelect = false;
            this.listViewMenuItem.Name = "listViewMenuItem";
            this.listViewMenuItem.Size = new System.Drawing.Size(364, 181);
            this.listViewMenuItem.TabIndex = 4;
            this.listViewMenuItem.UseCompatibleStateImageBehavior = false;
            this.listViewMenuItem.View = System.Windows.Forms.View.Details;
            this.listViewMenuItem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMenuItem_ItemSelectionChanged);
            this.listViewMenuItem.Leave += new System.EventHandler(this.listViewMenuItem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "班級";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "種類";
            // 
            // comboBoxMyClass
            // 
            this.comboBoxMyClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMyClass.FormattingEnabled = true;
            this.comboBoxMyClass.Location = new System.Drawing.Point(86, 78);
            this.comboBoxMyClass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxMyClass.Name = "comboBoxMyClass";
            this.comboBoxMyClass.Size = new System.Drawing.Size(154, 28);
            this.comboBoxMyClass.TabIndex = 1;
            this.comboBoxMyClass.Tag = "";
            this.comboBoxMyClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxMyClass_SelectedIndexChanged);
            // 
            // comboBoxStudentName
            // 
            this.comboBoxStudentName.FormattingEnabled = true;
            this.comboBoxStudentName.ItemHeight = 20;
            this.comboBoxStudentName.Location = new System.Drawing.Point(86, 121);
            this.comboBoxStudentName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxStudentName.Name = "comboBoxStudentName";
            this.comboBoxStudentName.Size = new System.Drawing.Size(154, 28);
            this.comboBoxStudentName.TabIndex = 2;
            // 
            // comboBoxMenuName
            // 
            this.comboBoxMenuName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMenuName.FormattingEnabled = true;
            this.comboBoxMenuName.Location = new System.Drawing.Point(86, 169);
            this.comboBoxMenuName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxMenuName.Name = "comboBoxMenuName";
            this.comboBoxMenuName.Size = new System.Drawing.Size(186, 28);
            this.comboBoxMenuName.TabIndex = 3;
            this.comboBoxMenuName.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenuName_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAdd.Location = new System.Drawing.Point(35, 534);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 49);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "加入訂單";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCheck.Location = new System.Drawing.Point(35, 599);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(148, 49);
            this.buttonCheck.TabIndex = 8;
            this.buttonCheck.Text = "檢視訂單";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelQuantity.ForeColor = System.Drawing.Color.White;
            this.labelQuantity.Location = new System.Drawing.Point(32, 489);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(54, 27);
            this.labelQuantity.TabIndex = 9;
            this.labelQuantity.Text = "數量";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(96, 488);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.ReadOnly = true;
            this.numericUpDownQuantity.Size = new System.Drawing.Size(87, 29);
            this.numericUpDownQuantity.TabIndex = 6;
            this.numericUpDownQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.SetAndShowSubTotal);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(36, 393);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(362, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "升級套餐";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Font = new System.Drawing.Font("微軟正黑體 Light", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton3.Location = new System.Drawing.Point(233, 29);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(121, 23);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B餐(敬請期待)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.SetAndShowSubTotal);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微軟正黑體", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.Location = new System.Drawing.Point(87, 29);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 23);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "A餐(+30元)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.SetAndShowSubTotal);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("微軟正黑體", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.Location = new System.Drawing.Point(12, 29);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "無";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.SetAndShowSubTotal);
            // 
            // groupBoxSubTotal
            // 
            this.groupBoxSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSubTotal.Controls.Add(this.labelSubTotal);
            this.groupBoxSubTotal.ForeColor = System.Drawing.Color.White;
            this.groupBoxSubTotal.Location = new System.Drawing.Point(208, 479);
            this.groupBoxSubTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSubTotal.Name = "groupBoxSubTotal";
            this.groupBoxSubTotal.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSubTotal.Size = new System.Drawing.Size(191, 73);
            this.groupBoxSubTotal.TabIndex = 12;
            this.groupBoxSubTotal.TabStop = false;
            this.groupBoxSubTotal.Text = "小計";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSubTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSubTotal.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSubTotal.Location = new System.Drawing.Point(14, 24);
            this.labelSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(128, 37);
            this.labelSubTotal.TabIndex = 13;
            this.labelSubTotal.Text = "0元";
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxHint
            // 
            this.groupBoxHint.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxHint.Controls.Add(this.labelHint);
            this.groupBoxHint.ForeColor = System.Drawing.Color.White;
            this.groupBoxHint.Location = new System.Drawing.Point(206, 570);
            this.groupBoxHint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxHint.Name = "groupBoxHint";
            this.groupBoxHint.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxHint.Size = new System.Drawing.Size(193, 78);
            this.groupBoxHint.TabIndex = 13;
            this.groupBoxHint.TabStop = false;
            this.groupBoxHint.Text = "套餐內容";
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(6, 26);
            this.labelHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(162, 44);
            this.labelHint.TabIndex = 0;
            this.labelHint.Text = "A餐: 隨機飲料+沙拉\r\nB餐: 敬請期待";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.ForeColor = System.Drawing.Color.Azure;
            this.labelTitle.Location = new System.Drawing.Point(2, 14);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(437, 40);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "　Japari食堂 學生訂購系統　";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(286, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "made  by  Wei-Chi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(155)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(441, 679);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxHint);
            this.Controls.Add(this.groupBoxSubTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxMenuName);
            this.Controls.Add(this.comboBoxStudentName);
            this.Controls.Add(this.comboBoxMyClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMenuItem);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MENU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSubTotal.ResumeLayout(false);
            this.groupBoxHint.ResumeLayout(false);
            this.groupBoxHint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMyClass;
        private System.Windows.Forms.ComboBox comboBoxStudentName;
        private System.Windows.Forms.ComboBox comboBoxMenuName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxSubTotal;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.GroupBox groupBoxHint;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label4;
    }
}

