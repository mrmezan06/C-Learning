namespace firstProject
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
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(222, 54);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(130, 44);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Show Message";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 140);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Default User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider1.Location = new System.Drawing.Point(191, 187);
            this.bunifuSlider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(186, 35);
            this.bunifuSlider1.TabIndex = 2;
            this.bunifuSlider1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 257);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
    }
}

