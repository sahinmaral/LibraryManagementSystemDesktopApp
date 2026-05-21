using System;

namespace LibraryManagementSystem.Models
{
    public class Person
    {
        public static string Id { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string TurkishId { get; set; }
        public static bool IsPenalty { get; set; }
        public static DateTime PenaltyEndDate { get; set; }
    }
}
