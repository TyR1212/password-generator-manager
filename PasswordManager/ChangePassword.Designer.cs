namespace PasswordManager
{
    partial class ChangePassword
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
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveDisabledButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.labelLabel = new System.Windows.Forms.Label();
            this.labelTextBox = new System.Windows.Forms.TextBox();
            this.saveEnabledButton = new System.Windows.Forms.Button();
            this.backLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.changePasswordLabel.Location = new System.Drawing.Point(82, 19);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(201, 29);
            this.changePasswordLabel.TabIndex = 7;
            this.changePasswordLabel.Text = "Change Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Length";
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthUpDown.Location = new System.Drawing.Point(205, 210);
            this.lengthUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.lengthUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(41, 22);
            this.lengthUpDown.TabIndex = 23;
            this.lengthUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // saveDisabledButton
            // 
            this.saveDisabledButton.BackColor = System.Drawing.Color.LightBlue;
            this.saveDisabledButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.saveDisabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.saveDisabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.saveDisabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDisabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDisabledButton.ForeColor = System.Drawing.Color.White;
            this.saveDisabledButton.Location = new System.Drawing.Point(280, 175);
            this.saveDisabledButton.Name = "saveDisabledButton";
            this.saveDisabledButton.Size = new System.Drawing.Size(75, 26);
            this.saveDisabledButton.TabIndex = 22;
            this.saveDisabledButton.Text = "Save";
            this.saveDisabledButton.UseVisualStyleBackColor = false;
            this.saveDisabledButton.Visible = false;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.generateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.generateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(114, 207);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 26);
            this.generateButton.TabIndex = 21;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.passwordLabel.Location = new System.Drawing.Point(134, 149);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(88, 23);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(81, 175);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 26);
            this.passwordTextBox.TabIndex = 19;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelLabel.Location = new System.Drawing.Point(151, 71);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(54, 23);
            this.labelLabel.TabIndex = 17;
            this.labelLabel.Text = "Label";
            // 
            // labelTextBox
            // 
            this.labelTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBox.Location = new System.Drawing.Point(112, 97);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(132, 26);
            this.labelTextBox.TabIndex = 16;
            this.labelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.labelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // saveEnabledButton
            // 
            this.saveEnabledButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveEnabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.saveEnabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.saveEnabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEnabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEnabledButton.ForeColor = System.Drawing.Color.White;
            this.saveEnabledButton.Location = new System.Drawing.Point(280, 175);
            this.saveEnabledButton.Name = "saveEnabledButton";
            this.saveEnabledButton.Size = new System.Drawing.Size(75, 26);
            this.saveEnabledButton.TabIndex = 25;
            this.saveEnabledButton.Text = "Save";
            this.saveEnabledButton.UseVisualStyleBackColor = false;
            this.saveEnabledButton.Click += new System.EventHandler(this.saveEnabledButton_Click);
            // 
            // backLinkLabel
            // 
            this.backLinkLabel.AutoSize = true;
            this.backLinkLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLinkLabel.Location = new System.Drawing.Point(12, 258);
            this.backLinkLabel.Name = "backLinkLabel";
            this.backLinkLabel.Size = new System.Drawing.Size(51, 14);
            this.backLinkLabel.TabIndex = 26;
            this.backLinkLabel.TabStop = true;
            this.backLinkLabel.Text = "Go back";
            this.backLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLinkLabel_LinkClicked);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 281);
            this.Controls.Add(this.backLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lengthUpDown);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.labelTextBox);
            this.Controls.Add(this.saveEnabledButton);
            this.Controls.Add(this.changePasswordLabel);
            this.Controls.Add(this.saveDisabledButton);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePassword";
            this.Shown += new System.EventHandler(this.ChangePassword_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.Button saveDisabledButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.TextBox labelTextBox;
        private System.Windows.Forms.Button saveEnabledButton;
        private System.Windows.Forms.LinkLabel backLinkLabel;
    }
}