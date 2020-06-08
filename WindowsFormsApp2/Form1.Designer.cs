namespace WindowsFormsApp2
{
    partial class form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.choose = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.webB = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // choose
            // 
            resources.ApplyResources(this.choose, "choose");
            this.choose.Name = "choose";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // start
            // 
            resources.ApplyResources(this.start, "start");
            this.start.Name = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // text1
            // 
            resources.ApplyResources(this.text1, "text1");
            this.text1.Name = "text1";
            // 
            // webB
            // 
            resources.ApplyResources(this.webB, "webB");
            this.webB.Name = "webB";
            this.webB.Url = new System.Uri("https://www.opengps.cn/Map/Path/Index.aspx", System.UriKind.Absolute);
            // 
            // form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webB);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.choose);
            this.Name = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.WebBrowser webB;
    }
}

