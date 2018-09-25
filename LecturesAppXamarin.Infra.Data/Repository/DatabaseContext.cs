using LecturesAppXamarin.Domain.Interfaces;
using LecturesAppXamarin.Domain.Lectures;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LecturesAppXamarin.Infra.Data.Repository
{
    public class DatabaseContext
    {
        static DatabaseContext DatabaseSingleton;
        static SQLiteAsyncConnection Conn;

        public static SQLiteAsyncConnection Database
        {
            get
            {
                if (DatabaseSingleton == null)
                    DatabaseSingleton = new DatabaseContext();

                return Conn;
            }
        }

        public DatabaseContext()
        {
            var dbPath = DependencyService.Get<IDatabaseFile>().GetFilePath("lectures.db3");
            Conn = new SQLiteAsyncConnection(dbPath);

            Conn.CreateTableAsync<Lecture>().Wait();
        }
    }
}
