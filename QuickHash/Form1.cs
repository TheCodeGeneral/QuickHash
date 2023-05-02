using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickHash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hashAlgoComboBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hashAlgoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Compute Hash
            // Update lblHashResult
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblHashResult.Text);

        }
    }
}
