namespace HelloWorldIntTobi
{
    partial class frmHelloWorldInt
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbLanguages = new System.Windows.Forms.GroupBox();
            this.radItalian = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.grbLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(127, 43);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(229, 39);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            this.lblGreeting.Click += new System.EventHandler(this.LblGreeting_Click);
            // 
            // grbLanguages
            // 
            this.grbLanguages.Controls.Add(this.radItalian);
            this.grbLanguages.Controls.Add(this.radFrench);
            this.grbLanguages.Controls.Add(this.radSpanish);
            this.grbLanguages.Controls.Add(this.radEnglish);
            this.grbLanguages.Location = new System.Drawing.Point(12, 123);
            this.grbLanguages.Name = "grbLanguages";
            this.grbLanguages.Size = new System.Drawing.Size(462, 96);
            this.grbLanguages.TabIndex = 1;
            this.grbLanguages.TabStop = false;
            this.grbLanguages.Text = "Language";
            // 
            // radItalian
            // 
            this.radItalian.AutoSize = true;
            this.radItalian.Location = new System.Drawing.Point(353, 37);
            this.radItalian.Name = "radItalian";
            this.radItalian.Size = new System.Drawing.Size(53, 17);
            this.radItalian.TabIndex = 4;
            this.radItalian.TabStop = true;
            this.radItalian.Text = "Italian";
            this.radItalian.UseVisualStyleBackColor = true;
            this.radItalian.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(122, 37);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(58, 17);
            this.radFrench.TabIndex = 5;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "French";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadFrench_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Location = new System.Drawing.Point(243, 37);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(63, 17);
            this.radSpanish.TabIndex = 3;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Spanish";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(25, 37);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 2;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 271);
            this.Controls.Add(this.grbLanguages);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloWorldInt";
            this.Text = "HelloWorldInternationalByTobi";
            this.grbLanguages.ResumeLayout(false);
            this.grbLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox grbLanguages;
        private System.Windows.Forms.RadioButton radItalian;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radEnglish;
    }
}

