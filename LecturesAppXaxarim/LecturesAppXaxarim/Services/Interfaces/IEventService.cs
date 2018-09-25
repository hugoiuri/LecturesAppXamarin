using LecturesAppXamarin.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LecturesAppXaxarim.Services.Interfaces
{
    public interface IEventService
    {
        void Insert(Event _event);
        Task<Event> Get();
        void UpdateData();
    }
}
