namespace TrackShoe
{
    partial class mainForm
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
            this.shoePic = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.shoeBrand = new System.Windows.Forms.Label();
            this.shoeMiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shoePic)).BeginInit();
            this.SuspendLayout();
            // 
            // shoePic
            // 
            this.shoePic.Location = new System.Drawing.Point(17, 16);
            this.shoePic.Margin = new System.Windows.Forms.Padding(4);
            this.shoePic.Name = "shoePic";
            this.shoePic.Size = new System.Drawing.Size(597, 475);
            this.shoePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shoePic.TabIndex = 0;
            this.shoePic.TabStop = false;
            this.shoePic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(538, 509);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(17, 509);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // shoeBrand
            // 
            this.shoeBrand.AutoSize = true;
            this.shoeBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoeBrand.Location = new System.Drawing.Point(234, 502);
            this.shoeBrand.Name = "shoeBrand";
            this.shoeBrand.Size = new System.Drawing.Size(0, 29);
            this.shoeBrand.TabIndex = 3;
            // 
            // shoeMiles
            // 
            this.shoeMiles.AutoSize = true;
            this.shoeMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoeMiles.Location = new System.Drawing.Point(234, 536);
            this.shoeMiles.Name = "shoeMiles";
            this.shoeMiles.Size = new System.Drawing.Size(0, 29);
            this.shoeMiles.TabIndex = 4;
            this.shoeMiles.Click += new System.EventHandler(this.shoeMiles_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 604);
            this.Controls.Add(this.shoeMiles);
            this.Controls.Add(this.shoeBrand);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.shoePic);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "TrackShoe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shoePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox shoePic;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label shoeBrand;
        private System.Windows.Forms.Label shoeMiles;
    }
}

