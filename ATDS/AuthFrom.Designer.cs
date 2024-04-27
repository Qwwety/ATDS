
namespace ATDS
{
    partial class AuthFrom
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(36, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя ";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(12, 54);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(56, 16);
            this.PassLabel.TabIndex = 1;
            this.PassLabel.Text = "Пароль";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 29);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(190, 22);
            this.NameBox.TabIndex = 2;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(12, 74);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(190, 22);
            this.PassBox.TabIndex = 3;
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(12, 114);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(190, 40);
            this.AuthButton.TabIndex = 4;
            this.AuthButton.Text = " Аторизоваться";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // AuthFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 181);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AuthFrom";
            this.ShowInTaskbar = false;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button AuthButton;
    }
}