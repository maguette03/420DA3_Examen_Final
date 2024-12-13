using _420DA3_Examen_Final.Business.Domain;
using _420DA3_Examen_Final.DataAccess;
using _420DA3_Examen_Final.Presentation;
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
        private LivreView view;
        public LivreServices(MyDbContext context, MyApplication parentApp)
        {
            this.dao = new LivreDAO(context);
             this.view = new LivreView(parentApp);

        }

        public Livre? OpenViewForCreation()
        {
            Livre nowLivre = new Livre();
            DialogResult result = this.view.OpenForCreation(nowLivre);
            if (result == DialogResult.OK)
            {
                return nowLivre;
            }
            else
            {
                return null;
            }

        }


        public Livre OpenViewForView(Livre livre)
        {
            this.view.OpenForView(livre);
            return livre;
        }

        public Livre? OpenViewForModification(Livre livre)
        {
            DialogResult result = this.view.OpenForModification(livre);
            if (result == DialogResult.OK)
            {
                return livre;
            }
            else
            {
                return null;
            }
        }


        public Livre? OpenViewForDeletion(Livre livre)
        {
            DialogResult result = this.view.OpenForDeletion(livre);
            if (result == DialogResult.OK)
            {
                return livre;
            }
            else
            {
                return null;
            }
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
