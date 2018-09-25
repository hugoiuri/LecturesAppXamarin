using LecturesAppXamarin.Domain.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LecturesAppXamarin.Domain.Lectures
{
    [Table("Lectures")]
    public class Lecture: Entity
    {
        public string LectureName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
    }
}
