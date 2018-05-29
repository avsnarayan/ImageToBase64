using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ImageToBase64
{
    public partial class FrmImagetoBase64Main : Form
    {
        public FrmImagetoBase64Main()
        {
            InitializeComponent();
        }

        private void btnOpenFileSelectDialogue_Click(object sender, EventArgs e)
        {
            var dialogueResult = openImageFileDialog.ShowDialog();
            if (dialogueResult == DialogResult.Cancel)
                return;
            convert(openImageFileDialog.FileName);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBase64String.Text))
                return;
            Clipboard.SetText(txtBase64String.Text);
        }

        private void convert(string fileName)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!File.Exists(fileName))
            {
                MessageBox.Show("File :" + fileName + " can not be found.", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                txtFilePath.Text = fileName;
                //https://stackoverflow.com/questions/21325661/convert-image-path-to-base64-string
                using (Image image = Image.FromFile(fileName))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        // Convert byte[] to Base64 String
                        txtBase64String.Text = Convert.ToBase64String(imageBytes);

                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: "+ exp.Message, "Error", MessageBoxButtons.OK);
            }
            Cursor.Current = Cursors.Default;
        }
        private void FrmImagetoBase64Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                switch (Path.GetExtension(file).ToUpper())
                {
                    //Image files|*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.bmp
                    case ".JPEG":
                    case ".BMP":
                    case ".PNG":
                    case ".JFIF":
                    case ".JPE":
                    case ".JPG":
                    {
                        convert(file);
                        return;
                    }

                    default:
                        continue;

                }
            }
        }

        private void FrmImagetoBase64Main_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBase64String.Text = string.Empty;
            txtFilePath.Text = string.Empty;
        }
    }
}
