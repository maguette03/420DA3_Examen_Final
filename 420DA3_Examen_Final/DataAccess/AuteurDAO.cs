using _420DA3_Examen_Final.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.DataAccess
{
    internal class AuteurDAO
    {
        private MyDbContext context;

        public AuteurDAO(MyDbContext context)
        {
            this.context = context;
        }


        public List<Auteur> GetAll()
        {
            return this.context.Auteurs.ToList();
        }

        //d’obtenir, pour un livre, la liste des auteurs auquel il est associés
        public List<Auteur> GetAuteursAssocies(Livre livre)
        {
            return this.context.Auteurs
                .Include(a => a.Livres)
                .Where(a => a.Livres.Contains(livre))
                .ToList();
        }

        //d’obtenir, pour un livre, la liste des auteurs auquel il n’est PAS associé.

        public List<Auteur> GetAuteursNoAssocies(Livre livre)
        {
            return this.context.Auteurs
                .Include(a => a.Livres)
                .Where(a => !a.Livres.Contains(livre))
                .ToList();
        }
    }
}
