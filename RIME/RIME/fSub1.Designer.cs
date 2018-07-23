namespace RIME
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.txtAnswer1 = new System.Windows.Forms.RichTextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.btnQNext = new System.Windows.Forms.Button();
            this.txtTypos2 = new System.Windows.Forms.TextBox();
            this.txtTypos1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Location = new System.Drawing.Point(145, 245);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 15);
            this.lblScore.TabIndex = 24;
            this.lblScore.Text = "Score = 0";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecord.Location = new System.Drawing.Point(37, 245);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(88, 15);
            this.lblRecord.TabIndex = 23;
            this.lblRecord.Text = "RECORD = [0,0]";
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(126, 37);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(191, 58);
            this.txtAnswer1.TabIndex = 22;
            this.txtAnswer1.Text = "";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(579, 111);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(191, 20);
            this.txtDatabase.TabIndex = 21;
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(579, 60);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(145, 45);
            this.btnDatabase.TabIndex = 20;
            this.btnDatabase.Text = "ChooseDatabase";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnQNext
            // 
            this.btnQNext.Location = new System.Drawing.Point(403, 60);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(88, 45);
            this.btnQNext.TabIndex = 19;
            this.btnQNext.Text = "QNext";
            this.btnQNext.UseVisualStyleBackColor = true;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // txtTypos2
            // 
            this.txtTypos2.Location = new System.Drawing.Point(323, 162);
            this.txtTypos2.Name = "txtTypos2";
            this.txtTypos2.Size = new System.Drawing.Size(191, 20);
            this.txtTypos2.TabIndex = 18;
            // 
            // txtTypos1
            // 
            this.txtTypos1.BackColor = System.Drawing.Color.Yellow;
            this.txtTypos1.Location = new System.Drawing.Point(126, 162);
            this.txtTypos1.Name = "txtTypos1";
            this.txtTypos1.Size = new System.Drawing.Size(191, 20);
            this.txtTypos1.TabIndex = 17;
            this.txtTypos1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTypos1_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Typos";
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(126, 111);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(191, 20);
            this.txtAnswer2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ProgressAnswer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "RealAnswer";
            // 
            // fSub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.txtTypos2);
            this.Controls.Add(this.txtTypos1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fSub1";
            this.Text = "TypingTuter";
            this.Load += new System.EventHandler(this.fSub1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.RichTextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.TextBox txtTypos2;
        private System.Windows.Forms.TextBox txtTypos1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}