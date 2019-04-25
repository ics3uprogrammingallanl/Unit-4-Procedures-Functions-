namespace PassbyReferenceAllanL
{
    partial class frmPassbyReference
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
            this.btnRound = new System.Windows.Forms.Button();
            this.lbldecimal = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.nudDecPlace = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(198, 159);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(75, 23);
            this.btnRound.TabIndex = 0;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lbldecimal
            // 
            this.lbldecimal.AutoSize = true;
            this.lbldecimal.Location = new System.Drawing.Point(71, 43);
            this.lbldecimal.Name = "lbldecimal";
            this.lbldecimal.Size = new System.Drawing.Size(151, 13);
            this.lbldecimal.TabIndex = 1;
            this.lbldecimal.Text = "Enter a number with decimals: ";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(71, 109);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(237, 13);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "How many decimals would you like to round to?: ";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(254, 40);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // nudDecPlace
            // 
            this.nudDecPlace.Location = new System.Drawing.Point(329, 107);
            this.nudDecPlace.Name = "nudDecPlace";
            this.nudDecPlace.Size = new System.Drawing.Size(59, 20);
            this.nudDecPlace.TabIndex = 4;
            // 
            // frmPassbyReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 210);
            this.Controls.Add(this.nudDecPlace);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lbldecimal);
            this.Controls.Add(this.btnRound);
            this.Name = "frmPassbyReference";
            this.Text = "Pass by Reference by AllanL";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lbldecimal;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.NumericUpDown nudDecPlace;
    }
}

