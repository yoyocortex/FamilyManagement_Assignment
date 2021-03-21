using System.Collections.Generic;
using Family.Models;

namespace FileData
{
    public interface IFileContextAdapter
    {
        IList<Adult> GetAllAdults();
        void AddAnAdult(Adult adult);
    }
}