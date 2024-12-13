using _420DA3_Examen_Final.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.DataAccess
{
    internal class LivreDAO
    {
        private MyDbContext context;
        public LivreDAO(MyDbContext context)
        {
            this.context = context;
        }

        public List<Livre> Search(string criterion)
        {
            return this.context.livres
                .Where(l => l.Titre.Contains(criterion) || l.Isbn.Contains(criterion))
                .Include(l => l.Auteurs)
                .ToList();
        }

        public Livre Insert(Livre livre)
        {
            _ = this.context.livres.Add(livre);
            _ = this.context.SaveChanges();
            return livre;
        }

        public Livre Update(Livre livre) { 
            _= this.context.livres.Update(livre);
            _ = this.context.SaveChanges();
            return livre;
        }

        public Livre Delete(Livre livre) {
            _ = this.context.livres.Remove(livre);
            _ = this.context.SaveChanges();
            return livre;
        }
    }
}
