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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tema do Dojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fonte do Problema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resumo do que foi feito no dojo de hoje";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(163, 83);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(181, 20);
            this.subject.TabIndex = 3;
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(163, 138);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(181, 20);
            this.source.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "#DojoFact XD";
            // 
            // sendResumeDojo
            // 
            this.sendResumeDojo.Location = new System.Drawing.Point(385, 59);
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
            this.label5.Location = new System.Drawing.Point(29, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dojo (p. ex Dojo@Centro)";
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(163, 30);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(181, 20);
            this.local.TabIndex = 10;
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(32, 223);
            this.resume.Multiline = true;
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(445, 101);
            this.resume.TabIndex = 13;
            this.resume.TextChanged += new System.EventHandler(this.dojoResume_TextChanged);
            // 
            // dojoFacts
            // 
            this.dojoFacts.Location = new System.Drawing.Point(31, 371);
            this.dojoFacts.Multiline = true;
            this.dojoFacts.Name = "dojoFacts";
            this.dojoFacts.Size = new System.Drawing.Size(445, 53);
            this.dojoFacts.TabIndex = 14;
            // 
            // PostResumeDojoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 436);
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
    }
}