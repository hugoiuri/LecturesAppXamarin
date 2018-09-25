using CommonServiceLocator;
using LecturesAppXamarin.Domain.Interfaces;
using LecturesAppXamarin.Infra.Data.Repository;
using LecturesAppXaxarim.Services;
using LecturesAppXaxarim.Services.Interfaces;
using LecturesAppXaxarim.Views;
using System;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LecturesAppXaxarim
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var unityContainer = new UnityContainer();

            unityContainer.RegisterType<ILectureService, LectureService>();
            unityContainer.RegisterType<ILectureRepository, LectureRepository>();

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(unityContainer));

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
