using LecturesAppXamarin.Domain.Interfaces;
using LecturesAppXamarin.Domain.Lectures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LecturesAppXamarin.Infra.Data.Repository
{
    public class LectureRepository : SqLiteRepository<Lecture>, ILectureRepository
    {
    }
}
