﻿using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Http;
using ChatApp.Models;
using ChatApp.Util;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ChatApp.Hubs
{
    public class RoomHub : Hub
    {
        public async override Task OnConnectedAsync()
        {
            ISession session = Context.GetHttpContext().Session;
            string userName = session.GetString("UserName");
            string roomName = session.GetString("RoomName");
            bool condition = !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(roomName);
            if (condition)
            {
                var dbContent = Context.GetHttpContext().GetDbContent();
                var room = dbContent.Rooms.FirstOrDefault(r => r.Name == roomName);
                var user = room.Users.FirstOrDefault(u => u.Username == userName);
                room.Users.Add(new User { Username = userName, UserConnectionId = Context.ConnectionId });
                await base.OnConnectedAsync();
            }
            else
            {
                await Clients.Caller.SendAsync("ErrorLogging", "Ошибка при входе в комнату. Попробуйте ещё раз");
            }
        }

        public async override Task OnDisconnectedAsync(Exception exception)
        {
            ISession session = Context.GetHttpContext().Session;
            string userName = session.GetString("UserName");
            string roomName = session.GetString("RoomName");
            bool condition = !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(roomName);
            if (condition)
            {
                var dbContent = Context.GetHttpContext().GetDbContent();
                var room = dbContent.Rooms.FirstOrDefault(r => r.Name == roomName);
                room.Users.Remove(room.Users.FirstOrDefault(u => u.Username == userName));
            }
            await base.OnDisconnectedAsync(exception);
        }
        public void MemberJoined(string roomName, string memberName)
        {     
            var httpContext = Context.GetHttpContext();
            var dbContent = httpContext.GetDbContent();

            var room = dbContent.Rooms.FirstOrDefault(r => r.Name == roomName);

            room.Users.Add(new User { Username = memberName, UserConnectionId = Context.ConnectionId });
            dbContent.SaveChanges();
        }
        public async Task MemberLeft(string roomName, string memberName)
        {
            var httpContext = GetHttpContextExtensions.GetHttpContext(Context);
            var dbContent = httpContext.GetDbContent();

            var room = dbContent.Rooms.FirstOrDefault(r => r.Name == roomName); 
            room.Users.Remove(room.Users.FirstOrDefault(u=>u.Username == memberName&&u.UserConnectionId==Context.ConnectionId));
            dbContent.SaveChanges();

            List<string> ids = this.GetIds(roomName);
            await Clients.Clients(ids).SendAsync("MemberLeft", memberName);
        }
        public async Task NewMessage(string roomName, string memberName, string message)
        {
            string time = DateTime.Now.ToShortTimeString();
            List<string> ids = this.GetIds(roomName);
            await Clients.Clients(ids).SendAsync("NewMessage", time, memberName, message.Trim());
        }
        
        public async Task RoomDeleted(string roomName)
        {
            var httpContext = GetHttpContextExtensions.GetHttpContext(Context);
            var dbContent = httpContext.GetDbContent();

            var rooms = dbContent.Rooms;
            var room = rooms.FirstOrDefault(r => r.Name == roomName);

            List<string> ids = this.GetIds(roomName);
            rooms.Remove(room);
            dbContent.SaveChanges();
            await Clients.Clients(ids).SendAsync("RoomDeleted");
        }
    }
}