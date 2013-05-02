namespace memwatch
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("th");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "bad",
            "1223",
            "45667"}, -1);
            this.colorBtn = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.colHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(24, 34);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(93, 43);
            this.colorBtn.TabIndex = 0;
            this.colorBtn.Text = "I am a Button";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Location = new System.Drawing.Point(22, 9);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(35, 12);
            this.infoText.TabIndex = 1;
            this.infoText.Text = "hello";
            this.infoText.Click += new System.EventHandler(this.infoText_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(179, 34);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.BackColor = System.Drawing.Color.Linen;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeader1,
            this.colHeader2});
            this.lv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.lv.Location = new System.Drawing.Point(24, 98);
            this.lv.Name = "lv";
            this.lv.ShowGroups = false;
            this.lv.Size = new System.Drawing.Size(538, 261);
            this.lv.TabIndex = 3;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // colHeader1
            // 
            this.colHeader1.Text = "进程名称";
            this.colHeader1.Width = 118;
            // 
            // colHeader2
            // 
            this.colHeader2.Text = "进程窗口标题";
            this.colHeader2.Width = 117;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logBox.Location = new System.Drawing.Point(305, 9);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(257, 68);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 371);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.colorBtn);
            this.Name = "Form1";
            this.Text = "内存监视的东东";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader colHeader1;
        private System.Windows.Forms.ColumnHeader colHeader2;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.RichTextBox logBox;
    }
}

