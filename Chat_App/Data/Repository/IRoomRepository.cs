using Chat_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_App.Data.Repository
{
    interface IRoomRepository
    {
        IEnumerable<Room> GetAllRooms();

        Room GetRoomById(int id);

    }
}
