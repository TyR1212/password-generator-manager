namespace PasswordManager
{
    partial class NewPassword
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
            this.labelTextBox = new System.Windows.Forms.TextBox();
            this.addNewPasswordLabel = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.acceptDisabledButton = new System.Windows.Forms.Button();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptEnabledButton = new System.Windows.Forms.Button();
            this.backLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTextBox
            // 
            this.labelTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBox.Location = new System.Drawing.Point(114, 99);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(132, 26);
            this.labelTextBox.TabIndex = 1;
            this.labelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.labelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // addNewPasswordLabel
            // 
            this.addNewPasswordLabel.AutoSize = true;
            this.addNewPasswordLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPasswordLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addNewPasswordLabel.Location = new System.Drawing.Point(74, 19);
            this.addNewPasswordLabel.Name = "addNewPasswordLabel";
            this.addNewPasswordLabel.Size = new System.Drawing.Size(217, 29);
            this.addNewPasswordLabel.TabIndex = 6;
            this.addNewPasswordLabel.Text = "Add New Password";
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelLabel.Location = new System.Drawing.Point(153, 73);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(54, 23);
            this.labelLabel.TabIndex = 7;
            this.labelLabel.Text = "Label";
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleLabel.Location = new System.Drawing.Point(116, 128);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(129, 13);
            this.exampleLabel.TabIndex = 8;
            this.exampleLabel.Text = "Ex. Netflix, Gmail, Router";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.passwordLabel.Location = new System.Drawing.Point(136, 158);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(88, 23);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(83, 184);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 26);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.generateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.generateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(116, 216);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 26);
            this.generateButton.TabIndex = 11;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // acceptDisabledButton
            // 
            this.acceptDisabledButton.BackColor = System.Drawing.Color.LightBlue;
            this.acceptDisabledButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.acceptDisabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.acceptDisabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.acceptDisabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptDisabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptDisabledButton.ForeColor = System.Drawing.Color.White;
            this.acceptDisabledButton.Location = new System.Drawing.Point(282, 184);
            this.acceptDisabledButton.Name = "acceptDisabledButton";
            this.acceptDisabledButton.Size = new System.Drawing.Size(75, 26);
            this.acceptDisabledButton.TabIndex = 12;
            this.acceptDisabledButton.Text = "Accept";
            this.acceptDisabledButton.UseVisualStyleBackColor = false;
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthUpDown.Location = new System.Drawing.Point(207, 219);
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
            this.lengthUpDown.TabIndex = 13;
            this.lengthUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Length";
            // 
            // acceptEnabledButton
            // 
            this.acceptEnabledButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.acceptEnabledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.acceptEnabledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.acceptEnabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptEnabledButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptEnabledButton.ForeColor = System.Drawing.Color.White;
            this.acceptEnabledButton.Location = new System.Drawing.Point(282, 184);
            this.acceptEnabledButton.Name = "acceptEnabledButton";
            this.acceptEnabledButton.Size = new System.Drawing.Size(75, 26);
            this.acceptEnabledButton.TabIndex = 15;
            this.acceptEnabledButton.Text = "Accept";
            this.acceptEnabledButton.UseVisualStyleBackColor = false;
            this.acceptEnabledButton.Click += new System.EventHandler(this.acceptEnabledButton_Click);
            // 
            // backLinkLabel
            // 
            this.backLinkLabel.AutoSize = true;
            this.backLinkLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLinkLabel.Location = new System.Drawing.Point(12, 258);
            this.backLinkLabel.Name = "backLinkLabel";
            this.backLinkLabel.Size = new System.Drawing.Size(51, 14);
            this.backLinkLabel.TabIndex = 16;
            this.backLinkLabel.TabStop = true;
            this.backLinkLabel.Text = "Go back";
            this.backLinkLabel.Click += new System.EventHandler(this.backLinkLabel_Click);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 281);
            this.Controls.Add(this.backLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lengthUpDown);
            this.Controls.Add(this.acceptDisabledButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.addNewPasswordLabel);
            this.Controls.Add(this.labelTextBox);
            this.Controls.Add(this.acceptEnabledButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Password";
            this.Shown += new System.EventHandler(this.NewPassword_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox labelTextBox;
        private System.Windows.Forms.Label addNewPasswordLabel;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button acceptDisabledButton;
        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acceptEnabledButton;
        private System.Windows.Forms.LinkLabel backLinkLabel;
    }
}