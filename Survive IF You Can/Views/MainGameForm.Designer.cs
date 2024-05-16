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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            Player = new PictureBox();
            labelForAmmo = new Label();
            labelForScore = new Label();
            labelForHealth = new Label();
            PBforHealth = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            pauseLabel = new Label();
            levelLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.Image = Properties.Resources.BayraktarUP;
            Player.Location = new Point(653, 955);
            Player.Margin = new Padding(4, 5, 4, 5);
            Player.Name = "Player";
            Player.Size = new Size(177, 95);
            Player.SizeMode = PictureBoxSizeMode.AutoSize;
            Player.TabIndex = 0;
            Player.TabStop = false;
            Player.Tag = "player";
            // 
            // labelForAmmo
            // 
            labelForAmmo.AutoSize = true;
            labelForAmmo.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelForAmmo.ForeColor = Color.White;
            labelForAmmo.Location = new Point(17, 15);
            labelForAmmo.Margin = new Padding(4, 0, 4, 0);
            labelForAmmo.Name = "labelForAmmo";
            labelForAmmo.Size = new Size(152, 43);
            labelForAmmo.TabIndex = 2;
            labelForAmmo.Text = "Ammo: 0";
            // 
            // labelForScore
            // 
            labelForScore.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelForScore.AutoSize = true;
            labelForScore.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelForScore.ForeColor = Color.White;
            labelForScore.Location = new Point(569, 15);
            labelForScore.Margin = new Padding(4, 0, 4, 0);
            labelForScore.Name = "labelForScore";
            labelForScore.Size = new Size(171, 43);
            labelForScore.TabIndex = 3;
            labelForScore.Text = "Score: 0";
            // 
            // labelForHealth
            // 
            labelForHealth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelForHealth.AutoSize = true;
            labelForHealth.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelForHealth.ForeColor = Color.White;
            labelForHealth.Location = new Point(1121, 15);
            labelForHealth.Margin = new Padding(4, 0, 4, 0);
            labelForHealth.Name = "labelForHealth";
            labelForHealth.Size = new Size(171, 43);
            labelForHealth.TabIndex = 4;
            labelForHealth.Text = "Health: ";
            // 
            // PBforHealth
            // 
            PBforHealth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBforHealth.Location = new Point(1264, 23);
            PBforHealth.Margin = new Padding(4, 5, 4, 5);
            PBforHealth.Name = "PBforHealth";
            PBforHealth.Size = new Size(339, 38);
            PBforHealth.TabIndex = 5;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += GameEngine;
            // 
            // pauseLabel
            // 
            pauseLabel.AutoSize = true;
            pauseLabel.Location = new Point(701, 568);
            pauseLabel.Margin = new Padding(4, 0, 4, 0);
            pauseLabel.Name = "pauseLabel";
            pauseLabel.Size = new Size(0, 25);
            pauseLabel.TabIndex = 6;
            // 
            // levelLbl
            // 
            levelLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            levelLbl.AutoSize = true;
            levelLbl.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            levelLbl.ForeColor = Color.White;
            levelLbl.Location = new Point(306, 15);
            levelLbl.Margin = new Padding(4, 0, 4, 0);
            levelLbl.Name = "levelLbl";
            levelLbl.Size = new Size(171, 43);
            levelLbl.TabIndex = 7;
            levelLbl.Text = "Level: 1";
            // 
            // MainGameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1620, 1235);
            Controls.Add(levelLbl);
            Controls.Add(pauseLabel);
            Controls.Add(PBforHealth);
            Controls.Add(labelForHealth);
            Controls.Add(labelForScore);
            Controls.Add(labelForAmmo);
            Controls.Add(Player);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1633, 1263);
            Name = "MainGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Survive If You Can";
            FormClosing += MainGameForm_FormClosing;
            Load += MainGameForm_Load;
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            MouseDown += MainGameForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Player;
        private Label labelForAmmo;
        private Label labelForScore;
        private Label labelForHealth;
        private ProgressBar PBforHealth;
        private System.Windows.Forms.Timer timer;
        private Label pauseLabel;
        private Label levelLbl;
    }
}