using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonBack.DTO
{
    

    public class MessageDTO
    {
        public string Message { get; set; }
        public string Utilisateur { get; set; }

        public MessageDTO(string message, string utilisateur)
        {
            Message = message;
            Utilisateur = utilisateur;
        }
    }
}
