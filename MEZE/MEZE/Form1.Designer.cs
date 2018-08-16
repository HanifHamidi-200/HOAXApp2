namespace MEZE
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRedraw = new System.Windows.Forms.ToolStripButton();
            this.btnIndex = new System.Windows.Forms.ToolStripButton();
            this.btnGenerate = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Fuchsia;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerate,
            this.btnIndex,
            this.btnRedraw});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRedraw
            // 
            this.btnRedraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRedraw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRedraw.Image = ((System.Drawing.Image)(resources.GetObject("btnRedraw.Image")));
            this.btnRedraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedraw.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(59, 22);
            this.btnRedraw.Text = "REDRAW";
            // 
            // btnIndex
            // 
            this.btnIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIndex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnIndex.Image = ((System.Drawing.Image)(resources.GetObject("btnIndex.Image")));
            this.btnIndex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIndex.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(45, 22);
            this.btnIndex.Text = "INDEX";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(67, 22);
            this.btnGenerate.Text = "GENERATE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "MEZE";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGenerate;
        private System.Windows.Forms.ToolStripButton btnIndex;
        private System.Windows.Forms.ToolStripButton btnRedraw;
    }
}

