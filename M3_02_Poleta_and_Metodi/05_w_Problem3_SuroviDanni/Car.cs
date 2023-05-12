using System;
using System.Collections.Generic;
using System.Text;

namespace _05_w_Problem3_SuroviDanni
{
   public  class Car
    {
        private Model carModel;
        private Tovar tovar;
        private Tyres [] carTyres=new Tyres[4];
        
        public Car(Model carModel,Tovar tovar, Tyres [] carTyres)
        {
            this.CarModel = carModel;
            this.Tovar = tovar;
            this.carTyres = carTyres;
        }
        public Tyres [] CarTyres
        {
            get { return carTyres; }
            set { carTyres=value; }
        }

        public Model CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }

       

        public Tovar Tovar
        {
            get { return tovar; }
            set { tovar = value; }
        }




    }
}
