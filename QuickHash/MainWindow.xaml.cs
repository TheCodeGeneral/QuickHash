using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
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
        public MainWindow(string filepath = "", bool search = false)
        {
            if(filepath != "")
            {
                if(search)
                {
                    SearchOnline(Hash(filepath));
                    System.Windows.Application.Current.Shutdown();
                }
                else
                {
                    OpenFile(filepath);
                }
            }
            InitializeComponent();
        }
        // Compute hash of provided file and update the corresponding labels
        private void HashAll(byte[] fileBuf)
        {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            Task.Run(() =>
            {
                byte[] sha1Hash = SHA1.HashData(fileBuf);
                string sha1 = ConvertHash(ref sha1Hash);
                this.Dispatcher.Invoke(() => 
                {
                    txtSha1.Text = sha1;
                });
            });
            Task.Run(() =>
            {
                byte[] sha256Hash = SHA256.HashData(fileBuf);
                string sha256 = ConvertHash(ref sha256Hash);
                this.Dispatcher.Invoke(() => 
                {
                    txtSha256.Text = sha256;
                });
            });
            Task.Run(() =>
            {
                byte[] sha384Hash = SHA384.HashData(fileBuf);
                string sha384 = ConvertHash(ref sha384Hash);
                this.Dispatcher.Invoke(() => 
                {
                    txtSha384.Text = sha384;
                });
            });
            Task.Run(() =>
            {
                byte[] sha512Hash = SHA512.HashData(fileBuf);
                string sha512 = ConvertHash(ref sha512Hash);
                this.Dispatcher.Invoke(() => 
                {
                    txtSha512.Text = sha512;
                });
            });
            Task.Run(() =>
            {
                byte[] md5Hash = MD5.HashData(fileBuf);
                string md5 = ConvertHash(ref md5Hash);
                this.Dispatcher.Invoke(() => 
                {
                    txtMd5.Text = md5;
                });
            });
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }

        
        // Compute hash of provided file and update the corresponding labels
        private void HashAll(Stream fileStream)
        {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            Task.Run(() =>
            {
                byte[] sha1Hash = SHA1.HashData(fileStream);
                string sha1 = ConvertHash(ref sha1Hash);
                this.Dispatcher.Invoke(() =>
                {
                    txtSha1.Text = sha1;
                });

                byte[] sha256Hash = SHA256.HashData(fileStream);
                string sha256 = ConvertHash(ref sha256Hash);
                this.Dispatcher.Invoke(() =>
                {
                    txtSha256.Text = sha256;
                });

                byte[] sha384Hash = SHA384.HashData(fileStream);
                string sha384 = ConvertHash(ref sha384Hash);
                this.Dispatcher.Invoke(() =>
                {
                    txtSha384.Text = sha384;
                });

                byte[] sha512Hash = SHA512.HashData(fileStream);
                string sha512 = ConvertHash(ref sha512Hash);
                this.Dispatcher.Invoke(() =>
                {
                    txtSha512.Text = sha512;
                });

                byte[] md5Hash = MD5.HashData(fileStream);
                string md5 = ConvertHash(ref md5Hash);
                this.Dispatcher.Invoke(() =>
                {
                    txtMd5.Text = md5;
                });
            });
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }

        private string Hash(string filepath)
        {
            FileStream f = File.OpenRead(filepath);

            byte[] sha1Hash = SHA1.HashData(f);
            return ConvertHash(ref sha1Hash);
        }
        // Convert the file's hash into a string
        private string ConvertHash(ref byte[] rawHash)
        {
            string hash = "";

            foreach (byte b in rawHash)
            {
                hash += b.ToString("x2");
            }

            return hash;
        }
        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }
        private void OpenFile(string filePath = "")
        {
            if(filePath == "")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            FileInfo fi = new(filePath);
            if (fi.Length < 2000000000)
            {
                HashAll(File.ReadAllBytes(filePath));
            }
            else
            {
                HashAll(File.OpenRead(filePath));
            }
        }
        private void btnCopyAll_Click(object sender, RoutedEventArgs e)
        {
            string allHashes = "Sha1:\t" + txtSha1.Text +
                "\nSha256:\t" + txtSha256.Text +
                "\nSha384:\t" + txtSha384.Text +
                "\nSha512:\t" + txtSha512 +
                "\nMd5:\t" + txtMd5.Text;
            Clipboard.SetText(allHashes);
        }

        private void btnSearchOnline_Click(object sender, RoutedEventArgs e)
        {
            SearchOnline();
        }
        private void SearchOnline(string hash = "")
        {
            if(hash == "")
            {
                hash = GetSelectedHash();
            }
            try
            {
                System.Diagnostics.Process.Start("cmd", "/c start http://www.virustotal.com/gui/file/" + hash);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(GetSelectedHash());
        }
        private string GetSelectedHash()
        {
            switch (cmbHashSelection.SelectedIndex)
            {
                case 0:
                    return txtSha1.Text;
                case 1:
                    return txtSha256.Text;
                case 2:
                    return txtSha384.Text;
                case 3:
                    return txtSha512.Text;
                case 4:
                    return txtMd5.Text;
                default:
                    MessageBox.Show("Error getting selected hash value: Index out of bounds");
                    return "";
            }
        }

        private void mnuEditPrefs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
