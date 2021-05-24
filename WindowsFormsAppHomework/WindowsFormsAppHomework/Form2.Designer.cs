
namespace WindowsFormsAppHomework
{
    partial class Form2
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
            this.listViewDetail = new System.Windows.Forms.ListView();
            this.groupBoxTotalAll = new System.Windows.Forms.GroupBox();
            this.labelTotalAll = new System.Windows.Forms.Label();
            this.comboBoxMyClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.labelRecord = new System.Windows.Forms.Label();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.listViewStatistics = new System.Windows.Forms.ListView();
            this.groupBoxTotalAll.SuspendLayout();
            this.groupBoxDetail.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDetail
            // 
            this.listViewDetail.Font = new System.Drawing.Font("微軟正黑體", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewDetail.FullRowSelect = true;
            this.listViewDetail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDetail.Location = new System.Drawing.Point(6, 30);
            this.listViewDetail.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDetail.Name = "listViewDetail";
            this.listViewDetail.Size = new System.Drawing.Size(450, 209);
            this.listViewDetail.TabIndex = 1;
            this.listViewDetail.UseCompatibleStateImageBehavior = false;
            this.listViewDetail.View = System.Windows.Forms.View.Details;
            this.listViewDetail.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewDetail_ItemSelectionChanged);
            this.listViewDetail.Leave += new System.EventHandler(this.listViewDetail_Leave);
            // 
            // groupBoxTotalAll
            // 
            this.groupBoxTotalAll.Controls.Add(this.labelTotalAll);
            this.groupBoxTotalAll.Location = new System.Drawing.Point(280, 32);
            this.groupBoxTotalAll.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTotalAll.Name = "groupBoxTotalAll";
            this.groupBoxTotalAll.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTotalAll.Size = new System.Drawing.Size(164, 75);
            this.groupBoxTotalAll.TabIndex = 13;
            this.groupBoxTotalAll.TabStop = false;
            this.groupBoxTotalAll.Text = "總價";
            // 
            // labelTotalAll
            // 
            this.labelTotalAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTotalAll.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTotalAll.Location = new System.Drawing.Point(12, 29);
            this.labelTotalAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalAll.Name = "labelTotalAll";
            this.labelTotalAll.Size = new System.Drawing.Size(142, 36);
            this.labelTotalAll.TabIndex = 13;
            this.labelTotalAll.Text = "0元";
            this.labelTotalAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMyClass
            // 
            this.comboBoxMyClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMyClass.FormattingEnabled = true;
            this.comboBoxMyClass.Location = new System.Drawing.Point(67, 20);
            this.comboBoxMyClass.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMyClass.Name = "comboBoxMyClass";
            this.comboBoxMyClass.Size = new System.Drawing.Size(124, 25);
            this.comboBoxMyClass.TabIndex = 14;
            this.comboBoxMyClass.Tag = "";
            this.comboBoxMyClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxMyClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "班級";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("微軟正黑體", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDate.Location = new System.Drawing.Point(240, 20);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(186, 27);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "日期: XXXX/XX/XX";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Khaki;
            this.buttonDelete.Font = new System.Drawing.Font("微軟正黑體", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDelete.Location = new System.Drawing.Point(6, 244);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(130, 40);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "刪除所選項目";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOut.Font = new System.Drawing.Font("微軟正黑體", 17.82178F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonOut.Location = new System.Drawing.Point(280, 122);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(164, 58);
            this.buttonOut.TabIndex = 17;
            this.buttonOut.Text = "產生訂購單";
            this.buttonOut.UseVisualStyleBackColor = false;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDetail.Controls.Add(this.labelRecord);
            this.groupBoxDetail.Controls.Add(this.buttonDeleteAll);
            this.groupBoxDetail.Controls.Add(this.buttonDelete);
            this.groupBoxDetail.Controls.Add(this.listViewDetail);
            this.groupBoxDetail.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxDetail.Location = new System.Drawing.Point(15, 73);
            this.groupBoxDetail.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDetail.Size = new System.Drawing.Size(460, 290);
            this.groupBoxDetail.TabIndex = 20;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "  明細 (依加入訂單順序)  ";
            // 
            // labelRecord
            // 
            this.labelRecord.Location = new System.Drawing.Point(292, 250);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(142, 27);
            this.labelRecord.TabIndex = 18;
            this.labelRecord.Text = "總筆數: 99筆";
            this.labelRecord.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDeleteAll.Font = new System.Drawing.Font("微軟正黑體", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDeleteAll.Location = new System.Drawing.Point(140, 243);
            this.buttonDeleteAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(130, 40);
            this.buttonDeleteAll.TabIndex = 17;
            this.buttonDeleteAll.Text = "清空所有項目";
            this.buttonDeleteAll.UseVisualStyleBackColor = false;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStatistics.Controls.Add(this.listViewStatistics);
            this.groupBoxStatistics.Controls.Add(this.groupBoxTotalAll);
            this.groupBoxStatistics.Controls.Add(this.buttonOut);
            this.groupBoxStatistics.Font = new System.Drawing.Font("微軟正黑體", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxStatistics.Location = new System.Drawing.Point(15, 393);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(460, 202);
            this.groupBoxStatistics.TabIndex = 21;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "結算";
            // 
            // listViewStatistics
            // 
            this.listViewStatistics.Font = new System.Drawing.Font("微軟正黑體", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewStatistics.HideSelection = false;
            this.listViewStatistics.Location = new System.Drawing.Point(15, 33);
            this.listViewStatistics.Name = "listViewStatistics";
            this.listViewStatistics.Size = new System.Drawing.Size(255, 147);
            this.listViewStatistics.TabIndex = 18;
            this.listViewStatistics.UseCompatibleStateImageBehavior = false;
            this.listViewStatistics.View = System.Windows.Forms.View.Details;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(488, 612);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxMyClass);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "訂購單";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxTotalAll.ResumeLayout(false);
            this.groupBoxDetail.ResumeLayout(false);
            this.groupBoxStatistics.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewDetail;
        private System.Windows.Forms.GroupBox groupBoxTotalAll;
        private System.Windows.Forms.Label labelTotalAll;
        private System.Windows.Forms.ComboBox comboBoxMyClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.GroupBox groupBoxDetail;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.ListView listViewStatistics;
    }
}