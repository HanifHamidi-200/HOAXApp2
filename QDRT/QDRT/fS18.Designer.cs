﻿namespace QDRT
{
    partial class fS18
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
            this.lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Items.AddRange(new object[] {
            "Railway needs to be mended",
            "TrainStation needs to be painted (railings)",
            "PortGoods needs to be delivered (house -> port)",
            "BercureBridge designs need to be submitted",
            "OflexTower designs need to be submitted"});
            this.lst1.Location = new System.Drawing.Point(87, 111);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(457, 238);
            this.lst1.TabIndex = 1;
            // 
            // fS18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst1);
            this.Name = "fS18";
            this.Text = "P_TRACK";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
    }
}