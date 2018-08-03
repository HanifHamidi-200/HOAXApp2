namespace RMND
{
    partial class fSub1
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
            this.btnQNext = new System.Windows.Forms.Button();
            this.txtShow2 = new System.Windows.Forms.TextBox();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.lstShow2 = new System.Windows.Forms.ListBox();
            this.txtShow1 = new System.Windows.Forms.TextBox();
            this.btnShow1 = new System.Windows.Forms.Button();
            this.lstShow1 = new System.Windows.Forms.ListBox();
            this.btnSee = new System.Windows.Forms.Button();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblPuzzle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCount1 = new System.Windows.Forms.Button();
            this.btnCount2 = new System.Windows.Forms.Button();
            this.btnCount3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQNext
            // 
            this.btnQNext.Location = new System.Drawing.Point(33, 24);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(130, 32);
            this.btnQNext.TabIndex = 13;
            this.btnQNext.Text = "QNext";
            this.btnQNext.UseVisualStyleBackColor = true;
            // 
            // txtShow2
            // 
            this.txtShow2.BackColor = System.Drawing.Color.Yellow;
            this.txtShow2.Location = new System.Drawing.Point(477, 55);
            this.txtShow2.Name = "txtShow2";
            this.txtShow2.Size = new System.Drawing.Size(73, 20);
            this.txtShow2.TabIndex = 12;
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(341, 55);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(130, 32);
            this.btnShow2.TabIndex = 11;
            this.btnShow2.Text = "Show 1/1";
            this.btnShow2.UseVisualStyleBackColor = true;
            // 
            // lstShow2
            // 
            this.lstShow2.FormattingEnabled = true;
            this.lstShow2.Location = new System.Drawing.Point(341, 100);
            this.lstShow2.Name = "lstShow2";
            this.lstShow2.Size = new System.Drawing.Size(257, 147);
            this.lstShow2.TabIndex = 10;
            this.lstShow2.Click += new System.EventHandler(this.lstShow2_Click);
            // 
            // txtShow1
            // 
            this.txtShow1.BackColor = System.Drawing.Color.Yellow;
            this.txtShow1.Location = new System.Drawing.Point(169, 62);
            this.txtShow1.Name = "txtShow1";
            this.txtShow1.Size = new System.Drawing.Size(73, 20);
            this.txtShow1.TabIndex = 9;
            // 
            // btnShow1
            // 
            this.btnShow1.Location = new System.Drawing.Point(33, 62);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(130, 32);
            this.btnShow1.TabIndex = 8;
            this.btnShow1.Text = "Show 1/1";
            this.btnShow1.UseVisualStyleBackColor = true;
            // 
            // lstShow1
            // 
            this.lstShow1.FormattingEnabled = true;
            this.lstShow1.Location = new System.Drawing.Point(33, 100);
            this.lstShow1.Name = "lstShow1";
            this.lstShow1.Size = new System.Drawing.Size(257, 147);
            this.lstShow1.TabIndex = 7;
            this.lstShow1.Click += new System.EventHandler(this.lstShow1_Click);
            this.lstShow1.SelectedIndexChanged += new System.EventHandler(this.lstShow1_SelectedIndexChanged);
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(200, 318);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(84, 40);
            this.btnSee.TabIndex = 17;
            this.btnSee.Text = "&See";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // txtRow
            // 
            this.txtRow.BackColor = System.Drawing.Color.Yellow;
            this.txtRow.Location = new System.Drawing.Point(125, 321);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(50, 20);
            this.txtRow.TabIndex = 16;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRow.Location = new System.Drawing.Point(33, 322);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(74, 15);
            this.lblRow.TabIndex = 15;
            this.lblRow.Text = "mnRow (/9) =";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCol.Location = new System.Drawing.Point(33, 294);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(67, 15);
            this.lblCol.TabIndex = 14;
            this.lblCol.Text = "mnCol (/9) =";
            // 
            // lblPuzzle
            // 
            this.lblPuzzle.AutoSize = true;
            this.lblPuzzle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPuzzle.Location = new System.Drawing.Point(33, 267);
            this.lblPuzzle.Name = "lblPuzzle";
            this.lblPuzzle.Size = new System.Drawing.Size(83, 15);
            this.lblPuzzle.TabIndex = 18;
            this.lblPuzzle.Text = "mnPuzzle (/2) =";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnCount3);
            this.groupBox1.Controls.Add(this.btnCount2);
            this.groupBox1.Controls.Add(this.btnCount1);
            this.groupBox1.Location = new System.Drawing.Point(341, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 144);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Count";
            // 
            // btnCount1
            // 
            this.btnCount1.Location = new System.Drawing.Point(28, 30);
            this.btnCount1.Name = "btnCount1";
            this.btnCount1.Size = new System.Drawing.Size(129, 24);
            this.btnCount1.TabIndex = 18;
            this.btnCount1.Text = "CountAcross";
            this.btnCount1.UseVisualStyleBackColor = true;
            this.btnCount1.Click += new System.EventHandler(this.btnCount1_Click);
            // 
            // btnCount2
            // 
            this.btnCount2.Location = new System.Drawing.Point(28, 59);
            this.btnCount2.Name = "btnCount2";
            this.btnCount2.Size = new System.Drawing.Size(129, 24);
            this.btnCount2.TabIndex = 19;
            this.btnCount2.Text = "CountDown";
            this.btnCount2.UseVisualStyleBackColor = true;
            this.btnCount2.Click += new System.EventHandler(this.btnCount2_Click);
            // 
            // btnCount3
            // 
            this.btnCount3.Location = new System.Drawing.Point(28, 89);
            this.btnCount3.Name = "btnCount3";
            this.btnCount3.Size = new System.Drawing.Size(129, 24);
            this.btnCount3.TabIndex = 20;
            this.btnCount3.Text = "CountBox";
            this.btnCount3.UseVisualStyleBackColor = true;
            this.btnCount3.Click += new System.EventHandler(this.btnCount3_Click);
            // 
            // fSub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPuzzle);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.txtShow2);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.lstShow2);
            this.Controls.Add(this.txtShow1);
            this.Controls.Add(this.btnShow1);
            this.Controls.Add(this.lstShow1);
            this.Name = "fSub1";
            this.Text = "Count";
            this.Load += new System.EventHandler(this.fSub1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.TextBox txtShow2;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.ListBox lstShow2;
        private System.Windows.Forms.TextBox txtShow1;
        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.ListBox lstShow1;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblPuzzle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCount3;
        private System.Windows.Forms.Button btnCount2;
        private System.Windows.Forms.Button btnCount1;
    }
}