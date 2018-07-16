namespace GoldMining
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
            this.btna1 = new System.Windows.Forms.Button();
            this.btna2 = new System.Windows.Forms.Button();
            this.btna3 = new System.Windows.Forms.Button();
            this.btnb3 = new System.Windows.Forms.Button();
            this.btnb2 = new System.Windows.Forms.Button();
            this.btnb1 = new System.Windows.Forms.Button();
            this.btnb4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btna1
            // 
            this.btna1.BackColor = System.Drawing.Color.Yellow;
            this.btna1.Location = new System.Drawing.Point(48, 85);
            this.btna1.Name = "btna1";
            this.btna1.Size = new System.Drawing.Size(139, 66);
            this.btna1.TabIndex = 0;
            this.btna1.Text = "Rice";
            this.btna1.UseVisualStyleBackColor = false;
            this.btna1.Click += new System.EventHandler(this.btna1_Click);
            // 
            // btna2
            // 
            this.btna2.BackColor = System.Drawing.Color.Yellow;
            this.btna2.Location = new System.Drawing.Point(209, 85);
            this.btna2.Name = "btna2";
            this.btna2.Size = new System.Drawing.Size(139, 66);
            this.btna2.TabIndex = 1;
            this.btna2.Text = "(Flour)";
            this.btna2.UseVisualStyleBackColor = false;
            this.btna2.Click += new System.EventHandler(this.btna2_Click);
            // 
            // btna3
            // 
            this.btna3.BackColor = System.Drawing.Color.Yellow;
            this.btna3.Location = new System.Drawing.Point(368, 85);
            this.btna3.Name = "btna3";
            this.btna3.Size = new System.Drawing.Size(139, 66);
            this.btna3.TabIndex = 2;
            this.btna3.Text = "Crops";
            this.btna3.UseVisualStyleBackColor = false;
            this.btna3.Click += new System.EventHandler(this.btna3_Click);
            // 
            // btnb3
            // 
            this.btnb3.BackColor = System.Drawing.Color.Yellow;
            this.btnb3.Location = new System.Drawing.Point(368, 196);
            this.btnb3.Name = "btnb3";
            this.btnb3.Size = new System.Drawing.Size(139, 66);
            this.btnb3.TabIndex = 5;
            this.btnb3.Text = "Gems";
            this.btnb3.UseVisualStyleBackColor = false;
            this.btnb3.Click += new System.EventHandler(this.btnb3_Click);
            // 
            // btnb2
            // 
            this.btnb2.BackColor = System.Drawing.Color.Yellow;
            this.btnb2.Location = new System.Drawing.Point(209, 196);
            this.btnb2.Name = "btnb2";
            this.btnb2.Size = new System.Drawing.Size(139, 66);
            this.btnb2.TabIndex = 4;
            this.btnb2.Text = "Rocks";
            this.btnb2.UseVisualStyleBackColor = false;
            this.btnb2.Click += new System.EventHandler(this.btnb2_Click);
            // 
            // btnb1
            // 
            this.btnb1.BackColor = System.Drawing.Color.Yellow;
            this.btnb1.Location = new System.Drawing.Point(48, 196);
            this.btnb1.Name = "btnb1";
            this.btnb1.Size = new System.Drawing.Size(139, 66);
            this.btnb1.TabIndex = 3;
            this.btnb1.Text = "Oil";
            this.btnb1.UseVisualStyleBackColor = false;
            this.btnb1.Click += new System.EventHandler(this.btnb1_Click);
            // 
            // btnb4
            // 
            this.btnb4.BackColor = System.Drawing.Color.Yellow;
            this.btnb4.Location = new System.Drawing.Point(534, 196);
            this.btnb4.Name = "btnb4";
            this.btnb4.Size = new System.Drawing.Size(139, 66);
            this.btnb4.TabIndex = 6;
            this.btnb4.Text = "(Gold)";
            this.btnb4.UseVisualStyleBackColor = false;
            this.btnb4.Click += new System.EventHandler(this.btnb4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnb4);
            this.Controls.Add(this.btnb3);
            this.Controls.Add(this.btnb2);
            this.Controls.Add(this.btnb1);
            this.Controls.Add(this.btna3);
            this.Controls.Add(this.btna2);
            this.Controls.Add(this.btna1);
            this.Name = "Form1";
            this.Text = "GoldMining";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btna1;
        private System.Windows.Forms.Button btna2;
        private System.Windows.Forms.Button btna3;
        private System.Windows.Forms.Button btnb3;
        private System.Windows.Forms.Button btnb2;
        private System.Windows.Forms.Button btnb1;
        private System.Windows.Forms.Button btnb4;
    }
}

