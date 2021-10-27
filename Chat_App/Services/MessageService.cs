using Chat_App.Data.Repository;
using Chat_App.Models;
using System;
using System.Collections.Generic;

namespace Chat_App.Services
{
    public class MessageService:IMessageRepositpry
    {
            public IEnumerable<Message> GetAllMessages()
            {
                throw new NotImplementedException();
            }

            public Message GetMessageById(int id)
            {
                throw new NotImplementedException();
            }
    }
}
