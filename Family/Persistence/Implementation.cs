using System;
using System.Collections.Generic;
using System.Linq;
using Family.Models;

namespace FileData
{
    public class Implementation : IFileContextAdapter
    {
        private IList<Adult> adults;
        private FileContext fileContext;

        public Implementation()
        {
            adults = new List<Adult>();
            fileContext = new FileContext();
            adults = fileContext.Adults;
        }

        public IList<Adult> GetAllAdults()
        {
            IList<Adult> adultsCopy = new List<Adult>(adults);
            return adultsCopy;
        }
        
        public void AddAnAdult(Adult adult)
        {
            int id = adults.Max(adult => adult.Id);
            adult.Id = (++id);
            adults.Add(adult);
            fileContext.SaveChanges();
        }
    }
}