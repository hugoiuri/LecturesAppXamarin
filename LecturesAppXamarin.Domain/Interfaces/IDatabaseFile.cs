using System;
using System.Collections.Generic;
using System.Text;

namespace LecturesAppXamarin.Domain.Interfaces
{
    public interface IDatabaseFile
    {
        string GetFilePath(string file);
    }
}
