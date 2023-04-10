namespace ltihan
{
    partial class drink
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
            this.soda = new System.Windows.Forms.Button();
            this.water = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soda
            // 
            this.soda.Location = new System.Drawing.Point(31, 152);
            this.soda.Name = "soda";
            this.soda.Size = new System.Drawing.Size(75, 23);
            this.soda.TabIndex = 0;
            this.soda.Text = "Soda";
            this.soda.UseVisualStyleBackColor = true;
            this.soda.Click += new System.EventHandler(this.soda_Click);
            // 
            // water
            // 
            this.water.Location = new System.Drawing.Point(31, 181);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(75, 23);
            this.water.TabIndex = 1;
            this.water.Text = "water";
            this.water.UseVisualStyleBackColor = true;
            this.water.Click += new System.EventHandler(this.water_Click);
            // 
            // drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(206, 308);
            this.Controls.Add(this.water);
            this.Controls.Add(this.soda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "drink";
            this.Text = "drink";
            this.Load += new System.EventHandler(this.drink_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button soda;
        private System.Windows.Forms.Button water;
    }
}