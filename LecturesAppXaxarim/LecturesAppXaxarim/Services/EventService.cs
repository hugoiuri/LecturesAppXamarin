using LecturesAppXamarin.Domain.Events;
using LecturesAppXamarin.Domain.Interfaces;
using LecturesAppXaxarim.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LecturesAppXaxarim.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository EventRepository;

        public EventService(IEventRepository eventRepository)
        {
            EventRepository = eventRepository;
        }

        public void Insert(Event _event)
        {
            EventRepository.Insert(_event);
        }

        public Task<Event> Get()
        {
            return EventRepository.GetFirst();
        }

        public void UpdateData()
        {
            Event _event = getEvent();

            EventRepository.Clear();
            EventRepository.Insert(_event);
        }

        /// <summary>
        /// Simula uma consulta a uma API de Eventos
        /// Estamos mocando esta parte para manter o aplicativo offline
        /// </summary>
        /// <returns></returns>
        private Event getEvent()
        {
            Event _event = new Event
            {
                Name = "Agile Minas Conference",
                Description = "O Agile Minas Conference promoverá o networking entre os participantes e os conceitos sobre agilidade no desenvolvimento de projetos, entregando um conteúdo de peso com opções que atendam a um público variado, conectando os participantes a pessoas que passam pelo mesmo desafio e que tiveram diferentes aprendizados e fortalecendo a comunidade local. O evento é destinado a todos aqueles que já trabalham com métodos ágeis ou desejam começar a mergulhar neste universo, quer sejam de áreas técnicas, estratégicas ou de gestão e em todos os níveis de experiência em agilidade (iniciantes, praticantes ou experientes).",
                ImageSource = "https://www.agileminas.com.br/2018/images/featured-speaker-two2.jpg"
            };

            return _event;
        }
    }
}
