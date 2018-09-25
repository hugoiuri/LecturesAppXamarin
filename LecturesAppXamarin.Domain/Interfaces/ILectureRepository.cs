using LecturesAppXamarin.Domain.Lectures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LecturesAppXamarin.Domain.Interfaces
{
    public interface ILectureRepository : IRepository<Lecture>
    {
        Task Clear();
    }
}
