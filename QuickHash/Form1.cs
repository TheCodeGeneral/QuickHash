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
        //Dictionary<string, string> results;
        string filePath;
        Dictionary<string, HashAlgorithm> hashAlgorithms;
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

            await Task.Run(() => displayResults(this.filePath));
        }
        // Copy selected item in dropdown into clipboard
        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(this.results[cmbHashAlgo.Text]);
        }
        // Display results in lblHashResults
        private void displayResults(string filePath)
        {
            byte[] fileBuf = File.ReadAllBytes(filePath);

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

            // Update hash results label
            Task.Run(() =>
            {
                string sha1 = GetHash(fileBuf, SHA1.Create());
                txtSha1.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    txtSha1.Text = "Sha1:\t" + sha1;
                });
            });

            Task.Run(() =>
            {
                string sha256 = GetHash(fileBuf, SHA256.Create());
                txtSha256.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    txtSha256.Text = "Sha256:\t" + sha256;
                });
            });
            Task.Run(() =>
            {
                string sha384 = GetHash(fileBuf, SHA384.Create());
                txtSha384.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    txtSha384.Text = "Sha384:\t" + sha384;
                });
            });
            Task.Run(() =>
            {
                string sha512 = GetHash(fileBuf, SHA512.Create());
                txtSha512.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    txtSha512.Text = "Sha512:\t" + sha512;
                });
            });
            Task.Run(() =>
            {
                string md5 = GetHash(fileBuf, MD5.Create());
                txtMd5.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    txtMd5.Text = "Md5:\t" + md5;
                });
            });
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }
        // Compute the file's hash
        private string GetHash(byte[] fileBuf, HashAlgorithm hashAlgo)
        {
            string hash = "";
            byte[] rawHash = hashAlgo.ComputeHash(fileBuf);

            foreach (byte b in rawHash)
            {
                hash += b.ToString("x2");
            }

            return hash;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                displayResults(openFileDialog1.FileName);
            }
        }
    }
}
