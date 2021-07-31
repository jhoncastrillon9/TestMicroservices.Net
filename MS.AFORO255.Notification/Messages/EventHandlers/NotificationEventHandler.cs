using Aforo255.Cross.Event.Src.Bus;
using MS.AFORO255.Notification.Messages.Events;
using MS.AFORO255.Notification.Models;

using System.Threading.Tasks;

namespace MS.AFORO255.Notification.Messages.EventHandlers
{
    public class NotificationEventHandler : IEventHandler<NotificationCreatedEvent>
    {
       

        public NotificationEventHandler()
        {
          
        }

        public Task Handle(NotificationCreatedEvent @event)
        {
            //_historyService.Add(new HistoryTransaction()
            //{
            //    IdTransaction = @event.IdTransaction,
            //    Amount = @event.Amount,
            //    Type = @event.Type,
            //    CreationDate = @event.CreationDate,
            //    AccountId = @event.AccountId

            //});
            return Task.CompletedTask;
        }
    }

}

