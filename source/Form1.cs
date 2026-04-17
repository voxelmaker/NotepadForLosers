using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace notepadforlosers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static class Global_App_Settings
        {
            public static int SelectedFont = 3; // 1-Arial 2-ComicSans 3-Consolas 4-Gothic 5-Helvetica
            public static bool RTFModeOn = false;
        }


        private void SetFont(string fontName, int fontId)
        {
            if (Global_App_Settings.SelectedFont != fontId)
            {
                Font currentFont = RTFBox1.SelectionFont ?? RTFBox1.Font;

                Global_App_Settings.SelectedFont = fontId;

                RTFBox1.SelectionFont = new Font(fontName, currentFont.Size, currentFont.Style);
            }
        }

        private void ArialFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFont("Arial", 1);
        }

        private void HellFontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetFont("Comic Sans MS", 2);
        }

        private void ConsolasFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFont("Consolas", 3);
        }

        private void GothicFontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetFont("Franklin Gothic", 4);
        }

        private void HelectiviaFontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetFont("Helvetica", 5);
        }


        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = RTFBox1.SelectionFont ?? RTFBox1.Font;

            FontStyle newStyle = currentFont.Bold
                ? currentFont.Style & ~FontStyle.Bold
                : currentFont.Style | FontStyle.Bold;

            RTFBox1.SelectionFont = new Font(currentFont, newStyle);
        }

        private void ItalicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = RTFBox1.SelectionFont ?? RTFBox1.Font;

            FontStyle newStyle = currentFont.Italic
                ? currentFont.Style & ~FontStyle.Italic
                : currentFont.Style | FontStyle.Italic;

            RTFBox1.SelectionFont = new Font(currentFont, newStyle);
        }

        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = RTFBox1.SelectionFont ?? RTFBox1.Font;

            FontStyle newStyle = currentFont.Underline
                ? currentFont.Style & ~FontStyle.Underline
                : currentFont.Style | FontStyle.Underline;

            RTFBox1.SelectionFont = new Font(currentFont, newStyle);
        }


        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "RTF files (*.rtf)|*.rtf";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RTFBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich Text (*.rtf)|*.rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RTFBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }


        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTFBox1.Clear();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FileNameBox_Click(object sender, EventArgs e)
        {
            /*
             * no idea why but if this method isnt here the designer has a stroke and dies
             * so i'm putting this there so no-one deletes this
             */
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}