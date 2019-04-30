namespace PercentageProgramAllanL
{
    partial class frmPercentageProgram
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
            this.lblMark = new System.Windows.Forms.Label();
            this.btnPercent = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.Location = new System.Drawing.Point(24, 50);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(174, 20);
            this.lblMark.TabIndex = 0;
            this.lblMark.Text = "Please enter a mark:";
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.Location = new System.Drawing.Point(79, 102);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(148, 44);
            this.btnPercent.TabIndex = 1;
            this.btnPercent.Text = "Get Percentage";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(204, 50);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(73, 20);
            this.txtLevel.TabIndex = 2;
            // 
            // frmPercentageProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 168);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.lblMark);
            this.Name = "frmPercentageProgram";
            this.Text = "Percentage Program by AllanL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.TextBox txtLevel;
    }
}

