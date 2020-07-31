using System;

namespace DatingApp.API.Models
{
    public class Photos
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        // USer and UserID ensure cascading delete, when user is deleted, photos are also deleted //
        public User User { get; set; }
        public int UserId { get; set; }
        //
    }
}