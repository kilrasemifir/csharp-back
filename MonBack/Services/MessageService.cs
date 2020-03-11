using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MonBack.DTO;
using MonBack.Models;
namespace MonBack.Services
{
    interface MessageService
    {
        public MessageDTO Envoyer(MessageDTO message);
        public List<MessageDTO> RecupererMessages();

    }
}
