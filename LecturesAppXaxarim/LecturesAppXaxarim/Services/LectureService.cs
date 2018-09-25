using LecturesAppXamarin.Domain.Interfaces;
using LecturesAppXamarin.Domain.Lectures;
using LecturesAppXaxarim.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LecturesAppXaxarim.Services
{
    class LectureService : ILectureService
    {
        private readonly ILectureRepository LectureRepository;

        public LectureService(ILectureRepository lectureRepository)
        {
            LectureRepository = lectureRepository;
        }

        public void Insert(Lecture lecture)
        {
            LectureRepository.Insert(lecture);
        }

        public Task<IEnumerable<Lecture>> GetAll()
        {
            return LectureRepository.GetAll();
        }
    }
}
