using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace MetromecanicaApp
{
    public class MainWindowViewModel: PropertyChangedBase
    {
        private Visibility isDisplayHome;

        public Visibility IsDisplayHome
        {
            get { return isDisplayHome; }
            set { isDisplayHome = value;
                NotifyOfPropertyChange(() => IsDisplayHome);
            }
        }

        private Visibility isDisplayNuevo;

        public Visibility IsDisplayNuevo
        {
            get { return isDisplayNuevo; }
            set
            {
                isDisplayNuevo = value;
                NotifyOfPropertyChange(() => IsDisplayNuevo);
            }
        }

        public MainWindowViewModel()
        {
            IsDisplayHome = Visibility.Visible;
            IsDisplayNuevo = Visibility.Hidden;
        }

        public void Open_InicioViewModel()
        {
            IsDisplayHome = Visibility.Visible;
            IsDisplayNuevo = Visibility.Hidden;
        }

        public void Open_NuevoViewModel()
        {
            IsDisplayHome = Visibility.Hidden;
            IsDisplayNuevo = Visibility.Visible;
        }

        public void Open_AbrirViewModel()
        {
            IsDisplayHome = Visibility.Hidden;
        }
    }

    public class MovieData
    {
        private string _Title;
        public string Title
        {
            get { return this._Title; }
            set { this._Title = value; }
        }

        private BitmapImage _ImageData;
        public BitmapImage ImageData
        {
            get { return this._ImageData; }
            set { this._ImageData = value; }
        }
    }
}
