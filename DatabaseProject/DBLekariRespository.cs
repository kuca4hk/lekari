using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DBLekariRespository
    {
        private TestContext context = new TestContext();

        public List<Lekari> FindAll()
        {
            return this.context.lekar.ToList();
        }

        public void Insert(Lekari lek)
        {
            //this.context.lekar.Add(lek);
            this.context.SaveChanges();

        }

        public void Update(Lekari lek)
        {
            Lekari db = this.context.lekar.Find(lek.Id);

            db.Jmeno = lek.Jmeno;
            db.Prijmeni = lek.Prijmeni;
            db.DatumNarozeni = lek.DatumNarozeni;
            db.Specializace = lek.Specializace;
            db.DatumUkonceniSkoly = lek.DatumUkonceniSkoly;
            db.Email = lek.Email;
            db.Telefon = lek.Telefon;
            db.Role = lek.Role;
            db.Heslo = lek.Heslo;

            this.context.SaveChanges();
        
        }

        internal void Remove(Lekari lekar)
        {
            throw new NotImplementedException();
            this.context.lekar.Remove(lekar);
            this.context.SaveChanges();
        }

        //public void Remove (Form_Lekar lek)
        //{
        //    this.context.lekar.Remove(lek);
        //    this.context.SaveChanges();
        //}
    }
}
