namespace QWeather
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
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(167, 67);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.cityNameTextBox.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(318, 65);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(73, 119);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(41, 12);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入城市名:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.cityNameTextBox);
            this.Name = "Form1";
            this.Text = "QWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
    }
}

