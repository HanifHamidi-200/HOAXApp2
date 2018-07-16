namespace HOAXManipulater
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
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.btnOpen4 = new System.Windows.Forms.Button();
            this.btnOpenR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen1.Location = new System.Drawing.Point(62, 62);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(222, 52);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.Text = "AskAI";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen2.Location = new System.Drawing.Point(62, 120);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(282, 45);
            this.btnOpen2.TabIndex = 1;
            this.btnOpen2.Text = "NotepadOrganiser";
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // btnOpen3
            // 
            this.btnOpen3.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen3.Location = new System.Drawing.Point(62, 171);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(282, 45);
            this.btnOpen3.TabIndex = 2;
            this.btnOpen3.Text = "PuzzlesRandom";
            this.btnOpen3.UseVisualStyleBackColor = false;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen3_Click);
            // 
            // btnOpen4
            // 
            this.btnOpen4.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen4.Location = new System.Drawing.Point(62, 222);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(282, 45);
            this.btnOpen4.TabIndex = 3;
            this.btnOpen4.Text = "AnimationRedraw";
            this.btnOpen4.UseVisualStyleBackColor = false;
            this.btnOpen4.Click += new System.EventHandler(this.btnOpen4_Click);
            // 
            // btnOpenR
            // 
            this.btnOpenR.BackColor = System.Drawing.Color.Red;
            this.btnOpenR.Location = new System.Drawing.Point(290, 62);
            this.btnOpenR.Name = "btnOpenR";
            this.btnOpenR.Size = new System.Drawing.Size(54, 52);
            this.btnOpenR.TabIndex = 4;
            this.btnOpenR.Text = "R";
            this.btnOpenR.UseVisualStyleBackColor = false;
            this.btnOpenR.Click += new System.EventHandler(this.btnOpenR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenR);
            this.Controls.Add(this.btnOpen4);
            this.Controls.Add(this.btnOpen3);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen1);
            this.Name = "Form1";
            this.Text = "HOAXManipulater";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.Button btnOpenR;
    }
}

