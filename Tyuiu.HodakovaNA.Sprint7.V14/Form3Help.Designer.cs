
namespace Tyuiu.HodakovaNA.Sprint7.V14
{
    partial class Form3Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3Help));
            this.Panel001HelpTop_HNA = new System.Windows.Forms.Panel();
            this.Text001_HNA = new System.Windows.Forms.Label();
            this.Button001OK_HNA = new System.Windows.Forms.Button();
            this.Panel002Help_HNA = new System.Windows.Forms.Panel();
            this.GBox001Help_HNA = new System.Windows.Forms.GroupBox();
            this.Text002Help_HNA = new System.Windows.Forms.Label();
            this.Panel001HelpTop_HNA.SuspendLayout();
            this.Panel002Help_HNA.SuspendLayout();
            this.GBox001Help_HNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel001HelpTop_HNA
            // 
            this.Panel001HelpTop_HNA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Panel001HelpTop_HNA.Controls.Add(this.Text001_HNA);
            this.Panel001HelpTop_HNA.Controls.Add(this.Button001OK_HNA);
            this.Panel001HelpTop_HNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel001HelpTop_HNA.Location = new System.Drawing.Point(0, 0);
            this.Panel001HelpTop_HNA.Name = "Panel001HelpTop_HNA";
            this.Panel001HelpTop_HNA.Size = new System.Drawing.Size(334, 84);
            this.Panel001HelpTop_HNA.TabIndex = 0;
            // 
            // Text001_HNA
            // 
            this.Text001_HNA.AutoSize = true;
            this.Text001_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text001_HNA.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Text001_HNA.Location = new System.Drawing.Point(3, 9);
            this.Text001_HNA.Name = "Text001_HNA";
            this.Text001_HNA.Size = new System.Drawing.Size(223, 66);
            this.Text001_HNA.TabIndex = 1;
            this.Text001_HNA.Text = "Инструкция по \r\nэксплуатации";
            this.Text001_HNA.Click += new System.EventHandler(this.Text001_HNA_Click);
            // 
            // Button001OK_HNA
            // 
            this.Button001OK_HNA.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button001OK_HNA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button001OK_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button001OK_HNA.ForeColor = System.Drawing.SystemColors.Window;
            this.Button001OK_HNA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button001OK_HNA.Location = new System.Drawing.Point(228, 14);
            this.Button001OK_HNA.Name = "Button001OK_HNA";
            this.Button001OK_HNA.Size = new System.Drawing.Size(99, 55);
            this.Button001OK_HNA.TabIndex = 0;
            this.Button001OK_HNA.Text = "Вернуться";
            this.Button001OK_HNA.UseVisualStyleBackColor = false;
            this.Button001OK_HNA.Click += new System.EventHandler(this.Button001OK_HNA_Click);
            // 
            // Panel002Help_HNA
            // 
            this.Panel002Help_HNA.BackColor = System.Drawing.Color.AliceBlue;
            this.Panel002Help_HNA.Controls.Add(this.GBox001Help_HNA);
            this.Panel002Help_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel002Help_HNA.Location = new System.Drawing.Point(0, 84);
            this.Panel002Help_HNA.Name = "Panel002Help_HNA";
            this.Panel002Help_HNA.Size = new System.Drawing.Size(334, 257);
            this.Panel002Help_HNA.TabIndex = 1;
            // 
            // GBox001Help_HNA
            // 
            this.GBox001Help_HNA.Controls.Add(this.Text002Help_HNA);
            this.GBox001Help_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBox001Help_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBox001Help_HNA.Location = new System.Drawing.Point(0, 0);
            this.GBox001Help_HNA.Name = "GBox001Help_HNA";
            this.GBox001Help_HNA.Size = new System.Drawing.Size(334, 257);
            this.GBox001Help_HNA.TabIndex = 0;
            this.GBox001Help_HNA.TabStop = false;
            this.GBox001Help_HNA.Text = "Инструкция";
            // 
            // Text002Help_HNA
            // 
            this.Text002Help_HNA.AutoSize = true;
            this.Text002Help_HNA.Location = new System.Drawing.Point(13, 22);
            this.Text002Help_HNA.Name = "Text002Help_HNA";
            this.Text002Help_HNA.Size = new System.Drawing.Size(323, 224);
            this.Text002Help_HNA.TabIndex = 0;
            this.Text002Help_HNA.Text = resources.GetString("Text002Help_HNA.Text");
            // 
            // Form3Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 341);
            this.Controls.Add(this.Panel002Help_HNA);
            this.Controls.Add(this.Panel001HelpTop_HNA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3Help";
            this.Text = "Form3Help";
            this.Panel001HelpTop_HNA.ResumeLayout(false);
            this.Panel001HelpTop_HNA.PerformLayout();
            this.Panel002Help_HNA.ResumeLayout(false);
            this.GBox001Help_HNA.ResumeLayout(false);
            this.GBox001Help_HNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel001HelpTop_HNA;
        private System.Windows.Forms.Label Text001_HNA;
        private System.Windows.Forms.Button Button001OK_HNA;
        private System.Windows.Forms.Panel Panel002Help_HNA;
        private System.Windows.Forms.GroupBox GBox001Help_HNA;
        private System.Windows.Forms.Label Text002Help_HNA;
    }
}