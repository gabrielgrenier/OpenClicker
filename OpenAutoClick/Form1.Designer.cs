﻿namespace OpenAutoClick
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.numMinTime = new System.Windows.Forms.NumericUpDown();
            this.numMaxTime = new System.Windows.Forms.NumericUpDown();
            this.labMinTime = new System.Windows.Forms.Label();
            this.labMaxTime = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labAQP = new System.Windows.Forms.Label();
            this.labW = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkRandomMouse = new System.Windows.Forms.CheckBox();
            this.labMaxDistance = new System.Windows.Forms.Label();
            this.numMaxDistance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMinTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // numMinTime
            // 
            this.numMinTime.Location = new System.Drawing.Point(14, 130);
            this.numMinTime.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numMinTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinTime.Name = "numMinTime";
            this.numMinTime.Size = new System.Drawing.Size(120, 20);
            this.numMinTime.TabIndex = 1;
            this.numMinTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinTime.ValueChanged += new System.EventHandler(this.numMinTime_ValueChanged);
            // 
            // numMaxTime
            // 
            this.numMaxTime.Location = new System.Drawing.Point(149, 130);
            this.numMaxTime.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numMaxTime.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numMaxTime.Name = "numMaxTime";
            this.numMaxTime.Size = new System.Drawing.Size(120, 20);
            this.numMaxTime.TabIndex = 2;
            this.numMaxTime.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numMaxTime.ValueChanged += new System.EventHandler(this.numMaxTime_ValueChanged);
            // 
            // labMinTime
            // 
            this.labMinTime.AutoSize = true;
            this.labMinTime.Font = new System.Drawing.Font("RuneScape UF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMinTime.ForeColor = System.Drawing.Color.Yellow;
            this.labMinTime.Location = new System.Drawing.Point(10, 106);
            this.labMinTime.Name = "labMinTime";
            this.labMinTime.Size = new System.Drawing.Size(113, 21);
            this.labMinTime.TabIndex = 4;
            this.labMinTime.Text = "Min Time (ms)";
            // 
            // labMaxTime
            // 
            this.labMaxTime.AutoSize = true;
            this.labMaxTime.Font = new System.Drawing.Font("RuneScape UF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaxTime.ForeColor = System.Drawing.Color.Yellow;
            this.labMaxTime.Location = new System.Drawing.Point(145, 106);
            this.labMaxTime.Name = "labMaxTime";
            this.labMaxTime.Size = new System.Drawing.Size(118, 21);
            this.labMaxTime.TabIndex = 5;
            this.labMaxTime.Text = "Max Time (ms)";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("RuneScape UF", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.Yellow;
            this.labTitle.Location = new System.Drawing.Point(3, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(300, 64);
            this.labTitle.TabIndex = 6;
            this.labTitle.Text = "OpenClicker";
            // 
            // labAQP
            // 
            this.labAQP.AutoSize = true;
            this.labAQP.Font = new System.Drawing.Font("RuneScape UF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAQP.ForeColor = System.Drawing.Color.Yellow;
            this.labAQP.Location = new System.Drawing.Point(10, 241);
            this.labAQP.Name = "labAQP";
            this.labAQP.Size = new System.Drawing.Size(55, 21);
            this.labAQP.TabIndex = 7;
            this.labAQP.Text = "a  q  p";
            // 
            // labW
            // 
            this.labW.AutoSize = true;
            this.labW.Font = new System.Drawing.Font("RuneScape UF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labW.ForeColor = System.Drawing.Color.Yellow;
            this.labW.Location = new System.Drawing.Point(34, 261);
            this.labW.Name = "labW";
            this.labW.Size = new System.Drawing.Size(24, 21);
            this.labW.TabIndex = 8;
            this.labW.Text = "W";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 176);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // checkRandomMouse
            // 
            this.checkRandomMouse.AutoSize = true;
            this.checkRandomMouse.Font = new System.Drawing.Font("RuneScape UF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRandomMouse.ForeColor = System.Drawing.Color.Yellow;
            this.checkRandomMouse.Location = new System.Drawing.Point(14, 157);
            this.checkRandomMouse.Name = "checkRandomMouse";
            this.checkRandomMouse.Size = new System.Drawing.Size(161, 20);
            this.checkRandomMouse.TabIndex = 10;
            this.checkRandomMouse.Text = "Random mouse position";
            this.checkRandomMouse.UseVisualStyleBackColor = true;
            this.checkRandomMouse.CheckedChanged += new System.EventHandler(this.checkRandomMouse_CheckedChanged);
            // 
            // labMaxDistance
            // 
            this.labMaxDistance.AutoSize = true;
            this.labMaxDistance.Font = new System.Drawing.Font("RuneScape UF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaxDistance.ForeColor = System.Drawing.Color.Yellow;
            this.labMaxDistance.Location = new System.Drawing.Point(14, 184);
            this.labMaxDistance.Name = "labMaxDistance";
            this.labMaxDistance.Size = new System.Drawing.Size(154, 21);
            this.labMaxDistance.TabIndex = 11;
            this.labMaxDistance.Text = "Max distance (Px) :";
            // 
            // numMaxDistance
            // 
            this.numMaxDistance.Location = new System.Drawing.Point(18, 208);
            this.numMaxDistance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numMaxDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxDistance.Name = "numMaxDistance";
            this.numMaxDistance.Size = new System.Drawing.Size(116, 20);
            this.numMaxDistance.TabIndex = 12;
            this.numMaxDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(296, 291);
            this.Controls.Add(this.numMaxDistance);
            this.Controls.Add(this.labMaxDistance);
            this.Controls.Add(this.checkRandomMouse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labW);
            this.Controls.Add(this.labAQP);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labMaxTime);
            this.Controls.Add(this.labMinTime);
            this.Controls.Add(this.numMaxTime);
            this.Controls.Add(this.numMinTime);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OpenClicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numMinTime;
        private System.Windows.Forms.NumericUpDown numMaxTime;
        private System.Windows.Forms.Label labMinTime;
        private System.Windows.Forms.Label labMaxTime;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labAQP;
        private System.Windows.Forms.Label labW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkRandomMouse;
        private System.Windows.Forms.Label labMaxDistance;
        private System.Windows.Forms.NumericUpDown numMaxDistance;
    }
}

