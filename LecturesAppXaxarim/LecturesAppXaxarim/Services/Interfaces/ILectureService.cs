using LecturesAppXamarin.Domain.Lectures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LecturesAppXaxarim.Services.Interfaces
{
    public interface ILectureService
    {
        void Insert(Lecture lecture);
        Task<IEnumerable<Lecture>> GetAll();
    }
}
