using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.Business.Domain
{
    internal class Livre
    {

        public const int MAX_LENGTH_TITRE = 128;
        public const int MAX_LENGTH_ISBN = 32;

        private string titre;
        private string isbn;


        public int Id { get; set; } 
        public string Titre
        {
            get
            {
                return titre;
            }
            set
            {
                if (value.Length > MAX_LENGTH_TITRE)
                {
                    throw new Exception($"La longueur maximal de titre doit etre de {MAX_LENGTH_TITRE} caractere.");
                }
                else
                {
                    this.titre = value;
                }
            }
        }
        public string Isbn {
            get
            {
                return isbn;
            }
            set
            {
                if (value.Length > MAX_LENGTH_ISBN) 
                {
                    throw new Exception($"La longueur maximal de isbn doit etre {MAX_LENGTH_ISBN} caractere");
                }
                else
                {
                    this.isbn = value;
                }
            }
        }    
        public byte[]  RowVersion { get; set; }

        //proprietes de navigation 
        public virtual List<Auteur> Auteurs { get; set; } = new List<Auteur>();

        //les conctructeurs
        public Livre() { }

        public Livre(string titre, string isbn, int id ,byte[] rowVersion)
        {
            this.Titre = titre;
            this.Isbn = isbn;
            this.Id = id;
            this.RowVersion = rowVersion;
        }

        public override string ToString()
        {
            return $"#{this.Id} {this.Titre} ({this.Isbn})";
        }
    }


}
