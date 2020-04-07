namespace OpenAutoClick
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
            this.txtStartKey = new System.Windows.Forms.TextBox();
            this.txtEndKey = new System.Windows.Forms.TextBox();
            this.labStartKey = new System.Windows.Forms.Label();
            this.labEndKey = new System.Windows.Forms.Label();
            this.btnSetStartKey = new System.Windows.Forms.Button();
            this.labPressStartKey = new System.Windows.Forms.Label();
            this.btnSetEndKey = new System.Windows.Forms.Button();
            this.labPressEndKey = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
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
            this.labTitle.Location = new System.Drawing.Point(143, 9);
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
            this.labAQP.Location = new System.Drawing.Point(388, 251);
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
            this.labW.Location = new System.Drawing.Point(412, 272);
            this.labW.Name = "labW";
            this.labW.Size = new System.Drawing.Size(24, 21);
            this.labW.TabIndex = 8;
            this.labW.Text = "W";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 184);
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
            // txtStartKey
            // 
            this.txtStartKey.Location = new System.Drawing.Point(322, 130);
            this.txtStartKey.Name = "txtStartKey";
            this.txtStartKey.Size = new System.Drawing.Size(100, 20);
            this.txtStartKey.TabIndex = 13;
            this.txtStartKey.Text = "Insert";
            this.txtStartKey.TextChanged += new System.EventHandler(this.txtStartKey_TextChanged);
            // 
            // txtEndKey
            // 
            this.txtEndKey.Location = new System.Drawing.Point(440, 130);
            this.txtEndKey.Name = "txtEndKey";
            this.txtEndKey.Size = new System.Drawing.Size(100, 20);
            this.txtEndKey.TabIndex = 14;
            this.txtEndKey.Text = "Delete";
            this.txtEndKey.TextChanged += new System.EventHandler(this.txtEndKey_TextChanged);
            // 
            // labStartKey
            // 
            this.labStartKey.AutoSize = true;
            this.labStartKey.Font = new System.Drawing.Font("RuneScape UF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStartKey.ForeColor = System.Drawing.Color.Yellow;
            this.labStartKey.Location = new System.Drawing.Point(318, 106);
            this.labStartKey.Name = "labStartKey";
            this.labStartKey.Size = new System.Drawing.Size(83, 21);
            this.labStartKey.TabIndex = 15;
            this.labStartKey.Text = "Start key";
            // 
            // labEndKey
            // 
            this.labEndKey.AutoSize = true;
            this.labEndKey.Font = new System.Drawing.Font("RuneScape UF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEndKey.ForeColor = System.Drawing.Color.Yellow;
            this.labEndKey.Location = new System.Drawing.Point(436, 106);
            this.labEndKey.Name = "labEndKey";
            this.labEndKey.Size = new System.Drawing.Size(68, 21);
            this.labEndKey.TabIndex = 16;
            this.labEndKey.Text = "End key";
            // 
            // btnSetStartKey
            // 
            this.btnSetStartKey.Location = new System.Drawing.Point(322, 153);
            this.btnSetStartKey.Name = "btnSetStartKey";
            this.btnSetStartKey.Size = new System.Drawing.Size(32, 23);
            this.btnSetStartKey.TabIndex = 17;
            this.btnSetStartKey.Text = "Set";
            this.btnSetStartKey.UseVisualStyleBackColor = true;
            this.btnSetStartKey.Click += new System.EventHandler(this.btnSetStartKey_Click);
            // 
            // labPressStartKey
            // 
            this.labPressStartKey.AutoSize = true;
            this.labPressStartKey.Font = new System.Drawing.Font("RuneScape UF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressStartKey.ForeColor = System.Drawing.Color.Lime;
            this.labPressStartKey.Location = new System.Drawing.Point(356, 159);
            this.labPressStartKey.Name = "labPressStartKey";
            this.labPressStartKey.Size = new System.Drawing.Size(76, 13);
            this.labPressStartKey.TabIndex = 18;
            this.labPressStartKey.Text = "Press a key . . .";
            // 
            // btnSetEndKey
            // 
            this.btnSetEndKey.Location = new System.Drawing.Point(440, 154);
            this.btnSetEndKey.Name = "btnSetEndKey";
            this.btnSetEndKey.Size = new System.Drawing.Size(32, 23);
            this.btnSetEndKey.TabIndex = 19;
            this.btnSetEndKey.Text = "Set";
            this.btnSetEndKey.UseVisualStyleBackColor = true;
            this.btnSetEndKey.Click += new System.EventHandler(this.btnSetEndKey_Click);
            // 
            // labPressEndKey
            // 
            this.labPressEndKey.AutoSize = true;
            this.labPressEndKey.Font = new System.Drawing.Font("RuneScape UF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressEndKey.ForeColor = System.Drawing.Color.Lime;
            this.labPressEndKey.Location = new System.Drawing.Point(474, 159);
            this.labPressEndKey.Name = "labPressEndKey";
            this.labPressEndKey.Size = new System.Drawing.Size(76, 13);
            this.labPressEndKey.TabIndex = 20;
            this.labPressEndKey.Text = "Press a key . . .";
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.LinkColor = System.Drawing.Color.Yellow;
            this.linkGithub.Location = new System.Drawing.Point(11, 288);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(189, 13);
            this.linkGithub.TabIndex = 21;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Click here to visit OpenClicker\'s Github";
            this.linkGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(571, 310);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.labPressEndKey);
            this.Controls.Add(this.btnSetEndKey);
            this.Controls.Add(this.labPressStartKey);
            this.Controls.Add(this.btnSetStartKey);
            this.Controls.Add(this.labEndKey);
            this.Controls.Add(this.labStartKey);
            this.Controls.Add(this.txtEndKey);
            this.Controls.Add(this.txtStartKey);
            this.Controls.Add(this.labAQP);
            this.Controls.Add(this.numMaxDistance);
            this.Controls.Add(this.labMaxDistance);
            this.Controls.Add(this.checkRandomMouse);
            this.Controls.Add(this.labW);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labMaxTime);
            this.Controls.Add(this.labMinTime);
            this.Controls.Add(this.numMaxTime);
            this.Controls.Add(this.numMinTime);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.TextBox txtStartKey;
        private System.Windows.Forms.TextBox txtEndKey;
        private System.Windows.Forms.Label labStartKey;
        private System.Windows.Forms.Label labEndKey;
        private System.Windows.Forms.Button btnSetStartKey;
        private System.Windows.Forms.Label labPressStartKey;
        private System.Windows.Forms.Button btnSetEndKey;
        private System.Windows.Forms.Label labPressEndKey;
        private System.Windows.Forms.LinkLabel linkGithub;
    }
}

