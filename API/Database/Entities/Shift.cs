﻿using Schedule.Models;

namespace Schedule.Database.Entities
{
    public class Shift
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime DateTime { get; set; }
        public Role Role { get; set; }
        public int? UserId { get; set; }
    }
}