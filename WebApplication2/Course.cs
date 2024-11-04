﻿namespace WebApplication2
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students = new List<Student>(); 

        public Teacher Teacher { get; set; }

        public int Day { get; set; }

        public TimeOnly Begin_Hour { get; set; }
        public int Minutes { get; set; }


    }
}