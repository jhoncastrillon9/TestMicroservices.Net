using Aforo255.Cross.Event.Src.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS.AFORO255.Notification.Messages.Commands
{
    public class NotificationCreateCommand : Command
    {
        public int IdTransaction { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string MessageBody { get; protected set; }
        public string Address { get; protected set; }
        public int AccountId { get; set; }

        public NotificationCreateCommand(int idTransaction, decimal amount, string type, string messageBody, string adress, int accountId)
        {
            IdTransaction = idTransaction;
            Amount = amount;
            Type = type;
            MessageBody = messageBody;
            Address = adress;
            AccountId = accountId;
        }

    }
}
