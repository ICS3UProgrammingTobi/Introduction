namespace WindowsFormsApp1
{
    partial class frmCalculations
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
            this.btnEquations1 = new System.Windows.Forms.Button();
            this.btnEquations2 = new System.Windows.Forms.Button();
            this.btnEquations3 = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEquations1
            // 
            this.btnEquations1.Location = new System.Drawing.Point(12, 43);
            this.btnEquations1.Name = "btnEquations1";
            this.btnEquations1.Size = new System.Drawing.Size(121, 63);
            this.btnEquations1.TabIndex = 0;
            this.btnEquations1.Text = "Calculate the perimeter of a rectangle with lengh 5cm and width 8cm";
            this.btnEquations1.UseVisualStyleBackColor = true;
            this.btnEquations1.Click += new System.EventHandler(this.btnEquations1_Click);
            // 
            // btnEquations2
            // 
            this.btnEquations2.Location = new System.Drawing.Point(12, 135);
            this.btnEquations2.Name = "btnEquations2";
            this.btnEquations2.Size = new System.Drawing.Size(121, 51);
            this.btnEquations2.TabIndex = 1;
            this.btnEquations2.Text = "Calculate the area f a circle with radius 7cm";
            this.btnEquations2.UseVisualStyleBackColor = true;
            this.btnEquations2.Click += new System.EventHandler(this.btnEquations2_Click);
            // 
            // btnEquations3
            // 
            this.btnEquations3.Location = new System.Drawing.Point(12, 236);
            this.btnEquations3.Name = "btnEquations3";
            this.btnEquations3.Size = new System.Drawing.Size(121, 51);
            this.btnEquations3.TabIndex = 2;
            this.btnEquations3.Text = "Calculate the volume of a sphere with radius 4cm";
            this.btnEquations3.UseVisualStyleBackColor = true;
            this.btnEquations3.Click += new System.EventHandler(this.btnEquations3_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(153, 59);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer1.TabIndex = 4;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(153, 146);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer2.TabIndex = 5;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(153, 259);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer3.TabIndex = 6;
            // 
            // frmCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 330);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnEquations3);
            this.Controls.Add(this.btnEquations2);
            this.Controls.Add(this.btnEquations1);
            this.Name = "frmCalculations";
            this.Text = "Calculations";
            this.Load += new System.EventHandler(this.frmCalculations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquations1;
        private System.Windows.Forms.Button btnEquations2;
        private System.Windows.Forms.Button btnEquations3;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
    }
}

