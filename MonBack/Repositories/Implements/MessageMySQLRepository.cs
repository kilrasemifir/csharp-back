using MonBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonBack.Repositories.Implements
{
    public class MessageMySQLRepository : MessageRepository
    {
        private List<MessageModel> data = new List<MessageModel>();
        
        public List<MessageModel> FindAll()
        {
            return data;
        }

        public MessageModel Save(MessageModel message)
        {
            data.Add(message);
            message.Id = data.Count();
            return message;
        }
    }
}
