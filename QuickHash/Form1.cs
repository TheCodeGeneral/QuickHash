using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.CompilerServices;

namespace QuickHash
{
    public partial class Form1 : Form
    {
        // Hashes currently supported
        Dictionary<string, HashAlgorithm> hashAlgorithms = new Dictionary<string, HashAlgorithm>() { { "SHA1", SHA1.Create() }, { "SHA256", SHA256.Create() }, { "SHA384", SHA384.Create() }, { "SHA512", SHA512.Create() }, { "MD5", MD5.Create() } };
        Dictionary<string, string> results;
        string filePath;
        public Form1(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string hashAlgo in this.hashAlgorithms.Keys)
            {
                cmbHashAlgo.Items.Add(hashAlgo);
            }
            cmbHashAlgo.SelectedIndex = 0;
            

            results = GetHash(filePath);
            displayResults();
        }
        // Copy selected item in dropdown into clipboard
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.results[cmbHashAlgo.Text]);
        }
        // Display results in lblHashResults
        private void displayResults()
        {
            string output = "";
            foreach(string hashAlgo in results.Keys) 
            {
                output += hashAlgo + ":    " + results[hashAlgo] + "\n";
            }
            lblHashResult.Text = output;
        }
        // Compute the file's hash
        private Dictionary<string, string> GetHash(string filename)
        {
            results = new Dictionary<string, string>();

            foreach (string hashAlgo in hashAlgorithms.Keys)
            {
                byte[] rawHash;
                string hash = "";

                using (FileStream stream = File.OpenRead(filename))
                {
                    rawHash = hashAlgorithms[hashAlgo].ComputeHash(stream);
                }

                foreach (byte b in rawHash)
                {
                    hash += b.ToString("x2");
                }
                results[hashAlgo] = hash;
            }

            return results;
        }
    }
}
