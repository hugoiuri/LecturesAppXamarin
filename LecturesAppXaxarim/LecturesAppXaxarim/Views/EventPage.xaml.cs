using CommonServiceLocator;
using LecturesAppXaxarim.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LecturesAppXaxarim.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventPage : ContentPage
	{
		public EventPage ()
		{
			InitializeComponent ();
            var viewModel = ServiceLocator.Current.GetInstance<EventPageViewModel>();
            BindingContext = viewModel;
        }
	}
}