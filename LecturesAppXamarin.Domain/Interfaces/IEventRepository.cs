using LecturesAppXamarin.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace LecturesAppXamarin.Domain.Interfaces
{
    public interface IEventRepository : IRepository<Event>
    {
    }
}
