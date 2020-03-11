using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MonBack.Models;
namespace MonBack.Repositories
{
    public interface MessageRepository
    {
        public MessageModel Save(MessageModel message);
        public List<MessageModel> FindAll();
    }
}
