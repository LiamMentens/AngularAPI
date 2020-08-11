using AngularAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.ViewModels
{
    public class DashboardViewModel
    {
        public ICollection<Lijst> BeheerderLijsten { get; set; }
        public ICollection<Stem> UitStemmen { get; set; }
    }
}
