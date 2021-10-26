using Chat_App.Models;
using System.Collections.Generic;
using System;


namespace Chat_App.Data 
{
    public interface IRoomRepo
    {
        IEnumerable<Room> GetAllRooms();
    }
}


