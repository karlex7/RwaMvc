using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.Repo
{
    interface IRepo
    {
        IEnumerable<Drzava> GetDrzavas();
        IEnumerable<Grad> GetGrads();
        IEnumerable<Kupac> GetKupacs();
        IEnumerable<Racun> GetRacuns();
        IEnumerable<Komercijalist> GetKomercijalists();
        IEnumerable<KreditnaKartica> GetKreditnaKarticas();
        IEnumerable<Stavka> GetStavkas();
        void InsertDrzava(Drzava drzava);
    }
}
