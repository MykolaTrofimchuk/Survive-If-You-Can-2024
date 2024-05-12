namespace Survive_IF_You_Can
{
    partial class GameOverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverForm));
            this.TextLabel = new System.Windows.Forms.Label();
            this.ActualScoreLabel = new System.Windows.Forms.Label();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.TextLabel.Location = new System.Drawing.Point(34, 54);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(222, 40);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Гру закінчено!";
            // 
            // ActualScoreLabel
            // 
            this.ActualScoreLabel.AutoSize = true;
            this.ActualScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActualScoreLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ActualScoreLabel.Location = new System.Drawing.Point(46, 133);
            this.ActualScoreLabel.Name = "ActualScoreLabel";
            this.ActualScoreLabel.Size = new System.Drawing.Size(196, 32);
            this.ActualScoreLabel.TabIndex = 1;
            this.ActualScoreLabel.Text = "Ваш рахунок: 0";
            this.ActualScoreLabel.Click += new System.EventHandler(this.ActualScoreLabel_Click);
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RecordLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.RecordLabel.Location = new System.Drawing.Point(34, 149);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(0, 32);
            this.RecordLabel.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightCyan;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.ExitButton.Location = new System.Drawing.Point(34, 296);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(222, 50);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.LightCyan;
            this.NewGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewGameButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewGameButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.NewGameButton.Location = new System.Drawing.Point(34, 222);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(222, 50);
            this.NewGameButton.TabIndex = 3;
            this.NewGameButton.Text = "Нова гра";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(294, 401);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.ActualScoreLabel);
            this.Controls.Add(this.TextLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(310, 440);
            this.MinimumSize = new System.Drawing.Size(310, 440);
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over !";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOverForm_FormClosing);
            this.Load += new System.EventHandler(this.GameOverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TextLabel;
        public Label ActualScoreLabel;
        public Label RecordLabel;
        private Button ExitButton;
        private Button NewGameButton;
    }
}