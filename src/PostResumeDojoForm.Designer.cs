namespace DojoTimer
{
    partial class PostResumeDojoForm
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
            this.subject = new System.Windows.Forms.TextBox();
            this.source = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendResumeDojo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.local = new System.Windows.Forms.TextBox();
            this.resume = new System.Windows.Forms.TextBox();
            this.dojoFacts = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.formTitleBar1 = new DojoTimer.FormTitleBar();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source Problem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Summary of what was done in the dojo today";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(31, 252);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(181, 20);
            this.subject.TabIndex = 4;
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(251, 252);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(181, 20);
            this.source.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "#DojoFact";
            // 
            // sendResumeDojo
            // 
            this.sendResumeDojo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sendResumeDojo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.sendResumeDojo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sendResumeDojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendResumeDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendResumeDojo.Location = new System.Drawing.Point(299, 575);
            this.sendResumeDojo.Name = "sendResumeDojo";
            this.sendResumeDojo.Size = new System.Drawing.Size(113, 51);
            this.sendResumeDojo.TabIndex = 8;
            this.sendResumeDojo.Text = "Publish in dojorio.org";
            this.sendResumeDojo.UseVisualStyleBackColor = true;
            this.sendResumeDojo.Click += new System.EventHandler(this.sendResumeDojo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dojo (e.g. Dojo@Centro)";
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(31, 181);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(181, 20);
            this.local.TabIndex = 3;
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(31, 322);
            this.resume.Multiline = true;
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(445, 101);
            this.resume.TabIndex = 6;
            // 
            // dojoFacts
            // 
            this.dojoFacts.Location = new System.Drawing.Point(31, 477);
            this.dojoFacts.Multiline = true;
            this.dojoFacts.Name = "dojoFacts";
            this.dojoFacts.Size = new System.Drawing.Size(445, 53);
            this.dojoFacts.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "User Wordpress";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(32, 115);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(182, 20);
            this.user.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(251, 115);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(182, 20);
            this.password.TabIndex = 2;
            // 
            // formTitleBar1
            // 
            this.formTitleBar1.BackColor = System.Drawing.Color.Green;
            this.formTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formTitleBar1.ForeColor = System.Drawing.Color.White;
            this.formTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.formTitleBar1.Name = "formTitleBar1";
            this.formTitleBar1.Size = new System.Drawing.Size(509, 62);
            this.formTitleBar1.TabIndex = 18;
            this.formTitleBar1.TitleDescription = "Post in blog what we\'ve done today";
            this.formTitleBar1.TitleIcon = "";
            this.formTitleBar1.TitleText = "Post it!";
            this.formTitleBar1.Load += new System.EventHandler(this.formTitleBar1_Load);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(31, 575);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(113, 51);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "Leave me alone!";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // PostResumeDojoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 688);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.formTitleBar1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dojoFacts);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.local);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendResumeDojo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.source);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PostResumeDojoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendResumeDojo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.TextBox resume;
        private System.Windows.Forms.TextBox dojoFacts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password;
        private FormTitleBar formTitleBar1;
        private System.Windows.Forms.Button CloseButton;
    }
}