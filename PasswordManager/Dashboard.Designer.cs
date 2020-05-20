namespace PasswordManager
{
    partial class Dashboard
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
            this.labelListBox = new System.Windows.Forms.ListBox();
            this.passordLabel = new System.Windows.Forms.Label();
            this.yourPasswordsLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.logOutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.removeEnabledButton = new System.Windows.Forms.Button();
            this.changeEnabledButton = new System.Windows.Forms.Button();
            this.showCheckBox = new System.Windows.Forms.CheckBox();
            this.changeDisabledButton = new System.Windows.Forms.Button();
            this.removeDisabledButton = new System.Windows.Forms.Button();
            this.copyEnabledButton = new System.Windows.Forms.Button();
            this.copyDisabledButton = new System.Windows.Forms.Button();
            this.copiedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelListBox
            // 
            this.labelListBox.FormattingEnabled = true;
            this.labelListBox.ItemHeight = 16;
            this.labelListBox.Location = new System.Drawing.Point(32, 61);
            this.labelListBox.Name = "labelListBox";
            this.labelListBox.Size = new System.Drawing.Size(181, 196);
            this.labelListBox.TabIndex = 0;
            this.labelListBox.SelectedIndexChanged += new System.EventHandler(this.labelListBox_SelectedIndexChanged);
            // 
            // passordLabel
            // 
            this.passordLabel.AutoSize = true;
            this.passordLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passordLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.passordLabel.Location = new System.Drawing.Point(386, 111);
            this.passordLabel.Name = "passordLabel";
            this.passordLabel.Size = new System.Drawing.Size(88, 23);
            this.passordLabel.TabIndex = 4;
            this.passordLabel.Text = "Password";
            // 
            // yourPasswordsLabel
            // 
            this.yourPasswordsLabel.AutoSize = true;
            this.yourPasswordsLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourPasswordsLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.yourPasswordsLabel.Location = new System.Drawing.Point(202, 20);
            this.yourPasswordsLabel.Name = "yourPasswordsLabel";
            this.yourPasswordsLabel.Size = new System.Drawing.Size(182, 29);
            this.yourPasswordsLabel.TabIndex = 5;
            this.yourPasswordsLabel.Text = "Your Passwords";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(321, 141);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(219, 26);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(219, 234);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 26);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // logOutLinkLabel
            // 
            this.logOutLinkLabel.AutoSize = true;
            this.logOutLinkLabel.Location = new System.Drawing.Point(521, 244);
            this.logOutLinkLabel.Name = "logOutLinkLabel";
            this.logOutLinkLabel.Size = new System.Drawing.Size(50, 16);
            this.logOutLinkLabel.TabIndex = 9;
            this.logOutLinkLabel.TabStop = true;
            this.logOutLinkLabel.Text = "Log out";
            this.logOutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOutLinkLabel_LinkClicked);
            // 
            // removeEnabledButton
            // 
            this.removeEnabledButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.removeEnabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeEnabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.removeEnabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEnabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEnabledButton.ForeColor = System.Drawing.Color.White;
            this.removeEnabledButton.Location = new System.Drawing.Point(219, 202);
            this.removeEnabledButton.Name = "removeEnabledButton";
            this.removeEnabledButton.Size = new System.Drawing.Size(75, 26);
            this.removeEnabledButton.TabIndex = 10;
            this.removeEnabledButton.Text = "Remove";
            this.removeEnabledButton.UseVisualStyleBackColor = false;
            this.removeEnabledButton.Visible = false;
            this.removeEnabledButton.Click += new System.EventHandler(this.removeEnabledButton_Click);
            // 
            // changeEnabledButton
            // 
            this.changeEnabledButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.changeEnabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.changeEnabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.changeEnabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeEnabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeEnabledButton.ForeColor = System.Drawing.Color.White;
            this.changeEnabledButton.Location = new System.Drawing.Point(219, 170);
            this.changeEnabledButton.Name = "changeEnabledButton";
            this.changeEnabledButton.Size = new System.Drawing.Size(75, 26);
            this.changeEnabledButton.TabIndex = 11;
            this.changeEnabledButton.Text = "Change";
            this.changeEnabledButton.UseVisualStyleBackColor = false;
            this.changeEnabledButton.Visible = false;
            this.changeEnabledButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // showCheckBox
            // 
            this.showCheckBox.AutoSize = true;
            this.showCheckBox.Location = new System.Drawing.Point(486, 116);
            this.showCheckBox.Name = "showCheckBox";
            this.showCheckBox.Size = new System.Drawing.Size(59, 20);
            this.showCheckBox.TabIndex = 12;
            this.showCheckBox.Text = "Show";
            this.showCheckBox.UseVisualStyleBackColor = true;
            this.showCheckBox.CheckedChanged += new System.EventHandler(this.showCheckBox_CheckedChanged);
            // 
            // changeDisabledButton
            // 
            this.changeDisabledButton.BackColor = System.Drawing.Color.LightBlue;
            this.changeDisabledButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.changeDisabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.changeDisabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.changeDisabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDisabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDisabledButton.ForeColor = System.Drawing.Color.White;
            this.changeDisabledButton.Location = new System.Drawing.Point(219, 170);
            this.changeDisabledButton.Name = "changeDisabledButton";
            this.changeDisabledButton.Size = new System.Drawing.Size(75, 26);
            this.changeDisabledButton.TabIndex = 13;
            this.changeDisabledButton.Text = "Change";
            this.changeDisabledButton.UseVisualStyleBackColor = false;
            // 
            // removeDisabledButton
            // 
            this.removeDisabledButton.BackColor = System.Drawing.Color.LightBlue;
            this.removeDisabledButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.removeDisabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.removeDisabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.removeDisabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDisabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDisabledButton.ForeColor = System.Drawing.Color.White;
            this.removeDisabledButton.Location = new System.Drawing.Point(219, 202);
            this.removeDisabledButton.Name = "removeDisabledButton";
            this.removeDisabledButton.Size = new System.Drawing.Size(75, 26);
            this.removeDisabledButton.TabIndex = 14;
            this.removeDisabledButton.Text = "Remove";
            this.removeDisabledButton.UseVisualStyleBackColor = false;
            // 
            // copyEnabledButton
            // 
            this.copyEnabledButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.copyEnabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.copyEnabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.copyEnabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyEnabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyEnabledButton.ForeColor = System.Drawing.Color.White;
            this.copyEnabledButton.Location = new System.Drawing.Point(393, 173);
            this.copyEnabledButton.Name = "copyEnabledButton";
            this.copyEnabledButton.Size = new System.Drawing.Size(75, 26);
            this.copyEnabledButton.TabIndex = 15;
            this.copyEnabledButton.Text = "Copy";
            this.copyEnabledButton.UseVisualStyleBackColor = false;
            this.copyEnabledButton.Click += new System.EventHandler(this.copyEnabledButton_Click);
            // 
            // copyDisabledButton
            // 
            this.copyDisabledButton.BackColor = System.Drawing.Color.LightBlue;
            this.copyDisabledButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.copyDisabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.copyDisabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.copyDisabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyDisabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyDisabledButton.ForeColor = System.Drawing.Color.White;
            this.copyDisabledButton.Location = new System.Drawing.Point(393, 173);
            this.copyDisabledButton.Name = "copyDisabledButton";
            this.copyDisabledButton.Size = new System.Drawing.Size(75, 26);
            this.copyDisabledButton.TabIndex = 16;
            this.copyDisabledButton.Text = "Copy";
            this.copyDisabledButton.UseVisualStyleBackColor = false;
            // 
            // copiedLabel
            // 
            this.copiedLabel.AutoSize = true;
            this.copiedLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiedLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.copiedLabel.Location = new System.Drawing.Point(474, 178);
            this.copiedLabel.Name = "copiedLabel";
            this.copiedLabel.Size = new System.Drawing.Size(51, 16);
            this.copiedLabel.TabIndex = 17;
            this.copiedLabel.Text = "Copied!";
            this.copiedLabel.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 271);
            this.Controls.Add(this.copiedLabel);
            this.Controls.Add(this.removeDisabledButton);
            this.Controls.Add(this.changeDisabledButton);
            this.Controls.Add(this.showCheckBox);
            this.Controls.Add(this.changeEnabledButton);
            this.Controls.Add(this.removeEnabledButton);
            this.Controls.Add(this.logOutLinkLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.yourPasswordsLabel);
            this.Controls.Add(this.passordLabel);
            this.Controls.Add(this.labelListBox);
            this.Controls.Add(this.copyDisabledButton);
            this.Controls.Add(this.copyEnabledButton);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox labelListBox;
        private System.Windows.Forms.Label passordLabel;
        private System.Windows.Forms.Label yourPasswordsLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.LinkLabel logOutLinkLabel;
        private System.Windows.Forms.Button removeEnabledButton;
        private System.Windows.Forms.Button changeEnabledButton;
        private System.Windows.Forms.CheckBox showCheckBox;
        private System.Windows.Forms.Button changeDisabledButton;
        private System.Windows.Forms.Button removeDisabledButton;
        private System.Windows.Forms.Button copyEnabledButton;
        private System.Windows.Forms.Button copyDisabledButton;
        private System.Windows.Forms.Label copiedLabel;
    }
}