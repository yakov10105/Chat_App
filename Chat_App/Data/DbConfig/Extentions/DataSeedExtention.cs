using Chat_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_App.Data.DbConfig.Extentions
{
    public static class DataSeedExtention
    {
        public static void SeedData(this ModelBuilder builder)
        {

            Room room = new Room
            {
                Id = 1,
                RoomName = "חרא על מכללת סלע",
                Members= new List<User>()
            };
            User yakov = new User
            {
                Id = 1,
                FirstName = "Yakov",
                LastName = "Kantor",
                UserName = "Yakov10105",
                UserEmail = "Yakov@gmail.com",
                Password = "1234",
                ConfirmPassword = "1234",
                UserAge = 22,
                RecievedMessages = new List<Message>(),
                SendedMessages=new List<Message>(),
                RoomId=1

            };
            User idan = new User
            {
                Id = 2,
                FirstName = "Idan",
                LastName = "Barzilai",
                UserName = "Idan111",
                UserEmail = "Idan@gmail.com",
                Password = "1234",
                ConfirmPassword = "1234",
                UserAge = 22,
                RecievedMessages = new List<Message>(),
                SendedMessages = new List<Message>(),
                RoomId=1
            };
            Message message = new Message
            {
                Id = 1,
                Date = DateTime.Now,
                RecieverId = 2,
                SenderId = 1,
                Text = "Asfadsfwadfgdwfv",
                
            };
            builder.Entity<User>().HasData(idan,yakov);
            builder.Entity<Message>().HasData(message);
            builder.Entity<Room>().HasData(room);
        }
    }
}
