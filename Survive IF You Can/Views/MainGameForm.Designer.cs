namespace Survive_IF_You_Can
{
    partial class MainGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MouseDown += new MouseEventHandler(MainGameForm_MouseDown);
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            this.Player = new System.Windows.Forms.PictureBox();
            this.labelForAmmo = new System.Windows.Forms.Label();
            this.labelForScore = new System.Windows.Forms.Label();
            this.labelForHealth = new System.Windows.Forms.Label();
            this.PBforHealth = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pauseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = global::Survive_IF_You_Can.Properties.Resources.BayraktarUP;
            this.Player.Location = new System.Drawing.Point(457, 573);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(177, 95);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Tag = "player";
            // 
            // labelForAmmo
            // 
            this.labelForAmmo.AutoSize = true;
            this.labelForAmmo.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForAmmo.ForeColor = System.Drawing.Color.White;
            this.labelForAmmo.Location = new System.Drawing.Point(12, 9);
            this.labelForAmmo.Name = "labelForAmmo";
            this.labelForAmmo.Size = new System.Drawing.Size(96, 28);
            this.labelForAmmo.TabIndex = 2;
            this.labelForAmmo.Text = "Ammo: 0";
            // 
            // labelForScore
            // 
            this.labelForScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForScore.AutoSize = true;
            this.labelForScore.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForScore.ForeColor = System.Drawing.Color.White;
            this.labelForScore.Location = new System.Drawing.Point(398, 9);
            this.labelForScore.Name = "labelForScore";
            this.labelForScore.Size = new System.Drawing.Size(108, 28);
            this.labelForScore.TabIndex = 3;
            this.labelForScore.Text = "Score: 0";
            // 
            // labelForHealth
            // 
            this.labelForHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForHealth.AutoSize = true;
            this.labelForHealth.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForHealth.ForeColor = System.Drawing.Color.White;
            this.labelForHealth.Location = new System.Drawing.Point(785, 9);
            this.labelForHealth.Name = "labelForHealth";
            this.labelForHealth.Size = new System.Drawing.Size(108, 28);
            this.labelForHealth.TabIndex = 4;
            this.labelForHealth.Text = "Health: ";
            // 
            // PBforHealth
            // 
            this.PBforHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBforHealth.Location = new System.Drawing.Point(885, 14);
            this.PBforHealth.Name = "PBforHealth";
            this.PBforHealth.Size = new System.Drawing.Size(237, 23);
            this.PBforHealth.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.GameEngine);
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Location = new System.Drawing.Point(491, 341);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(0, 15);
            this.pauseLabel.TabIndex = 6;
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1134, 741);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.PBforHealth);
            this.Controls.Add(this.labelForHealth);
            this.Controls.Add(this.labelForScore);
            this.Controls.Add(this.labelForAmmo);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1150, 780);
            this.Name = "MainGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survive If You Can";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGameForm_FormClosing);
            this.Load += new System.EventHandler(this.MainGameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Player;
        private Label labelForAmmo;
        private Label labelForScore;
        private Label labelForHealth;
        private ProgressBar PBforHealth;
        private System.Windows.Forms.Timer timer;
        private Label pauseLabel;
    }
}