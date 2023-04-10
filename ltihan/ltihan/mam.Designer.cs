namespace ltihan
{
    partial class mam
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
            this.nasgor = new System.Windows.Forms.Button();
            this.migor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nasgor
            // 
            this.nasgor.Location = new System.Drawing.Point(48, 54);
            this.nasgor.Name = "nasgor";
            this.nasgor.Size = new System.Drawing.Size(75, 23);
            this.nasgor.TabIndex = 0;
            this.nasgor.Text = "Nasgor";
            this.nasgor.UseVisualStyleBackColor = true;
            this.nasgor.Click += new System.EventHandler(this.nasgor_Click);
            // 
            // migor
            // 
            this.migor.Location = new System.Drawing.Point(48, 130);
            this.migor.Name = "migor";
            this.migor.Size = new System.Drawing.Size(75, 23);
            this.migor.TabIndex = 1;
            this.migor.Text = "Migor";
            this.migor.UseVisualStyleBackColor = true;
            this.migor.Click += new System.EventHandler(this.migor_Click);
            // 
            // mam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(205, 272);
            this.Controls.Add(this.migor);
            this.Controls.Add(this.nasgor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mam";
            this.Text = "mam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nasgor;
        private System.Windows.Forms.Button migor;
    }
}