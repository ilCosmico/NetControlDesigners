﻿namespace CustomTypeEditor
{
    partial class CustomControlTestForm
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
            this.customControl1 = new CustomControl.CustomControl();
            this.SuspendLayout();
            // 
            // customControl1
            // 
            this.customControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customControl1.Location = new System.Drawing.Point(15, 13);
            this.customControl1.Margin = new System.Windows.Forms.Padding(4);
            this.customControl1.Name = "customControl1";
            this.customControl1.Size = new System.Drawing.Size(972, 536);
            this.customControl1.TabIndex = 0;
            this.customControl1.Text = "customControl1";
            // 
            // CustomControlTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.customControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomControlTestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.CustomControl customControl1;
    }
}