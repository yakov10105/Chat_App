using Chat_App.Data.IRepository;
using Chat_App.Models;
using System;
using System.Collections.Generic;

namespace Chat_App.Services
{
    public class RoomService:IRoomRepository
    {
        public IEnumerable<Room> GetAllRooms()
        {
            throw new NotImplementedException();
        }

        public Room GetRoomById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
