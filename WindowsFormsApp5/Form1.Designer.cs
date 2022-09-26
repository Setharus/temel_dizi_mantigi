namespace WindowsFormsApp5
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
            this.btnDiziYaz = new System.Windows.Forms.Button();
            this.btnForeachYaz = new System.Windows.Forms.Button();
            this.btnForYaz = new System.Windows.Forms.Button();
            this.lstGoster = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDiziYaz
            // 
            this.btnDiziYaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDiziYaz.Location = new System.Drawing.Point(13, 13);
            this.btnDiziYaz.Name = "btnDiziYaz";
            this.btnDiziYaz.Size = new System.Drawing.Size(129, 81);
            this.btnDiziYaz.TabIndex = 0;
            this.btnDiziYaz.Text = "Dizi Elemanlarını Yazdır";
            this.btnDiziYaz.UseVisualStyleBackColor = false;
            this.btnDiziYaz.Click += new System.EventHandler(this.btnDiziYaz_Click);
            // 
            // btnForeachYaz
            // 
            this.btnForeachYaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnForeachYaz.Location = new System.Drawing.Point(13, 118);
            this.btnForeachYaz.Name = "btnForeachYaz";
            this.btnForeachYaz.Size = new System.Drawing.Size(129, 81);
            this.btnForeachYaz.TabIndex = 0;
            this.btnForeachYaz.Text = "Foreach ile Yaz";
            this.btnForeachYaz.UseVisualStyleBackColor = false;
            this.btnForeachYaz.Click += new System.EventHandler(this.btnForeachYaz_Click);
            // 
            // btnForYaz
            // 
            this.btnForYaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnForYaz.Location = new System.Drawing.Point(12, 222);
            this.btnForYaz.Name = "btnForYaz";
            this.btnForYaz.Size = new System.Drawing.Size(129, 81);
            this.btnForYaz.TabIndex = 0;
            this.btnForYaz.Text = "For ile Yaz";
            this.btnForYaz.UseVisualStyleBackColor = false;
            this.btnForYaz.Click += new System.EventHandler(this.btnForYaz_Click);
            // 
            // lstGoster
            // 
            this.lstGoster.FormattingEnabled = true;
            this.lstGoster.Location = new System.Drawing.Point(149, 13);
            this.lstGoster.Name = "lstGoster";
            this.lstGoster.Size = new System.Drawing.Size(201, 290);
            this.lstGoster.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(362, 317);
            this.Controls.Add(this.lstGoster);
            this.Controls.Add(this.btnForYaz);
            this.Controls.Add(this.btnForeachYaz);
            this.Controls.Add(this.btnDiziYaz);
            this.Name = "Form1";
            this.Text = "Diziler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiziYaz;
        private System.Windows.Forms.Button btnForeachYaz;
        private System.Windows.Forms.Button btnForYaz;
        private System.Windows.Forms.ListBox lstGoster;
    }
}

