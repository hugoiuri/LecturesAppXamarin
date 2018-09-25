using LecturesAppXamarin.Domain.Interfaces;
using LecturesAppXamarin.Domain.Lectures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LecturesAppXamarin.Infra.Data.Repository
{
    public class LectureRepository : SqLiteRepository<Lecture>, ILectureRepository
    {
        public async Task Clear()
        {
            await DatabaseContext.Database.DeleteAllAsync<Lecture>();
        }
    }
}
