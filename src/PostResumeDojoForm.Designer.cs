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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tema do Dojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fonte do Problema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resumo do que foi feito no dojo de hoje";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(163, 170);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(181, 20);
            this.subject.TabIndex = 4;
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(163, 216);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(181, 20);
            this.source.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "#DojoFact XD";
            // 
            // sendResumeDojo
            // 
            this.sendResumeDojo.Location = new System.Drawing.Point(454, 168);
            this.sendResumeDojo.Name = "sendResumeDojo";
            this.sendResumeDojo.Size = new System.Drawing.Size(92, 68);
            this.sendResumeDojo.TabIndex = 8;
            this.sendResumeDojo.Text = "Publish in dojorio.org";
            this.sendResumeDojo.UseVisualStyleBackColor = true;
            this.sendResumeDojo.Click += new System.EventHandler(this.sendResumeDojo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dojo (p. ex Dojo@Centro)";
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(163, 131);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(181, 20);
            this.local.TabIndex = 3;
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(31, 318);
            this.resume.Multiline = true;
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(445, 101);
            this.resume.TabIndex = 6;
            this.resume.TextChanged += new System.EventHandler(this.dojoResume_TextChanged);
            // 
            // dojoFacts
            // 
            this.dojoFacts.Location = new System.Drawing.Point(31, 481);
            this.dojoFacts.Multiline = true;
            this.dojoFacts.Name = "dojoFacts";
            this.dojoFacts.Size = new System.Drawing.Size(445, 53);
            this.dojoFacts.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "User Wordpress";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(163, 87);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(181, 20);
            this.user.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "User Wordpress";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(482, 86);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 2;
            // 
            // PostResumeDojoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 577);
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
            this.Name = "PostResumeDojoForm";
            this.Text = "PostResumeDojoForm";
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
    }
}