namespace notepadforlosers
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            CloseToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            BoldToolStripMenuItem = new ToolStripMenuItem();
            italicsToolStripMenuItem = new ToolStripMenuItem();
            UnderlineToolStripMenuItem = new ToolStripMenuItem();
            fontsToolStripMenuItem = new ToolStripMenuItem();
            ArialFontToolStripMenuItem = new ToolStripMenuItem();
            HellFontToolStripMenuItem1 = new ToolStripMenuItem();
            ConsolasFontToolStripMenuItem = new ToolStripMenuItem();
            GothicFontToolStripMenuItem1 = new ToolStripMenuItem();
            HelectiviaFontToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            RTFBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1334, 24);
            menuStrip1.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, saveAsToolStripMenuItem, CloseToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Size = new Size(114, 22);
            NewToolStripMenuItem.Text = "New";
            NewToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(114, 22);
            OpenToolStripMenuItem.Text = "Open";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new Size(114, 22);
            CloseToolStripMenuItem.Text = "Close";
            CloseToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BoldToolStripMenuItem, italicsToolStripMenuItem, UnderlineToolStripMenuItem, fontsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // BoldToolStripMenuItem
            // 
            BoldToolStripMenuItem.Name = "BoldToolStripMenuItem";
            BoldToolStripMenuItem.Size = new Size(125, 22);
            BoldToolStripMenuItem.Text = "Bold";
            BoldToolStripMenuItem.Click += BoldToolStripMenuItem_Click;
            // 
            // italicsToolStripMenuItem
            // 
            italicsToolStripMenuItem.Name = "italicsToolStripMenuItem";
            italicsToolStripMenuItem.Size = new Size(125, 22);
            italicsToolStripMenuItem.Text = "Italics";
            italicsToolStripMenuItem.Click += ItalicsToolStripMenuItem_Click;
            // 
            // UnderlineToolStripMenuItem
            // 
            UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem";
            UnderlineToolStripMenuItem.Size = new Size(125, 22);
            UnderlineToolStripMenuItem.Text = "Underline";
            UnderlineToolStripMenuItem.Click += UnderlineToolStripMenuItem_Click;
            // 
            // fontsToolStripMenuItem
            // 
            fontsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ArialFontToolStripMenuItem, HellFontToolStripMenuItem1, ConsolasFontToolStripMenuItem, GothicFontToolStripMenuItem1, HelectiviaFontToolStripMenuItem });
            fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            fontsToolStripMenuItem.Size = new Size(125, 22);
            fontsToolStripMenuItem.Text = "Fonts";
            // 
            // ArialFontToolStripMenuItem
            // 
            ArialFontToolStripMenuItem.Name = "ArialFontToolStripMenuItem";
            ArialFontToolStripMenuItem.Size = new Size(136, 22);
            ArialFontToolStripMenuItem.Text = "Arial";
            ArialFontToolStripMenuItem.Click += ArialFontToolStripMenuItem_Click;
            // 
            // HellFontToolStripMenuItem1
            // 
            HellFontToolStripMenuItem1.Name = "HellFontToolStripMenuItem1";
            HellFontToolStripMenuItem1.Size = new Size(136, 22);
            HellFontToolStripMenuItem1.Text = "Comic Sans";
            HellFontToolStripMenuItem1.Click += HellFontToolStripMenuItem1_Click;
            // 
            // ConsolasFontToolStripMenuItem
            // 
            ConsolasFontToolStripMenuItem.Name = "ConsolasFontToolStripMenuItem";
            ConsolasFontToolStripMenuItem.Size = new Size(136, 22);
            ConsolasFontToolStripMenuItem.Text = "Consolas";
            ConsolasFontToolStripMenuItem.Click += ConsolasFontToolStripMenuItem_Click;
            // 
            // GothicFontToolStripMenuItem1
            // 
            GothicFontToolStripMenuItem1.Name = "GothicFontToolStripMenuItem1";
            GothicFontToolStripMenuItem1.Size = new Size(136, 22);
            GothicFontToolStripMenuItem1.Text = "Gothic";
            GothicFontToolStripMenuItem1.Click += GothicFontToolStripMenuItem1_Click;
            // 
            // HelectiviaFontToolStripMenuItem
            // 
            HelectiviaFontToolStripMenuItem.Name = "HelectiviaFontToolStripMenuItem";
            HelectiviaFontToolStripMenuItem.Size = new Size(136, 22);
            HelectiviaFontToolStripMenuItem.Text = "Helectivia";
            HelectiviaFontToolStripMenuItem.Click += HelectiviaFontToolStripMenuItem1_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // RTFBox1
            // 
            RTFBox1.AcceptsTab = true;
            RTFBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RTFBox1.Location = new Point(0, 30);
            RTFBox1.Name = "RTFBox1";
            RTFBox1.Size = new Size(1334, 846);
            RTFBox1.TabIndex = 2;
            RTFBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1334, 877);
            Controls.Add(RTFBox1);
            Controls.Add(menuStrip1);
            Cursor = Cursors.AppStarting;
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "NotepadForLosers";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem CloseToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem BoldToolStripMenuItem;
        private ToolStripMenuItem italicsToolStripMenuItem;
        private ToolStripMenuItem UnderlineToolStripMenuItem;
        private ToolStripMenuItem fontsToolStripMenuItem;
        private ToolStripMenuItem ArialFontToolStripMenuItem;
        private ToolStripMenuItem HellFontToolStripMenuItem1;
        private ToolStripMenuItem ConsolasFontToolStripMenuItem;
        private ToolStripMenuItem GothicFontToolStripMenuItem1;
        private ToolStripMenuItem HelectiviaFontToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private RichTextBox RTFBox1;
    }
}