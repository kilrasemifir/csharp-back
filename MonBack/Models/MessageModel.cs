using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonBack.Models
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Utilisateur { get; set; }

        public MessageModel(int id, string message, string utilisateur)
        {
            Id = id;
            Message = message;
            Utilisateur = utilisateur;
        }

        public MessageModel()
        {
        }
    }
}
