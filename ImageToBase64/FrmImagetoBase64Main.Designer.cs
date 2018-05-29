namespace ImageToBase64
{
    partial class FrmImagetoBase64Main
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
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFileSelectDialogue = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBase64String = new System.Windows.Forms.TextBox();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.lblHorizontalLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = "Image files|*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.bmp";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(72, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(341, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnOpenFileSelectDialogue
            // 
            this.btnOpenFileSelectDialogue.Location = new System.Drawing.Point(419, 12);
            this.btnOpenFileSelectDialogue.Name = "btnOpenFileSelectDialogue";
            this.btnOpenFileSelectDialogue.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFileSelectDialogue.TabIndex = 1;
            this.btnOpenFileSelectDialogue.Text = "Select";
            this.btnOpenFileSelectDialogue.UseVisualStyleBackColor = true;
            this.btnOpenFileSelectDialogue.Click += new System.EventHandler(this.btnOpenFileSelectDialogue_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(419, 43);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(338, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtBase64String
            // 
            this.txtBase64String.Location = new System.Drawing.Point(12, 72);
            this.txtBase64String.Multiline = true;
            this.txtBase64String.Name = "txtBase64String";
            this.txtBase64String.ReadOnly = true;
            this.txtBase64String.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBase64String.Size = new System.Drawing.Size(482, 173);
            this.txtBase64String.TabIndex = 4;
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Location = new System.Drawing.Point(10, 15);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(56, 13);
            this.lblSelectFile.TabIndex = 6;
            this.lblSelectFile.Text = "Select File";
            // 
            // lblHorizontalLine
            // 
            this.lblHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorizontalLine.Location = new System.Drawing.Point(12, 38);
            this.lblHorizontalLine.MaximumSize = new System.Drawing.Size(0, 2);
            this.lblHorizontalLine.MinimumSize = new System.Drawing.Size(0, 2);
            this.lblHorizontalLine.Name = "lblHorizontalLine";
            this.lblHorizontalLine.Size = new System.Drawing.Size(0, 2);
            this.lblHorizontalLine.TabIndex = 8;
            // 
            // FrmImagetoBase64Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 257);
            this.Controls.Add(this.lblHorizontalLine);
            this.Controls.Add(this.lblSelectFile);
            this.Controls.Add(this.txtBase64String);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnOpenFileSelectDialogue);
            this.Controls.Add(this.txtFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImagetoBase64Main";
            this.Text = "Image to base 64 converter";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmImagetoBase64Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmImagetoBase64Main_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnOpenFileSelectDialogue;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBase64String;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.Label lblHorizontalLine;
    }
}

