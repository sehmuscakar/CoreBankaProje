using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBankaProje.Data.Entities
{
    public class Account//bu caklu ilşki
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }
        public int ApplicationUserId { get; set; }// bu aklında kalsın başka bi tablodan id tanımlıyorsan tanımladığın tablo coklu ilişki oluyor 

        public ApplicationUser ApplicationUser { get; set; }
    }
}

