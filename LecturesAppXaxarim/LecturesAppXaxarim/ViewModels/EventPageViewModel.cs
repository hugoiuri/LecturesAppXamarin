using LecturesAppXamarin.Domain.Events;
using LecturesAppXaxarim.Services.Interfaces;
using LecturesAppXaxarim.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LecturesAppXaxarim.ViewModels
{
    public class EventPageViewModel : ViewModelBase
    {
        private readonly IEventService EventService;

        private string name;
        private string description;
        private string imageSource;

        public string Name {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }
        public string ImageSource
        {
            get { return imageSource; }
            set { SetProperty(ref imageSource, value); }
        }

        public EventPageViewModel(IEventService eventService)
        {
            EventService = eventService;
            GetFirst();
        }

        public async Task GetFirst()
        {
            Event _event = await EventService.Get();

            Name = _event.Name;
            Description = _event.Description;
            ImageSource = _event.ImageSource;
        }
    }
}
