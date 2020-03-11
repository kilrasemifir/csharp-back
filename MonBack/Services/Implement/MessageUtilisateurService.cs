using MonBack.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MonBack.Repositories;
namespace MonBack.Services.Implement
{
    using Models;
    using Repositories.Implements;
    public class MessageUtilisateurService : MessageService
    {
        private MessageRepository respository;

        public MessageUtilisateurService()
        {
            this.respository = new MessageMySQLRepository();
        }
        public MessageDTO Envoyer(MessageDTO message)
        {
            MessageModel dto = this.respository.Save(new MessageModel(0, message.Message, message.Utilisateur));
            return new MessageDTO(dto.Message, dto.Utilisateur);
        }

        public List<MessageDTO> RecupererMessages()
        {
            throw new NotImplementedException();
        }
    }
}
