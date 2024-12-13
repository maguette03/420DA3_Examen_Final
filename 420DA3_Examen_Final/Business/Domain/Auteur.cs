using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.Business.Domain
{
    internal class Auteur
    {

        public const int MAX_LENGTH_FIRSTNAME = 64;
        public const int MAX_LENGTH_LASTNAME = 64;

        private string firstName;
        private string lastName;
        public int Id { get; set; } 
        public string FirstName {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > MAX_LENGTH_FIRSTNAME)
                {
                    throw new Exception($"La longueur maximal de firstName doit etre {MAX_LENGTH_FIRSTNAME} caractere.");
                }
                else
                {
                    firstName = value;
                }
            }
        }   
        public string LastName {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > MAX_LENGTH_LASTNAME) {
                    throw new Exception($"La longueur maximal de LastName doit etre {MAX_LENGTH_LASTNAME} caractere");
                }
                else
                {
                    lastName = value;
                }
            }
        }
        public byte[] RowVersion { get; set; }


        //propriete de navigation 
        public virtual List<Livre> Livres { get; set; } = new List<Livre>();

        //Constructeur
        public Auteur() { }

        public Auteur(int id, string firstName, string lastName, byte[] rowVersion, List<Livre> livres)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            RowVersion = rowVersion;
            Livres = livres;
        }

        public override string ToString()
        {
            return $"#{this.Id} {this.FirstName} ({this.LastName})";
        }
    }
}
