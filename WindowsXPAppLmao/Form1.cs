using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsXPAppLmao
{
    public partial class Form1 : Form
    {
        //init
        InstalledFontCollection fonts = new InstalledFontCollection();
        FontFamily[] fontList;
        Random random = new Random();
        int fontCount;

        string[] badFonts = {
          "Estrangelo Edessa",
          "Gautami", "Latha",
          "Mangal", "Marlett",
          "MV Boli", "Raavi",
          "Shruti", "Symbol",
          "Tunga", "Webdings",
          "Wingdings"
        };

        public Form1()
        {
            InitializeComponent();

            fontList = fonts.Families
                .Where(f => !badFonts.Contains(f.Name))
                .ToArray();
            fontCount = fontList.Length;
        }

        //links
        string website = "https://www.shaunclarke.co.uk";
        string github = "https://github.com/shaunclarke04/WindowsXPAppLmao";

        //link buttons
        private void btnWebsite_Click(object sender, EventArgs e)
        {
            visitLink(website);
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            visitLink(github);
        }

        //methods
        public void visitLink(string link)
        {
            Process.Start(link);
        }
        public void RandomizeBGColour()
        {
            this.BackColor = Color.FromArgb(
                random.Next(1, 256),
                random.Next(1, 256),
                random.Next(1, 156)
            );
        }
        public void RandomiseTitleFGColour()
        {
            label1.ForeColor = Color.FromArgb(
                random.Next(1, 256),
                random.Next(1, 256),
                random.Next(1, 156)
            );
        }
        public void RandomiseTitleBGColour()
        {
            label1.BackColor = Color.FromArgb(
                random.Next(1, 256),
                random.Next(1, 256),
                random.Next(1, 156)
            );
        }
        public void RandomiseTitleFont()
        {
            FontFamily font = fontList[random.Next(0, fontCount)];
            label1.Font = new Font(font, label1.Font.Size);
        }

        //button handlers
        private void btnBGColour_Click(object sender, EventArgs e)
        {
            RandomizeBGColour();
        }

        private void btnTitleFGColour_Click(object sender, EventArgs e)
        {
            RandomiseTitleFGColour();
        }
        private void btnTitleBGColour_Click(object sender, EventArgs e)
        {
            RandomiseTitleBGColour();
        }
        private void btnTitleBothColour_Click(object sender, EventArgs e)
        {
            RandomiseTitleFGColour();
            RandomiseTitleBGColour();
        }

        private void btnTitleFont_Click(object sender, EventArgs e)
        {
            RandomiseTitleFont();
        }

        //Menu Strip
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "(c) Shaun Clarke 2026\nWindows XP App lmao v1.0\nDeveloped for fun while fucking around in a windows XP VM",
                "Windows XP App lmao",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void visitWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitLink(website);
        }

        private void visitGithubRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitLink(github);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Choose an element to randomize",
                "Error_001",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomizeBGColour();
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomiseTitleFGColour();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomiseTitleBGColour();
        }

        private void bothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomiseTitleBGColour();
            RandomiseTitleFGColour();
        }

        private void titleFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomiseTitleFont();
        }
    }
}
