namespace OOD_Final_Project
{
    partial class GameplayForm
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
            this.headerBox = new System.Windows.Forms.TextBox();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.foeNameBox = new System.Windows.Forms.TextBox();
            this.gameplayDialogueBox = new System.Windows.Forms.TextBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.healButton = new System.Windows.Forms.Button();
            this.foeStatsBox = new System.Windows.Forms.TextBox();
            this.playerStatsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerBox
            // 
            this.headerBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerBox.Location = new System.Drawing.Point(168, 12);
            this.headerBox.Name = "headerBox";
            this.headerBox.ReadOnly = true;
            this.headerBox.Size = new System.Drawing.Size(462, 41);
            this.headerBox.TabIndex = 0;
            this.headerBox.Text = "Welcome To the RPG. FIGHT!";
            this.headerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerNameBox
            // 
            this.playerNameBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.playerNameBox.Location = new System.Drawing.Point(44, 138);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.ReadOnly = true;
            this.playerNameBox.Size = new System.Drawing.Size(175, 22);
            this.playerNameBox.TabIndex = 1;
            this.playerNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // foeNameBox
            // 
            this.foeNameBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.foeNameBox.Location = new System.Drawing.Point(598, 138);
            this.foeNameBox.Name = "foeNameBox";
            this.foeNameBox.ReadOnly = true;
            this.foeNameBox.Size = new System.Drawing.Size(175, 22);
            this.foeNameBox.TabIndex = 2;
            this.foeNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gameplayDialogueBox
            // 
            this.gameplayDialogueBox.AcceptsReturn = true;
            this.gameplayDialogueBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gameplayDialogueBox.Location = new System.Drawing.Point(264, 118);
            this.gameplayDialogueBox.Multiline = true;
            this.gameplayDialogueBox.Name = "gameplayDialogueBox";
            this.gameplayDialogueBox.ReadOnly = true;
            this.gameplayDialogueBox.Size = new System.Drawing.Size(288, 179);
            this.gameplayDialogueBox.TabIndex = 3;
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(264, 365);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 25);
            this.attackButton.TabIndex = 4;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // healButton
            // 
            this.healButton.Location = new System.Drawing.Point(477, 365);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(75, 25);
            this.healButton.TabIndex = 5;
            this.healButton.Text = "Heal";
            this.healButton.UseVisualStyleBackColor = true;
            // 
            // foeStatsBox
            // 
            this.foeStatsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.foeStatsBox.Location = new System.Drawing.Point(598, 180);
            this.foeStatsBox.Multiline = true;
            this.foeStatsBox.Name = "foeStatsBox";
            this.foeStatsBox.ReadOnly = true;
            this.foeStatsBox.Size = new System.Drawing.Size(175, 117);
            this.foeStatsBox.TabIndex = 6;
            // 
            // playerStatsBox
            // 
            this.playerStatsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.playerStatsBox.Location = new System.Drawing.Point(44, 180);
            this.playerStatsBox.Multiline = true;
            this.playerStatsBox.Name = "playerStatsBox";
            this.playerStatsBox.ReadOnly = true;
            this.playerStatsBox.Size = new System.Drawing.Size(175, 117);
            this.playerStatsBox.TabIndex = 7;
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerStatsBox);
            this.Controls.Add(this.foeStatsBox);
            this.Controls.Add(this.healButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.gameplayDialogueBox);
            this.Controls.Add(this.foeNameBox);
            this.Controls.Add(this.playerNameBox);
            this.Controls.Add(this.headerBox);
            this.Name = "GameplayForm";
            this.Text = "GameplayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox headerBox;
        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.TextBox foeNameBox;
        private System.Windows.Forms.TextBox gameplayDialogueBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button healButton;
        private System.Windows.Forms.TextBox foeStatsBox;
        private System.Windows.Forms.TextBox playerStatsBox;
    }
}