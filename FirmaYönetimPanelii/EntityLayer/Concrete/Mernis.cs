using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Mernis
    {
        [Key]
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string TcKimlikNo { get; set; }

        public DateTime DogumTarihi { get; set; }
    }
}
