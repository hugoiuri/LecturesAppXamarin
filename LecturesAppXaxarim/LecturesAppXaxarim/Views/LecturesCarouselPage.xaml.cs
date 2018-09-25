using CommonServiceLocator;
using LecturesAppXamarin.Domain.Lectures;
using LecturesAppXaxarim.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LecturesAppXaxarim.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LecturesCarouselPage : CarouselPage
    {
        public LecturesCarouselPage()
        {
            InitializeComponent();
            var viewModel = ServiceLocator.Current.GetInstance<LecturesCarouselPageViewModel>();
            BindingContext = viewModel;
            ItemsSource = viewModel.Lectures;
        }
    }
}
