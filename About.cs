using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Path.GetTempPath() + "changelog.txt",
                "Update 1.0: \n-Added decimal point\n-Added funcionality for keyboard\n-Fixed bugs\n-Added clear all button\n-Added delet button\n-Changed authors name from Jupiter090 to Matej Planeta as Matej Planeta is my real name and Jupiter090 is just nickname ;)");
            Process.Start("notepad.exe", Path.GetTempPath() + "changelog.txt");
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try{
                File.Delete(Path.GetTempPath() + "changelog.txt");
            }
            catch
            {

            }
        }
    }
}
