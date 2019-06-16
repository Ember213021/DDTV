namespace DD监控室.UI
{
    partial class LiveForm
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
            this.VLCContainer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VLCContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // VLCContainer
            // 
            this.VLCContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VLCContainer.Location = new System.Drawing.Point(0, 0);
            this.VLCContainer.Name = "VLCContainer";
            this.VLCContainer.Size = new System.Drawing.Size(845, 316);
            this.VLCContainer.TabIndex = 0;
            this.VLCContainer.TabStop = false;
            // 
            // LiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 316);
            this.Controls.Add(this.VLCContainer);
            this.Name = "LiveForm";
            this.Text = "LiveForm";
            ((System.ComponentModel.ISupportInitialize)(this.VLCContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox VLCContainer;
    }
}