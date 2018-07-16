namespace ParametersBox
{
    partial class Form1
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
            this.lst1 = new System.Windows.Forms.TreeView();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnQNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.Location = new System.Drawing.Point(64, 62);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(482, 274);
            this.lst1.TabIndex = 0;
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(596, 111);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(108, 37);
            this.btnExpand.TabIndex = 1;
            this.btnExpand.Text = "&Expand";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnQNext
            // 
            this.btnQNext.Location = new System.Drawing.Point(596, 62);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(108, 37);
            this.btnQNext.TabIndex = 2;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = true;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.lst1);
            this.Name = "Form1";
            this.Text = "ParametersBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView lst1;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnQNext;
    }
}

