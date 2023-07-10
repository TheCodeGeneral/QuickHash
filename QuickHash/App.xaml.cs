using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace QuickHash
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow wnd;
            switch(e.Args.Length)
            {
                // No arguments provided Open GUI
                case 0:
                    wnd = new MainWindow();
                    wnd.Show();
                    break;

                // If help flag passed display help
                // If file doesn't exist display help
                // Open GUI passing filepath
                case 1:
                    if(!System.IO.File.Exists(e.Args[0]))
                    {
                        return;
                    }

                    wnd = new MainWindow(e.Args[0]);
                    wnd.Show();
                    break;

                // If help flag passed display help
                // If file doesn't exist display help
                // If search flag passed, open web browser to VirusTotal with file hash
                case 2:
                    if (!System.IO.File.Exists(e.Args[0]))
                    {
                        return;
                    }
                    else if (e.Args[1] == "-s" || e.Args[1] == "--search")
                    {
                        wnd = new MainWindow(e.Args[0], true);
                    }
                    break;

                default:
                    return;
            }
        }
    }
}
