
namespace Tyuiu.HodakovaNA.Sprint7.V14
{
    partial class Form2Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Info));
            this.GBox01Info_HNA = new System.Windows.Forms.GroupBox();
            this.But01Info_HNA = new System.Windows.Forms.Button();
            this.Text01_HNA = new System.Windows.Forms.Label();
            this.ImgBox01_HNA = new System.Windows.Forms.PictureBox();
            this.GBox01Info_HNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox01_HNA)).BeginInit();
            this.SuspendLayout();
            // 
            // GBox01Info_HNA
            // 
            this.GBox01Info_HNA.BackColor = System.Drawing.Color.AliceBlue;
            this.GBox01Info_HNA.Controls.Add(this.But01Info_HNA);
            this.GBox01Info_HNA.Controls.Add(this.Text01_HNA);
            this.GBox01Info_HNA.Controls.Add(this.ImgBox01_HNA);
            this.GBox01Info_HNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBox01Info_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBox01Info_HNA.Location = new System.Drawing.Point(0, 0);
            this.GBox01Info_HNA.Name = "GBox01Info_HNA";
            this.GBox01Info_HNA.Size = new System.Drawing.Size(424, 181);
            this.GBox01Info_HNA.TabIndex = 0;
            this.GBox01Info_HNA.TabStop = false;
            this.GBox01Info_HNA.Text = "Базовая информация о проекте";
            // 
            // But01Info_HNA
            // 
            this.But01Info_HNA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.But01Info_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But01Info_HNA.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.But01Info_HNA.Location = new System.Drawing.Point(368, 135);
            this.But01Info_HNA.Name = "But01Info_HNA";
            this.But01Info_HNA.Size = new System.Drawing.Size(50, 40);
            this.But01Info_HNA.TabIndex = 2;
            this.But01Info_HNA.Text = "ОК";
            this.But01Info_HNA.UseVisualStyleBackColor = false;
            this.But01Info_HNA.Click += new System.EventHandler(this.But01Info_HNA_Click);
            // 
            // Text01_HNA
            // 
            this.Text01_HNA.AutoSize = true;
            this.Text01_HNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text01_HNA.Location = new System.Drawing.Point(118, 28);
            this.Text01_HNA.Name = "Text01_HNA";
            this.Text01_HNA.Size = new System.Drawing.Size(305, 144);
            this.Text01_HNA.TabIndex = 1;
            this.Text01_HNA.Text = resources.GetString("Text01_HNA.Text");
            this.Text01_HNA.Click += new System.EventHandler(this.Text01_HNA_Click);
            // 
            // ImgBox01_HNA
            // 
            this.ImgBox01_HNA.Image = ((System.Drawing.Image)(resources.GetObject("ImgBox01_HNA.Image")));
            this.ImgBox01_HNA.Location = new System.Drawing.Point(12, 38);
            this.ImgBox01_HNA.MaximumSize = new System.Drawing.Size(100, 120);
            this.ImgBox01_HNA.MinimumSize = new System.Drawing.Size(100, 120);
            this.ImgBox01_HNA.Name = "ImgBox01_HNA";
            this.ImgBox01_HNA.Size = new System.Drawing.Size(100, 120);
            this.ImgBox01_HNA.TabIndex = 0;
            this.ImgBox01_HNA.TabStop = false;
            // 
            // Form2Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 181);
            this.Controls.Add(this.GBox01Info_HNA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(440, 220);
            this.Name = "Form2Info";
            this.Text = "Form2Info";
            this.GBox01Info_HNA.ResumeLayout(false);
            this.GBox01Info_HNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox01_HNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox01Info_HNA;
        private System.Windows.Forms.PictureBox ImgBox01_HNA;
        private System.Windows.Forms.Label Text01_HNA;
        private System.Windows.Forms.Button But01Info_HNA;
    }
}