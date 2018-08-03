namespace RMND
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoard = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPile = new System.Windows.Forms.ListBox();
            this.btnTNext = new System.Windows.Forms.Button();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.btnSee = new System.Windows.Forms.Button();
            this.lstBoard2 = new System.Windows.Forms.ListBox();
            this.btnQNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board:-";
            // 
            // lstBoard
            // 
            this.lstBoard.FormattingEnabled = true;
            this.lstBoard.Location = new System.Drawing.Point(47, 72);
            this.lstBoard.Name = "lstBoard";
            this.lstBoard.Size = new System.Drawing.Size(254, 121);
            this.lstBoard.TabIndex = 1;
            this.lstBoard.Click += new System.EventHandler(this.lstBoard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CardsInPile:-";
            this.label2.Visible = false;
            // 
            // lstPile
            // 
            this.lstPile.FormattingEnabled = true;
            this.lstPile.Location = new System.Drawing.Point(596, 45);
            this.lstPile.Name = "lstPile";
            this.lstPile.Size = new System.Drawing.Size(172, 316);
            this.lstPile.TabIndex = 3;
            this.lstPile.Visible = false;
            // 
            // btnTNext
            // 
            this.btnTNext.BackColor = System.Drawing.Color.Yellow;
            this.btnTNext.Location = new System.Drawing.Point(160, 224);
            this.btnTNext.Name = "btnTNext";
            this.btnTNext.Size = new System.Drawing.Size(107, 55);
            this.btnTNext.TabIndex = 4;
            this.btnTNext.Text = "&TNext";
            this.btnTNext.UseVisualStyleBackColor = false;
            this.btnTNext.Click += new System.EventHandler(this.btnTNext_Click);
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCol.Location = new System.Drawing.Point(50, 297);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(67, 15);
            this.lblCol.TabIndex = 5;
            this.lblCol.Text = "mnCol (/4) =";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRow.Location = new System.Drawing.Point(50, 325);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(74, 15);
            this.lblRow.TabIndex = 6;
            this.lblRow.Text = "mnRow (/8) =";
            // 
            // txtRow
            // 
            this.txtRow.BackColor = System.Drawing.Color.Yellow;
            this.txtRow.Location = new System.Drawing.Point(142, 324);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(50, 20);
            this.txtRow.TabIndex = 7;
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(217, 321);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(84, 40);
            this.btnSee.TabIndex = 8;
            this.btnSee.Text = "&See";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // lstBoard2
            // 
            this.lstBoard2.FormattingEnabled = true;
            this.lstBoard2.Location = new System.Drawing.Point(307, 72);
            this.lstBoard2.Name = "lstBoard2";
            this.lstBoard2.Size = new System.Drawing.Size(254, 121);
            this.lstBoard2.TabIndex = 9;
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.Yellow;
            this.btnQNext.Location = new System.Drawing.Point(47, 224);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(107, 55);
            this.btnQNext.TabIndex = 10;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.lblSecond);
            this.groupBox1.Controls.Add(this.lblFirst);
            this.groupBox1.Controls.Add(this.btnSecond);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Location = new System.Drawing.Point(50, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ChoosePair";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(257, 75);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(105, 40);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecond.Location = new System.Drawing.Point(184, 89);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(31, 15);
            this.lblSecond.TabIndex = 12;
            this.lblSecond.Text = "Card";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirst.Location = new System.Drawing.Point(184, 43);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(31, 15);
            this.lblFirst.TabIndex = 11;
            this.lblFirst.Text = "Card";
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(20, 75);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(141, 40);
            this.btnSecond.TabIndex = 10;
            this.btnSecond.Text = "Select as second card";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click_1);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(20, 29);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(141, 40);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "Select as first card";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click_1);
            // 
            // fSub2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.lstBoard2);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.btnTNext);
            this.Controls.Add(this.lstPile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBoard);
            this.Controls.Add(this.label1);
            this.Name = "fSub2";
            this.Text = "fSub2";
            this.Load += new System.EventHandler(this.fSub2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPile;
        private System.Windows.Forms.Button btnTNext;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.ListBox lstBoard2;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Button btnCheck;
    }
}