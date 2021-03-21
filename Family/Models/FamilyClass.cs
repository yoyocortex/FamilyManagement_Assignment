using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Family.Models;

namespace Models {
public class FamilyClass {
    
    //public int Id { get; set; }
    public string StreetName { get; set; }
    public int HouseNumber{ get; set; }
    public List<Adult> Adults { get; set; }
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public FamilyClass() {
        Adults = new List<Adult>();     
    }
}
}