using Chat_App.Models;
using System.Collections.Generic;
using System;


namespace Chat_App.Data
{
    public class MockMessageRepo : IMessageRepo
    {
       public IEnumerable<Message> GetAllMessages()
        {
            throw new NotImplementedException();
        }
    }
}
