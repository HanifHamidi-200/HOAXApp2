namespace PortNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picMars = new System.Windows.Forms.PictureBox();
            this.picSpain = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnPort1 = new System.Windows.Forms.Button();
            this.btnPort2 = new System.Windows.Forms.Button();
            this.btnPort3 = new System.Windows.Forms.Button();
            this.btnPort4 = new System.Windows.Forms.Button();
            this.btnPowerchip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // picMars
            // 
            this.picMars.Image = ((System.Drawing.Image)(resources.GetObject("picMars.Image")));
            this.picMars.Location = new System.Drawing.Point(32, 126);
            this.picMars.Name = "picMars";
            this.picMars.Size = new System.Drawing.Size(382, 228);
            this.picMars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMars.TabIndex = 0;
            this.picMars.TabStop = false;
            this.picMars.Visible = false;
            // 
            // picSpain
            // 
            this.picSpain.Image = ((System.Drawing.Image)(resources.GetObject("picSpain.Image")));
            this.picSpain.Location = new System.Drawing.Point(209, 111);
            this.picSpain.Name = "picSpain";
            this.picSpain.Size = new System.Drawing.Size(382, 228);
            this.picSpain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpain.TabIndex = 1;
            this.picSpain.TabStop = false;
            this.picSpain.Visible = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(47, 32);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(432, 393);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // btnPort1
            // 
            this.btnPort1.BackColor = System.Drawing.Color.Pink;
            this.btnPort1.Location = new System.Drawing.Point(542, 53);
            this.btnPort1.Name = "btnPort1";
            this.btnPort1.Size = new System.Drawing.Size(146, 58);
            this.btnPort1.TabIndex = 3;
            this.btnPort1.Text = "Port3000";
            this.btnPort1.UseVisualStyleBackColor = false;
            this.btnPort1.Click += new System.EventHandler(this.btnPort1_Click);
            // 
            // btnPort2
            // 
            this.btnPort2.BackColor = System.Drawing.Color.Pink;
            this.btnPort2.Location = new System.Drawing.Point(542, 135);
            this.btnPort2.Name = "btnPort2";
            this.btnPort2.Size = new System.Drawing.Size(146, 58);
            this.btnPort2.TabIndex = 4;
            this.btnPort2.Text = "Port8000";
            this.btnPort2.UseVisualStyleBackColor = false;
            this.btnPort2.Click += new System.EventHandler(this.btnPort2_Click);
            // 
            // btnPort3
            // 
            this.btnPort3.BackColor = System.Drawing.Color.Pink;
            this.btnPort3.Location = new System.Drawing.Point(542, 218);
            this.btnPort3.Name = "btnPort3";
            this.btnPort3.Size = new System.Drawing.Size(146, 58);
            this.btnPort3.TabIndex = 5;
            this.btnPort3.Text = "Port8500";
            this.btnPort3.UseVisualStyleBackColor = false;
            this.btnPort3.Click += new System.EventHandler(this.btnPort3_Click);
            // 
            // btnPort4
            // 
            this.btnPort4.BackColor = System.Drawing.Color.Pink;
            this.btnPort4.Location = new System.Drawing.Point(542, 296);
            this.btnPort4.Name = "btnPort4";
            this.btnPort4.Size = new System.Drawing.Size(146, 58);
            this.btnPort4.TabIndex = 6;
            this.btnPort4.Text = "Port8300";
            this.btnPort4.UseVisualStyleBackColor = false;
            this.btnPort4.Click += new System.EventHandler(this.btnPort4_Click);
            // 
            // btnPowerchip
            // 
            this.btnPowerchip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPowerchip.Location = new System.Drawing.Point(542, 375);
            this.btnPowerchip.Name = "btnPowerchip";
            this.btnPowerchip.Size = new System.Drawing.Size(246, 50);
            this.btnPowerchip.TabIndex = 7;
            this.btnPowerchip.Text = "goto PowerChip";
            this.btnPowerchip.UseVisualStyleBackColor = false;
            this.btnPowerchip.Click += new System.EventHandler(this.btnPowerchip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPowerchip);
            this.Controls.Add(this.btnPort4);
            this.Controls.Add(this.btnPort3);
            this.Controls.Add(this.btnPort2);
            this.Controls.Add(this.btnPort1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.picSpain);
            this.Controls.Add(this.picMars);
            this.Name = "Form1";
            this.Text = "PortNumber";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMars;
        private System.Windows.Forms.PictureBox picSpain;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnPort1;
        private System.Windows.Forms.Button btnPort2;
        private System.Windows.Forms.Button btnPort3;
        private System.Windows.Forms.Button btnPort4;
        private System.Windows.Forms.Button btnPowerchip;
    }
}

