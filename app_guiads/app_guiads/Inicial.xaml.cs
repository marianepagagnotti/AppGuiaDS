using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_guiads
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicial : ContentPage
    {

        public class ImageInformation
        {
            public ImageSource _Image { get; set; }
        }
        private ObservableCollection<ImageInformation> imageCollection;

        public ObservableCollection<ImageInformation> ImageCollection
        {
            get { return imageCollection; }
            set
            {
                imageCollection = value;
                OnPropertyChanged();
            }
        }
        
            public Inicial()
        {
            InitializeComponent();

            BindingContext = this;
            ImageCollection = new ObservableCollection<ImageInformation>
            {
                new ImageInformation{ _Image ="foto1.jpg" },
                new ImageInformation{ _Image ="foto2.jpg" },
                new ImageInformation{ _Image ="foto3.jpg" }
            };
        }
    }
}