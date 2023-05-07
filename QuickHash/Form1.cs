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
        Dictionary<string, HashAlgorithm> hashAlgorithms;
        Dictionary<string, string> results;
        string filePath;
        public Form1(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            hashAlgorithms = new Dictionary<string, HashAlgorithm>() { { "SHA1", SHA1.Create() }, { "SHA256", SHA256.Create() }, { "SHA384", SHA384.Create() }, { "SHA512", SHA512.Create() }, { "MD5", MD5.Create() } };
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            foreach (string hashAlgo in this.hashAlgorithms.Keys)
            {
                cmbHashAlgo.Items.Add(hashAlgo);
            }
            cmbHashAlgo.SelectedIndex = 0;

            await Task.Run(() => displayResults());
        }
        // Copy selected item in dropdown into clipboard
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.results[cmbHashAlgo.Text]);
        }
        // Display results in lblHashResults
        private async void displayResults()
        {
            results = GetHash(filePath);

            string output = "";
            foreach (string hashAlgo in results.Keys)
            {
                output += hashAlgo + ":    " + results[hashAlgo] + "\n";
            }
            lblHashResult.Invoke((MethodInvoker)delegate {
                // Running on the UI thread
                lblHashResult.Text = output;
            });
        }
        // Compute the file's hash
        private Dictionary<string, string> GetHash(string filename)
        {
            results = new Dictionary<string, string>();
            hashAlgorithms = new Dictionary<string, HashAlgorithm>() { { "SHA1", SHA1.Create() }, { "SHA256", SHA256.Create() }, { "SHA384", SHA384.Create() }, { "SHA512", SHA512.Create() }, { "MD5", MD5.Create() } };
            byte[] fileBuf = File.ReadAllBytes(filePath);
            foreach(string hashAlgo in hashAlgorithms.Keys)
            {
                byte[] rawHash;
                string hash = "";

                rawHash = hashAlgorithms[hashAlgo].ComputeHash(fileBuf);

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
