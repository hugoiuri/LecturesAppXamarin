using LecturesAppXamarin.Domain.Lectures;
using LecturesAppXaxarim.Services.Interfaces;
using LecturesAppXaxarim.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LecturesAppXaxarim.ViewModels
{
    public class LecturesCarouselPageViewModel : ViewModelBase
    {
        private readonly ILectureService LectureService;

        public ObservableCollection<Lecture> Lectures{ get; set; }


        public LecturesCarouselPageViewModel(ILectureService lectureService)
        {
            LectureService = lectureService;
            Lectures = new ObservableCollection<Lecture>();
            GetAll();
        }

        public async Task GetAll()
        {
            var lectures = await LectureService.GetAll();

            if (Lectures.Count > 0)
            {
                Lectures.Clear();
            }

            foreach (var lecture in lectures)
            {
                Lectures.Add(lecture);
            }
        }
    }
}
