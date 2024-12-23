﻿namespace Label_Software
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
            previewDescription = new RichTextBox();
            previewTitle = new RichTextBox();
            printerPicture = new PictureBox();
            printerName = new Label();
            title = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            description = new Label();
            printButton = new Button();
            previewPanel.SuspendLayout();
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
            previewPanel.BackColor = SystemColors.GradientActiveCaption;
            previewPanel.Controls.Add(previewDescription);
            previewPanel.Controls.Add(previewTitle);
            previewPanel.Location = new Point(27, 73);
            previewPanel.Name = "previewPanel";
            previewPanel.Size = new Size(377, 189);
            previewPanel.TabIndex = 1;
            // 
            // previewDescription
            // 
            previewDescription.BackColor = Color.Gold;
            previewDescription.BorderStyle = BorderStyle.None;
            previewDescription.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            previewDescription.Location = new Point(23, 68);
            previewDescription.MaxLength = 32;
            previewDescription.Multiline = false;
            previewDescription.Name = "previewDescription";
            previewDescription.ReadOnly = true;
            previewDescription.ScrollBars = RichTextBoxScrollBars.None;
            previewDescription.Size = new Size(328, 106);
            previewDescription.TabIndex = 10;
            previewDescription.Text = "";
            // 
            // previewTitle
            // 
            previewTitle.BackColor = Color.Gold;
            previewTitle.BorderStyle = BorderStyle.None;
            previewTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            previewTitle.Location = new Point(60, 17);
            previewTitle.MaxLength = 32;
            previewTitle.Multiline = false;
            previewTitle.Name = "previewTitle";
            previewTitle.ReadOnly = true;
            previewTitle.ScrollBars = RichTextBoxScrollBars.None;
            previewTitle.Size = new Size(248, 29);
            previewTitle.TabIndex = 9;
            previewTitle.Text = "";
            // 
            // printerPicture
            // 
            printerPicture.Image = (Image)resources.GetObject("printerPicture.Image");
            printerPicture.Location = new Point(570, 73);
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
            printerName.Location = new Point(638, 73);
            printerName.Name = "printerName";
            printerName.Size = new Size(173, 37);
            printerName.TabIndex = 3;
            printerName.Text = "printerName";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            title.Location = new Point(27, 312);
            title.Name = "title";
            title.Size = new Size(80, 32);
            title.TabIndex = 4;
            title.Text = "Başlık";
            // 
            // titleTextBox
            // 
            titleTextBox.Font = new Font("Segoe UI", 12F);
            titleTextBox.Location = new Point(27, 356);
            titleTextBox.MaxLength = 32;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.ScrollBars = ScrollBars.Horizontal;
            titleTextBox.Size = new Size(272, 29);
            titleTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 12F);
            descriptionTextBox.Location = new Point(27, 471);
            descriptionTextBox.MaxLength = 100;
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Horizontal;
            descriptionTextBox.Size = new Size(272, 115);
            descriptionTextBox.TabIndex = 1;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            description.Location = new Point(27, 422);
            description.Name = "description";
            description.Size = new Size(118, 32);
            description.TabIndex = 6;
            description.Text = "Açıklama";
            // 
            // printButton
            // 
            printButton.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            printButton.Location = new Point(570, 513);
            printButton.Name = "printButton";
            printButton.Size = new Size(302, 73);
            printButton.TabIndex = 2;
            printButton.Text = "YAZDIR";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // DesignerScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(893, 611);
            Controls.Add(printButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(description);
            Controls.Add(titleTextBox);
            Controls.Add(title);
            Controls.Add(printerName);
            Controls.Add(printerPicture);
            Controls.Add(previewPanel);
            Controls.Add(preview);
            Name = "DesignerScreen";
            Text = "Label Designer by ErgoSoft";
            previewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)printerPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label preview;
        private Panel previewPanel;
        private PictureBox printerPicture;
        private Label printerName;
        private Label title;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label description;
        private Button printButton;
        private RichTextBox previewTitle;
        private RichTextBox previewDescription;
    }
}