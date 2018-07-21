using EventManager.Domain;

namespace EventManager.Web.Api.Services
{
    // Eu gosto de botar a interface e a implementação da app no mesmo arquivo, não acho má idéia
    // A única exceção seria se você tem várias implementações da mesma interface providas pelo mesmo app
    public interface IEventService
    {
        Event Retrieve(long id);

        void Create(Event evt);

        void Subscribe(long subscriberId, long eventId);
    }

    // Essa implementação usaria o EF como dependência pra fazer as operações de banco
    public class EventService : IEventService
    {
        public void Create(Event evt)
        {
            throw new System.NotImplementedException();
        }

        public Event Retrieve(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Subscribe(long subscriberId, long eventId)
        {
            throw new System.NotImplementedException();
        }
    }
}
