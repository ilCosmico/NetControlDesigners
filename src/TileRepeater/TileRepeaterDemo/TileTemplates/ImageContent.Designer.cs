﻿namespace TileRepeaterDemo.TileTemplates
{
    partial class ImageContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._infoLabel = new System.Windows.Forms.Label();
            this._genericPictureItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._imageLoaderComponent = new TileRepeaterDemo.TileTemplates.BindableAsyncImageLoaderComponent(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._genericPictureItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _infoLabel
            // 
            this._infoLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._genericPictureItemBindingSource, "Filename", true));
            this._infoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._infoLabel.Location = new System.Drawing.Point(0, 370);
            this._infoLabel.Name = "_infoLabel";
            this._infoLabel.Size = new System.Drawing.Size(533, 30);
            this._infoLabel.TabIndex = 3;
            this._infoLabel.Text = "label1";
            // 
            // _genericPictureItemBindingSource
            // 
            this._genericPictureItemBindingSource.DataSource = typeof(TileRepeater.Data.ListController.GenericPictureItem);
            // 
            // _pictureBox
            // 
            this._pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox.Location = new System.Drawing.Point(0, 0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(533, 400);
            this._pictureBox.TabIndex = 2;
            this._pictureBox.TabStop = false;
            // 
            // _imageLoaderComponent
            // 
            this._imageLoaderComponent.DataBindings.Add(new System.Windows.Forms.Binding("ImageFilename", this._genericPictureItemBindingSource, "Filename", true));
            this._imageLoaderComponent.ImageFilename = null;
            // 
            // ImageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._infoLabel);
            this.Controls.Add(this._pictureBox);
            this.Name = "ImageContent";
            this.Size = new System.Drawing.Size(533, 400);
            ((System.ComponentModel.ISupportInitialize)(this._genericPictureItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label _infoLabel;
        private PictureBox _pictureBox;
        private BindableAsyncImageLoaderComponent _imageLoaderComponent;
        private BindingSource _genericPictureItemBindingSource;
    }
}
