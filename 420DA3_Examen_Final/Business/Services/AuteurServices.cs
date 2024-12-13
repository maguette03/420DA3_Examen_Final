using _420DA3_Examen_Final.Business.Domain;
using _420DA3_Examen_Final.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.Business.Services
{
    
    internal class AuteurServices
    {
        private AuteurDAO dao;
        
        
        public AuteurServices(MyDbContext context ,MyApplication parentApp)
        {
            this.dao = new AuteurDAO(context);
        }


        public List<Auteur> GetAll()
        {
            return dao.GetAll();    
        }
         public  List<Auteur> GetAuteursAssocies(Livre livre)
         {
            return dao.GetAuteursAssocies(livre);
         }

        public List<Auteur> GetAuteursNoAssocies(Livre livre)
        {
            return dao.GetAuteursNoAssocies(livre);
        }
    }
}
