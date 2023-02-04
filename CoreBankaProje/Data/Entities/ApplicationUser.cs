using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBankaProje.Data.Entities
{
    public class ApplicationUser//bu tekli ilşki 
    {
        // bir user birden fazla accounts gidebilir o yuzden accountsu list şekilde tanımla 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Account> Accounts { get; set; } // bu çoklu olduğu için list şeklinde burda tanımlayacaksın 
    }
}
