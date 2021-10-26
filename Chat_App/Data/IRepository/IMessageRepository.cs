using Chat_App.Models;
using System.Collections.Generic;
using System;


namespace Chat_App.Data.IRepository
{
    public interface IMessageRepositpry
    {
        IEnumerable<Message> GetAllMessages();

        Message GetMessageById(int id);
    }
}
