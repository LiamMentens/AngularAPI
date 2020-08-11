using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models
{
    public class Gebruiker
    {
        public long GebruikerID { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Gebruikersnaam { get; set; }
        [NotMapped]
        public string Token { get; set; }

        public ICollection<Stem> Stemmen { get; set; }
        //public ICollection<Lijst> Lijsten {get;set;}


        //public ICollection<Lijst> Lijsten { get; set; }
        //public Lijst Lijst { get; set; }
    }
}
