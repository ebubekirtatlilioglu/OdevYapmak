﻿namespace Ornek
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
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnNokia = new System.Windows.Forms.Button();
            this.btnIphone = new System.Windows.Forms.Button();
            this.btnSamsung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(12, 12);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(415, 96);
            this.btnDefault.TabIndex = 0;
            this.btnDefault.Text = "DEFAULT";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnNokia
            // 
            this.btnNokia.Location = new System.Drawing.Point(12, 114);
            this.btnNokia.Name = "btnNokia";
            this.btnNokia.Size = new System.Drawing.Size(415, 96);
            this.btnNokia.TabIndex = 1;
            this.btnNokia.Text = "NOKİA";
            this.btnNokia.UseVisualStyleBackColor = true;
            this.btnNokia.Click += new System.EventHandler(this.btnNokia_Click);
            // 
            // btnIphone
            // 
            this.btnIphone.Location = new System.Drawing.Point(12, 216);
            this.btnIphone.Name = "btnIphone";
            this.btnIphone.Size = new System.Drawing.Size(415, 96);
            this.btnIphone.TabIndex = 2;
            this.btnIphone.Text = "IPHONE";
            this.btnIphone.UseVisualStyleBackColor = true;
            this.btnIphone.Click += new System.EventHandler(this.btnIphone_Click);
            // 
            // btnSamsung
            // 
            this.btnSamsung.Location = new System.Drawing.Point(12, 318);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(415, 96);
            this.btnSamsung.TabIndex = 3;
            this.btnSamsung.Text = "SAMSUNG";
            this.btnSamsung.UseVisualStyleBackColor = true;
            this.btnSamsung.Click += new System.EventHandler(this.btnSamsung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 426);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.btnIphone);
            this.Controls.Add(this.btnNokia);
            this.Controls.Add(this.btnDefault);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDefault;
        private Button btnNokia;
        private Button btnIphone;
        private Button btnSamsung;
    }
}