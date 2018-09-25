using LecturesAppXamarin.Domain.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LecturesAppXamarin.Domain.Events
{
    [Table("Events")]
    public class Event : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
    }
}
