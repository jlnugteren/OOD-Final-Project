namespace OOD_Final_Project
{
    partial class LandingForm
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
            this.buttonFighter = new System.Windows.Forms.Button();
            this.welcomeHeader = new System.Windows.Forms.TextBox();
            this.buttonSorcerer = new System.Windows.Forms.Button();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFighter
            // 
            this.buttonFighter.BackColor = System.Drawing.Color.Black;
            this.buttonFighter.FlatAppearance.BorderSize = 0;
            this.buttonFighter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFighter.ForeColor = System.Drawing.Color.White;
            this.buttonFighter.Location = new System.Drawing.Point(216, 317);
            this.buttonFighter.Name = "buttonFighter";
            this.buttonFighter.Size = new System.Drawing.Size(139, 29);
            this.buttonFighter.TabIndex = 0;
            this.buttonFighter.TabStop = false;
            this.buttonFighter.Text = "Fighter\r\n";
            this.buttonFighter.UseVisualStyleBackColor = false;
            this.buttonFighter.Click += new System.EventHandler(this.Button1_Click);
            this.buttonFighter.MouseLeave += new System.EventHandler(this.Button1_Leave);
            this.buttonFighter.MouseHover += new System.EventHandler(this.Button1_Hover);
            // 
            // welcomeHeader
            // 
            this.welcomeHeader.BackColor = System.Drawing.SystemColors.Desktop;
            this.welcomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeHeader.ForeColor = System.Drawing.Color.White;
            this.welcomeHeader.Location = new System.Drawing.Point(79, 91);
            this.welcomeHeader.Multiline = true;
            this.welcomeHeader.Name = "welcomeHeader";
            this.welcomeHeader.ReadOnly = true;
            this.welcomeHeader.Size = new System.Drawing.Size(668, 72);
            this.welcomeHeader.TabIndex = 1;
            this.welcomeHeader.TabStop = false;
            this.welcomeHeader.Text = "Welcome to the RPG! Please enter your name and choose your character class.";
            this.welcomeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSorcerer
            // 
            this.buttonSorcerer.BackColor = System.Drawing.Color.Black;
            this.buttonSorcerer.FlatAppearance.BorderSize = 0;
            this.buttonSorcerer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSorcerer.ForeColor = System.Drawing.Color.White;
            this.buttonSorcerer.Location = new System.Drawing.Point(401, 317);
            this.buttonSorcerer.Name = "buttonSorcerer";
            this.buttonSorcerer.Size = new System.Drawing.Size(139, 29);
            this.buttonSorcerer.TabIndex = 2;
            this.buttonSorcerer.TabStop = false;
            this.buttonSorcerer.Text = "Sorcerer";
            this.buttonSorcerer.UseVisualStyleBackColor = false;
            this.buttonSorcerer.Click += new System.EventHandler(this.Button2_Click);
            this.buttonSorcerer.MouseLeave += new System.EventHandler(this.Button2_Leave);
            this.buttonSorcerer.MouseHover += new System.EventHandler(this.Button2_Hover);
            // 
            // nameInputBox
            // 
            this.nameInputBox.Location = new System.Drawing.Point(282, 216);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(188, 22);
            this.nameInputBox.TabIndex = 3;
            this.nameInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.buttonSorcerer);
            this.Controls.Add(this.welcomeHeader);
            this.Controls.Add(this.buttonFighter);
            this.Name = "LandingForm";
            this.Text = "Landing Form - Final Project";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFighter;
        private System.Windows.Forms.TextBox welcomeHeader;
        private System.Windows.Forms.Button buttonSorcerer;
        private System.Windows.Forms.TextBox nameInputBox;
    }
}

