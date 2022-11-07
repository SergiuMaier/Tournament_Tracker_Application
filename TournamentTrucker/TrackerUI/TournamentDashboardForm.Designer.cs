namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.loadExistingDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTurnamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(97, 30);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(316, 40);
            this.headerLabel.TabIndex = 19;
            this.headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingDropDown
            // 
            this.loadExistingDropDown.FormattingEnabled = true;
            this.loadExistingDropDown.Location = new System.Drawing.Point(97, 144);
            this.loadExistingDropDown.Name = "loadExistingDropDown";
            this.loadExistingDropDown.Size = new System.Drawing.Size(316, 38);
            this.loadExistingDropDown.TabIndex = 27;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(141, 105);
            this.loadExistingTournamentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(250, 30);
            this.loadExistingTournamentLabel.TabIndex = 26;
            this.loadExistingTournamentLabel.Text = "Load existing tournament";
            // 
            // loadTurnamentButton
            // 
            this.loadTurnamentButton.BackColor = System.Drawing.Color.White;
            this.loadTurnamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadTurnamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.loadTurnamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loadTurnamentButton.Location = new System.Drawing.Point(166, 206);
            this.loadTurnamentButton.Name = "loadTurnamentButton";
            this.loadTurnamentButton.Size = new System.Drawing.Size(178, 57);
            this.loadTurnamentButton.TabIndex = 28;
            this.loadTurnamentButton.Text = "Load turnament";
            this.loadTurnamentButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createTournamentButton.Location = new System.Drawing.Point(152, 280);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(207, 57);
            this.createTournamentButton.TabIndex = 32;
            this.createTournamentButton.Text = "Create tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 355);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTurnamentButton);
            this.Controls.Add(this.loadExistingDropDown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTurnamentButton;
        private Button createTournamentButton;
    }
}