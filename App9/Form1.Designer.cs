namespace App9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Console = new System.Windows.Forms.TextBox();
            this.History = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.Black;
            this.Console.ForeColor = System.Drawing.Color.Green;
            this.Console.Location = new System.Drawing.Point(12, 12);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(563, 23);
            this.Console.TabIndex = 0;
            this.Console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Console_KeyDown);
            // 
            // History
            // 
            this.History.FormattingEnabled = true;
            this.History.Location = new System.Drawing.Point(581, 12);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(207, 23);
            this.History.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 397);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Console);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Console;
        private ComboBox History;
        private PictureBox pictureBox1;
    }
}