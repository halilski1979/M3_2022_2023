using System;
using System.Collections.Generic;
using System.Text;

namespace _05_w_Problem3_SuroviDanni
{
    public class Model
    {
        private string modelCar;
        private int engineSpeed;
        private int power;

        public Model(string modelCar, int engineSpeed, int power)
        {
            this.ModelCar = modelCar;
            this.EngineSpeed = engineSpeed;
            this.Power = power;
        }

        public string ModelCar
        {
            get { return modelCar; }
            set { modelCar = value; }
        }       

        public int EngineSpeed
        {
            get { return engineSpeed; }
            set { engineSpeed = value; }
        }       

        public int Power
        {
            get { return power; }
            set { power = value; }
        }


    }
}
