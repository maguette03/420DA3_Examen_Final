using _420DA3_Examen_Final.Business.Domain;
using _420DA3_Examen_Final.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.Business.Services
{
    internal class LivreServices
    {
        private LivreDAO dao;
        public LivreServices(MyDbContext context)
        {
            this.dao = new LivreDAO(context);
            //  this.view = new LivreView(parentApp);

        }

        public Livre? OpenViewForCreation()
        {
            Livre nowLivre = new Livre();
           
        }


        public List<Livre> SearchLivre(string criterion)
        {
            return dao.Search(criterion);
        }

        public Livre InsertLivre(Livre livre) {
            return this.dao.Insert(livre);
        }

        public Livre UpdateLivre(Livre livre)
        {
            return this.dao.Update(livre);
        }
        public Livre DeleteLivre(Livre livre)
        {
            return this.dao.Delete(livre);
        }
    }
}
