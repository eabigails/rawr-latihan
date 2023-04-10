namespace ltihan
{
    partial class snack
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
            this.pisgor = new System.Windows.Forms.Button();
            this.piscok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pisgor
            // 
            this.pisgor.Location = new System.Drawing.Point(25, 125);
            this.pisgor.Name = "pisgor";
            this.pisgor.Size = new System.Drawing.Size(129, 23);
            this.pisgor.TabIndex = 0;
            this.pisgor.Text = "Pisang goreng";
            this.pisgor.UseVisualStyleBackColor = true;
            this.pisgor.Click += new System.EventHandler(this.pisgor_Click);
            // 
            // piscok
            // 
            this.piscok.Location = new System.Drawing.Point(25, 175);
            this.piscok.Name = "piscok";
            this.piscok.Size = new System.Drawing.Size(129, 23);
            this.piscok.TabIndex = 1;
            this.piscok.Text = "Pisang coklat";
            this.piscok.UseVisualStyleBackColor = true;
            this.piscok.Click += new System.EventHandler(this.piscok_Click);
            // 
            // snack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(190, 355);
            this.Controls.Add(this.piscok);
            this.Controls.Add(this.pisgor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "snack";
            this.Text = "snack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pisgor;
        private System.Windows.Forms.Button piscok;
    }
}