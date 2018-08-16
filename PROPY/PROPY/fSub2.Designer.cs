namespace PROPY
{
    partial class fSub2
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
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Yellow;
            this.btn2.Location = new System.Drawing.Point(343, 54);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(105, 47);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "CUISE";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Yellow;
            this.btn1.Location = new System.Drawing.Point(51, 54);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(273, 206);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "FLAMB";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Yellow;
            this.btn3.Location = new System.Drawing.Point(343, 107);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(105, 47);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "COIL";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Yellow;
            this.btn5.Location = new System.Drawing.Point(343, 213);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(105, 47);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "FORN";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Yellow;
            this.btn4.Location = new System.Drawing.Point(343, 160);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(105, 47);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "LOOD";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // fSub2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(505, 360);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "fSub2";
            this.Text = "NWWS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
    }
}