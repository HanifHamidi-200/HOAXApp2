namespace BricksFMomentum
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
            this.btnOpen3b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen1.Location = new System.Drawing.Point(84, 56);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(214, 91);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.Text = "NuclearPowerPlant";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen2.Location = new System.Drawing.Point(84, 169);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(214, 91);
            this.btnOpen2.TabIndex = 1;
            this.btnOpen2.Text = "RobotsPackager";
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // btnOpen3
            // 
            this.btnOpen3.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen3.Location = new System.Drawing.Point(84, 281);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(214, 91);
            this.btnOpen3.TabIndex = 2;
            this.btnOpen3.Text = "FractionalDistillation";
            this.btnOpen3.UseVisualStyleBackColor = false;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen3_Click);
            // 
            // btnOpen4
            // 
            this.btnOpen4.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen4.Location = new System.Drawing.Point(84, 396);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(214, 91);
            this.btnOpen4.TabIndex = 3;
            this.btnOpen4.Text = "TestingGrounds";
            this.btnOpen4.UseVisualStyleBackColor = false;
            this.btnOpen4.Click += new System.EventHandler(this.btnOpen4_Click);
            // 
            // btnOpen3b
            // 
            this.btnOpen3b.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen3b.Location = new System.Drawing.Point(328, 281);
            this.btnOpen3b.Name = "btnOpen3b";
            this.btnOpen3b.Size = new System.Drawing.Size(98, 91);
            this.btnOpen3b.TabIndex = 4;
            this.btnOpen3b.Text = "Furnace";
            this.btnOpen3b.UseVisualStyleBackColor = false;
            this.btnOpen3b.Click += new System.EventHandler(this.btnOpen3b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.btnOpen3b);
            this.Controls.Add(this.btnOpen4);
            this.Controls.Add(this.btnOpen3);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen1);
            this.Name = "Form1";
            this.Text = "BricksFMomentum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.Button btnOpen3b;
    }
}

