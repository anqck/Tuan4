using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        List<FontFamily> listFonts;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFonts = GetAllInstalledFonts();
            cbFontName.SelectedItem = "Tahoma";
            cbFontSize.SelectedItem = "14";
        }

        private List<FontFamily> GetAllInstalledFonts()
        {
            List<FontFamily> result = new List<FontFamily>();
            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    cbFontName.Items.Add(fa.Name);
                    result.Add(fa);
                }
            }
            return result;
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                richTextBox1.SelectionFont = new Font(listFonts[cbFontName.SelectedIndex], float.Parse(cbFontSize.SelectedItem.ToString()));
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }    
        }
    }
}
