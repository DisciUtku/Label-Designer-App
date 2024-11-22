namespace Label_Software
{
    partial class DesignerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignerScreen));
            preview = new Label();
            previewPanel = new Panel();
            printerPicture = new PictureBox();
            printerName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)printerPicture).BeginInit();
            SuspendLayout();
            // 
            // preview
            // 
            preview.AutoSize = true;
            preview.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            preview.Location = new Point(27, 25);
            preview.Name = "preview";
            preview.Size = new Size(159, 45);
            preview.TabIndex = 0;
            preview.Text = "Önizleme";
            // 
            // previewPanel
            // 
            previewPanel.BackColor = Color.Gold;
            previewPanel.Location = new Point(27, 73);
            previewPanel.Name = "previewPanel";
            previewPanel.Size = new Size(377, 189);
            previewPanel.TabIndex = 1;
            // 
            // printerPicture
            // 
            printerPicture.Image = (Image)resources.GetObject("printerPicture.Image");
            printerPicture.Location = new Point(829, 73);
            printerPicture.Name = "printerPicture";
            printerPicture.Size = new Size(302, 302);
            printerPicture.SizeMode = PictureBoxSizeMode.Zoom;
            printerPicture.TabIndex = 2;
            printerPicture.TabStop = false;
            // 
            // printerName
            // 
            printerName.AutoSize = true;
            printerName.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            printerName.Location = new Point(897, 73);
            printerName.Name = "printerName";
            printerName.Size = new Size(173, 37);
            printerName.TabIndex = 3;
            printerName.Text = "printerName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(27, 295);
            label1.Name = "label1";
            label1.Size = new Size(159, 45);
            label1.TabIndex = 4;
            label1.Text = "Önizleme";
            // 
            // DesignerScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1154, 611);
            Controls.Add(label1);
            Controls.Add(printerName);
            Controls.Add(printerPicture);
            Controls.Add(previewPanel);
            Controls.Add(preview);
            Name = "DesignerScreen";
            Text = "Label Designer by ErgoSoft";
            ((System.ComponentModel.ISupportInitialize)printerPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label preview;
        private Panel previewPanel;
        private PictureBox printerPicture;
        private Label printerName;
        private Label label1;
    }
}