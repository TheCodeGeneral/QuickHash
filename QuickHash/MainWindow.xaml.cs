using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuickHash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void HashAll(string filePath)
        {
            byte[] fileBuf = File.ReadAllBytes(filePath);

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            // Update hash results label
            Task.Run(() =>
            {
                string sha1 = GetHash(fileBuf, SHA1.Create());
                this.Dispatcher.Invoke(() => {
                    txtSha1.Text = sha1;
                });
            });
            Task.Run(() =>
            {
                string sha256 = GetHash(fileBuf, SHA256.Create());
                this.Dispatcher.Invoke(() => {
                    txtSha256.Text = sha256;
                });
            });
            Task.Run(() =>
            {
                string sha384 = GetHash(fileBuf, SHA384.Create());
                this.Dispatcher.Invoke(() => {
                    txtSha384.Text = sha384;
                });
            });
            Task.Run(() =>
            {
                string sha512 = GetHash(fileBuf, SHA512.Create());
                this.Dispatcher.Invoke(() => {
                    txtSha512.Text = sha512;
                });
            });
            Task.Run(() =>
            {
                string md5 = GetHash(fileBuf, MD5.Create());
                this.Dispatcher.Invoke(() => {
                    txtMd5.Text = md5;
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
        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                HashAll(openFileDialog.FileName);
            }
        }

        private void btnCopyAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSearchOnline_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuEditPrefs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
