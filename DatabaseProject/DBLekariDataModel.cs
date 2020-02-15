using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DBLekariDataModel : IListSource
    {
        public BindingList<Lekari> Lekari { get; set; } = new BindingList<Lekari>();

        private DBLekariRespository LekariRespository = new DBLekariRespository();

        public bool ContainsListCollection => true;

        public IList GetList()
        {
            return this.Lekari;
        }

        public void Add(Lekari lekar)
        {
            this.Lekari.Add(lekar);
            this.LekariRespository.Insert(lekar);
        }

        public void Update(int index, Lekari lekar)
        {
            this.Lekari[index] = lekar;
            this.LekariRespository.Update(lekar);
        }

        public void Delete(int index)
        {
            Lekari lekar = this.Lekari[index];

            this.Lekari.RemoveAt(index);
            this.LekariRespository.Remove(lekar);
        }
    }
}
