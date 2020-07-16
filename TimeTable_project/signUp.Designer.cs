namespace TimeTable_project
{
    partial class signUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.TextBox();
            this.rePassLabel = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호 입력";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호 재입력";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(200, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(271, 25);
            this.nameLabel.TabIndex = 3;
            // 
            // passLabel
            // 
            this.passLabel.Location = new System.Drawing.Point(200, 133);
            this.passLabel.Name = "passLabel";
            this.passLabel.PasswordChar = '*';
            this.passLabel.Size = new System.Drawing.Size(271, 25);
            this.passLabel.TabIndex = 4;
            // 
            // rePassLabel
            // 
            this.rePassLabel.Location = new System.Drawing.Point(200, 212);
            this.rePassLabel.Name = "rePassLabel";
            this.rePassLabel.PasswordChar = '*';
            this.rePassLabel.Size = new System.Drawing.Size(271, 25);
            this.rePassLabel.TabIndex = 5;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(45, 286);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(426, 52);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "회원가입하기";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 373);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.rePassLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signUp";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameLabel;
        private System.Windows.Forms.TextBox passLabel;
        private System.Windows.Forms.TextBox rePassLabel;
        private System.Windows.Forms.Button signUpButton;
    }
}