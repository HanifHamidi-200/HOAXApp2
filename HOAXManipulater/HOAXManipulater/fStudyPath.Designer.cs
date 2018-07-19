namespace HOAXManipulater
{
    partial class fStudyPath
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
            this.lstChoose = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstChoose
            // 
            this.lstChoose.FormattingEnabled = true;
            this.lstChoose.Items.AddRange(new object[] {
            "[1] CornerStart, try4",
            "[2] CornerStart, try2",
            "[3] CornerStart, try7",
            "[4] CornerStart, try3",
            "[5] CornerStart, try5",
            "[6] CornerStart, try8",
            "[7] CornerStart, try6",
            "[8] CornerStart, try9",
            "[9] EdgeStart, try1",
            "[10] EdgeStart, try3",
            "[11] EdgeStart, try4",
            "[12] EdgeStart, try6",
            "[13] EdgeStart, try5",
            "[14] EdgeStart, try7",
            "[15] EdgeStart, try9",
            "[16] EdgeStart, try8",
            "[17] CornerStart, try1",
            "[18] CornerStart, try7",
            "[19] CornerStart, try9",
            "[20] CornerStart, try3",
            "[21] CornerStart, try2",
            "[22] CornerStart, try4",
            "[23] CornerStart, try8",
            "[24] CornerStart, try6"});
            this.lstChoose.Location = new System.Drawing.Point(37, 64);
            this.lstChoose.Name = "lstChoose";
            this.lstChoose.Size = new System.Drawing.Size(464, 264);
            this.lstChoose.TabIndex = 0;
            this.lstChoose.SelectedIndexChanged += new System.EventHandler(this.lstChoose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose:-";
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(568, 42);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(149, 52);
            this.btnRotate.TabIndex = 2;
            this.btnRotate.Text = "Rotate = 1";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(568, 211);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(149, 52);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // fStudyPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstChoose);
            this.Name = "fStudyPath";
            this.Text = "fStudyPath";
            this.Load += new System.EventHandler(this.fStudyPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnOK;
    }
}