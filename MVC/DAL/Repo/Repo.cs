using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.DAL.Repo
{
    public class Repo : IRepo
    {
        DBContext dB = new DBContext();
        public IEnumerable<Drzava> GetDrzavas()
        {
            return dB.Drzavas.ToList();
        }

        public IEnumerable<Grad> GetGrads()
        {
            return dB.Grads.ToList();
        }

        public IEnumerable<Komercijalist> GetKomercijalists()
        {
            return dB.Komercijalists.ToList();
        }

        public IEnumerable<KreditnaKartica> GetKreditnaKarticas()
        {
            return dB.KreditnaKarticas.ToList();
        }

        public IEnumerable<Kupac> GetKupacs()
        {
            return dB.Kupacs.ToList();
        }

        public IEnumerable<Racun> GetRacuns()
        {
            return dB.Racuns.ToList();
        }

        public IEnumerable<Stavka> GetStavkas()
        {
            return dB.Stavkas.ToList();
        }

        public void InsertDrzava(Drzava drzava)
        {
            dB.Drzavas.Add(drzava);
            dB.SaveChanges();
        }
    }
}