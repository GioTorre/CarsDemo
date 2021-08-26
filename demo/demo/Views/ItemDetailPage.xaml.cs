using demo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace demo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}