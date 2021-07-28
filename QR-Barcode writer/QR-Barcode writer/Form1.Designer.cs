namespace QR_writer
{
    partial class Form1
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
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxQrText = new System.Windows.Forms.TextBox();
            this.pictureBoxBarCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(89, 62);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxQR.TabIndex = 1;
            this.pictureBoxQR.TabStop = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(125, 218);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(79, 35);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.Generate);
            // 
            // textBoxQrText
            // 
            this.textBoxQrText.AcceptsReturn = true;
            this.textBoxQrText.Font = new System.Drawing.Font("Ravie", 8.5F);
            this.textBoxQrText.Location = new System.Drawing.Point(40, 34);
            this.textBoxQrText.Multiline = true;
            this.textBoxQrText.Name = "textBoxQrText";
            this.textBoxQrText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQrText.Size = new System.Drawing.Size(249, 20);
            this.textBoxQrText.TabIndex = 3;
            // 
            // pictureBoxBarCode
            // 
            this.pictureBoxBarCode.Location = new System.Drawing.Point(89, 259);
            this.pictureBoxBarCode.Name = "pictureBoxBarCode";
            this.pictureBoxBarCode.Size = new System.Drawing.Size(150, 96);
            this.pictureBoxBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarCode.TabIndex = 1;
            this.pictureBoxBarCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesite tekst koji zelite da prebacite u qr ili barkod (samo brojevi)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "QR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(2, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "BAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(328, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQrText);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.pictureBoxBarCode);
            this.Controls.Add(this.pictureBoxQR);
            this.Name = "Form1";
            this.Text = "Code Transformer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxQrText;
        private System.Windows.Forms.PictureBox pictureBoxBarCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

