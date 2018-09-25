using LecturesAppXamarin.Domain.Events;
using LecturesAppXamarin.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LecturesAppXamarin.Infra.Data.Repository
{
    public class EventRepository : SqLiteRepository<Event>, IEventRepository
    {
    }
}
