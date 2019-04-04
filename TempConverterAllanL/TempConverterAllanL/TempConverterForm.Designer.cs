namespace TempConverterAllanL
{
    partial class frmTempConverter
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
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtTempC = new System.Windows.Forms.TextBox();
            this.lblTempC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(135, 106);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(216, 50);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Convert into Fahrenheit";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtTempC
            // 
            this.txtTempC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempC.Location = new System.Drawing.Point(361, 44);
            this.txtTempC.Name = "txtTempC";
            this.txtTempC.Size = new System.Drawing.Size(100, 26);
            this.txtTempC.TabIndex = 1;
            // 
            // lblTempC
            // 
            this.lblTempC.AutoSize = true;
            this.lblTempC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempC.Location = new System.Drawing.Point(12, 47);
            this.lblTempC.Name = "lblTempC";
            this.lblTempC.Size = new System.Drawing.Size(339, 20);
            this.lblTempC.TabIndex = 2;
            this.lblTempC.Text = " Enter the temprature in degrees Celsius:";
            // 
            // frmTempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 186);
            this.Controls.Add(this.lblTempC);
            this.Controls.Add(this.txtTempC);
            this.Controls.Add(this.btnConverter);
            this.Name = "frmTempConverter";
            this.Text = "Temprature Converter by Allan L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtTempC;
        private System.Windows.Forms.Label lblTempC;
    }
}

