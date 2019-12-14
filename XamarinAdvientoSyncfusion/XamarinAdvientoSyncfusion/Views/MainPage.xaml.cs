using Xamarin.Forms;
using XamarinAdvientoSyncfusion.ViewModels;

namespace XamarinAdvientoSyncfusion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new PerfilUsuarioViewModel();
        }
    }
}
