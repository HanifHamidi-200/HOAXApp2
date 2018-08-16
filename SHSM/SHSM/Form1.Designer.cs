namespace SHSM
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
            this.btnPoll = new System.Windows.Forms.ToolStripButton();
            this.btnPolsk = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Fuchsia;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPoll,
            this.btnPolsk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPoll
            // 
            this.btnPoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPoll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPoll.Image = ((System.Drawing.Image)(resources.GetObject("btnPoll.Image")));
            this.btnPoll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPoll.Name = "btnPoll";
            this.btnPoll.Size = new System.Drawing.Size(47, 22);
            this.btnPoll.Text = "POLL()";
            // 
            // btnPolsk
            // 
            this.btnPolsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPolsk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPolsk.Image = ((System.Drawing.Image)(resources.GetObject("btnPolsk.Image")));
            this.btnPolsk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPolsk.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnPolsk.Name = "btnPolsk";
            this.btnPolsk.Size = new System.Drawing.Size(55, 22);
            this.btnPolsk.Text = "POLSK()";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "SHSM";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPoll;
        private System.Windows.Forms.ToolStripButton btnPolsk;
    }
}

