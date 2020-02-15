using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WindowsFormsApplication1
{
    public class Lekari
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Jmeno")]
        public string Jmeno { get; set; }

        [DisplayName("Prijmeni")]
        public string Prijmeni { get; set; }

        [DisplayName("DatumNarozeni")]
        public DateTime DatumNarozeni { get; set; } = DateTime.Now;

        [DisplayName("Specializace")]
        public string Specializace { get; set; }

        [DisplayName("DatumUkonceniSkoly")]
        public DateTime DatumUkonceniSkoly { get; set; } = DateTime.Now;

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Telefon")]
        public int Telefon { get; set; }

        [DisplayName("Role")]
        public string Role { get; set; }

        [DisplayName("Heslo")]
        public string Heslo { get; set; }
    }
}
