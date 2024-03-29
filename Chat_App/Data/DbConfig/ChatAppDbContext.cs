﻿using Chat_App.Data.DbConfig.Extentions;
using Chat_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.Data.DbConfig
{
    public class ChatAppDbContext:DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Room> Rooms { get; set; }

        public virtual DbSet<Message> Messages{ get; set; }

        public ChatAppDbContext(DbContextOptions<ChatAppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Reciever)
                .WithMany(s => s.RecievedMessages)
                .HasForeignKey(u => u.SenderId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(s => s.SendedMessages)
                .HasForeignKey(u => u.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Room)
            //    .WithMany(r => r.Members);
            ////modelBuilder.Entity<Room>()
            ////    .HasMany


            modelBuilder.SeedData();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
