using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.DAL.Repo
{
    public class Repo : IRepo
    {
        DBContext dB = new DBContext();

        public void EditKupac(Kupac k)
        {
            dB.Entry(k).State = EntityState.Modified;
            dB.SaveChanges();
        }

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

        public Kupac GetKupac(int id)
        {
            return dB.Kupacs.Single(k => k.IDKupac == id);
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

        public void save()
        {
            dB.SaveChanges();
        }
    }
}