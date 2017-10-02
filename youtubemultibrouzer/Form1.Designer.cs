namespace youtubemultibrouzer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Web1 = new System.Windows.Forms.WebBrowser();
            this.Web2 = new System.Windows.Forms.WebBrowser();
            this.Web3 = new System.Windows.Forms.WebBrowser();
            this.bwurl1 = new System.Windows.Forms.TextBox();
            this.bwurl2 = new System.Windows.Forms.TextBox();
            this.bwurl3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Web1
            // 
            this.Web1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Web1.Location = new System.Drawing.Point(0, 0);
            this.Web1.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web1.Name = "Web1";
            this.Web1.Size = new System.Drawing.Size(454, 546);
            this.Web1.TabIndex = 0;
            // 
            // Web2
            // 
            this.Web2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Web2.Location = new System.Drawing.Point(454, 0);
            this.Web2.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web2.Name = "Web2";
            this.Web2.Size = new System.Drawing.Size(450, 546);
            this.Web2.TabIndex = 1;
            // 
            // Web3
            // 
            this.Web3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Web3.Location = new System.Drawing.Point(904, 0);
            this.Web3.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web3.Name = "Web3";
            this.Web3.Size = new System.Drawing.Size(430, 546);
            this.Web3.TabIndex = 2;
            // 
            // bwurl1
            // 
            this.bwurl1.Location = new System.Drawing.Point(0, 2);
            this.bwurl1.Name = "bwurl1";
            this.bwurl1.Size = new System.Drawing.Size(436, 19);
            this.bwurl1.TabIndex = 9;
            this.bwurl1.TextChanged += new System.EventHandler(this.bwurl1_TextChanged);
            // 
            // bwurl2
            // 
            this.bwurl2.Location = new System.Drawing.Point(454, 2);
            this.bwurl2.Name = "bwurl2";
            this.bwurl2.Size = new System.Drawing.Size(436, 19);
            this.bwurl2.TabIndex = 10;
            this.bwurl2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bwurl2_KeyDown);
            // 
            // bwurl3
            // 
            this.bwurl3.Location = new System.Drawing.Point(904, 2);
            this.bwurl3.Name = "bwurl3";
            this.bwurl3.Size = new System.Drawing.Size(412, 19);
            this.bwurl3.TabIndex = 11;
            this.bwurl3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bwurl3_KeyDown);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1336, 546);
            this.Controls.Add(this.bwurl3);
            this.Controls.Add(this.bwurl2);
            this.Controls.Add(this.bwurl1);
            this.Controls.Add(this.Web3);
            this.Controls.Add(this.Web2);
            this.Controls.Add(this.Web1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.WebBrowser WB1;
        private System.Windows.Forms.WebBrowser WB2;
        private System.Windows.Forms.WebBrowser WE3;
        private System.Windows.Forms.TextBox br1url;
        private System.Windows.Forms.TextBox br2url;
        private System.Windows.Forms.TextBox br3url;
        private System.Windows.Forms.WebBrowser Web1;
        private System.Windows.Forms.WebBrowser Web2;
        private System.Windows.Forms.WebBrowser Web3;
        private System.Windows.Forms.TextBox bwurl1;
        private System.Windows.Forms.TextBox bwurl2;
        private System.Windows.Forms.TextBox bwurl3;
    }
}

