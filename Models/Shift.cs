﻿namespace D_MartApp.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

    }
}
