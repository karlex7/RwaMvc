using MVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class KupacViewModel
    {
        public IEnumerable<Grad> GetGrads { get; set; }
        public Kupac Kupac { get; set; }
    }
}