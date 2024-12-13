using _420DA3_Examen_Final.Business.Services;
using _420DA3_Examen_Final.DataAccess;
using _420DA3_Examen_Final.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final
{
    internal class MyApplication
    {
        private MyDbContext context;
        private MainMenu mainMenu;

        public LivreServices LivreServices { get;  private set; }
        public AuteurServices AuteurServices { get; private set; }

        public MyApplication()
        {
            this.context = new MyDbContext();
            this.mainMenu = new MainMenu();
            this.LivreServices = new LivreServices( this.context, this);
            this.AuteurServices = new AuteurServices(this.context, this);
        }
        public void Start()
        {
            Application.Run(this.mainMenu);
        }

    }
}
