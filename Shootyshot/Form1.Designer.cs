namespace Shootyshot
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
            this.btnShot = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.LabelAI = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GameView = new System.Windows.Forms.ListBox();
            this.textBoxAmmoComputer = new System.Windows.Forms.TextBox();
            this.textBoxCompAction = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtPAmmo = new System.Windows.Forms.TextBox();
            this.txtPAction = new System.Windows.Forms.TextBox();
            this.BtnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShot
            // 
            this.btnShot.Location = new System.Drawing.Point(18, 248);
            this.btnShot.Margin = new System.Windows.Forms.Padding(4);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(153, 42);
            this.btnShot.TabIndex = 0;
            this.btnShot.Text = "Shoot";
            this.btnShot.UseVisualStyleBackColor = true;
            this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(18, 348);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(153, 42);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(18, 398);
            this.btnShotgun.Margin = new System.Windows.Forms.Padding(4);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(153, 42);
            this.btnShotgun.TabIndex = 3;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 133);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.Location = new System.Drawing.Point(91, 46);
            this.PlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(38, 18);
            this.PlayerLabel.TabIndex = 7;
            this.PlayerLabel.Text = "allan";
            // 
            // LabelAI
            // 
            this.LabelAI.AutoSize = true;
            this.LabelAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAI.Location = new System.Drawing.Point(947, 46);
            this.LabelAI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAI.Name = "LabelAI";
            this.LabelAI.Size = new System.Drawing.Size(20, 18);
            this.LabelAI.TabIndex = 8;
            this.LabelAI.Text = "Ai";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(964, 74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 133);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // GameView
            // 
            this.GameView.FormattingEnabled = true;
            this.GameView.ItemHeight = 18;
            this.GameView.Location = new System.Drawing.Point(301, 202);
            this.GameView.Name = "GameView";
            this.GameView.Size = new System.Drawing.Size(620, 238);
            this.GameView.TabIndex = 10;
            this.GameView.SelectedIndexChanged += new System.EventHandler(this.GameView_SelectedIndexChanged);
            // 
            // textBoxAmmoComputer
            // 
            this.textBoxAmmoComputer.Location = new System.Drawing.Point(843, 134);
            this.textBoxAmmoComputer.Name = "textBoxAmmoComputer";
            this.textBoxAmmoComputer.Size = new System.Drawing.Size(100, 24);
            this.textBoxAmmoComputer.TabIndex = 12;
            // 
            // textBoxCompAction
            // 
            this.textBoxCompAction.Location = new System.Drawing.Point(843, 94);
            this.textBoxCompAction.Name = "textBoxCompAction";
            this.textBoxCompAction.Size = new System.Drawing.Size(100, 24);
            this.textBoxCompAction.TabIndex = 13;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(18, 298);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(153, 42);
            this.btnReload.TabIndex = 14;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtPAmmo
            // 
            this.txtPAmmo.Location = new System.Drawing.Point(215, 154);
            this.txtPAmmo.Name = "txtPAmmo";
            this.txtPAmmo.Size = new System.Drawing.Size(100, 24);
            this.txtPAmmo.TabIndex = 11;
            this.txtPAmmo.TextChanged += new System.EventHandler(this.txtPAmmo_TextChanged);
            // 
            // txtPAction
            // 
            this.txtPAction.Location = new System.Drawing.Point(215, 94);
            this.txtPAction.Name = "txtPAction";
            this.txtPAction.Size = new System.Drawing.Size(100, 24);
            this.txtPAction.TabIndex = 11;
            this.txtPAction.TextChanged += new System.EventHandler(this.textBoxPlayerAction_TextChanged);
            // 
            // BtnRestart
            // 
            this.BtnRestart.Location = new System.Drawing.Point(1034, 568);
            this.BtnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(153, 42);
            this.BtnRestart.TabIndex = 15;
            this.BtnRestart.Text = "Restart";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.textBoxAmmoComputer);
            this.Controls.Add(this.textBoxCompAction);
            this.Controls.Add(this.txtPAction);
            this.Controls.Add(this.txtPAmmo);
            this.Controls.Add(this.GameView);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LabelAI);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnShot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label LabelAI;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox GameView;
        private System.Windows.Forms.TextBox textBoxAmmoComputer;
        private System.Windows.Forms.TextBox textBoxCompAction;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtPAmmo;
        private System.Windows.Forms.TextBox txtPAction;
        private System.Windows.Forms.Button BtnRestart;
    }
}

