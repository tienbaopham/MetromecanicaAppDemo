using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using Caliburn.Micro;

namespace MetromecanicaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();

            DirectoryInfo forder = new DirectoryInfo("Assets");
            string linkImage = string.Empty;
            if (forder.Exists)
            {
                foreach (FileInfo item in forder.GetFiles())
                {
                    if (".jpg".Contains(item.Extension.ToLower()))
                    {
                        linkImage = item.FullName;
                    }
                }
            }

            int maxlenght = 30;
            var model = new MovieData[maxlenght];
            for (int i = 0; i < maxlenght; i++)
            {
                model[i] = new MovieData();
                model[i].Title = string.Format("Nombre{0}", i);
                model[i].ImageData = LoadImage(linkImage);
            }

            this.TvBox.ItemsSource = model;
        } 

        // for this code image needs to be a project resource
        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri(filename));
        }
    }
}
