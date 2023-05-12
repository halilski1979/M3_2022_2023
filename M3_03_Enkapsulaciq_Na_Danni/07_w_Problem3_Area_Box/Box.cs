using System;
using System.Collections.Generic;
using System.Text;

namespace _02_w_Problem3_Area_Box
{
   public  class Box
    {
        //Дайте на външния свят само методите за лице на повърхнина, околна повърхнина и обем 
        //Правим само private-полета, СТОЙНОСТИТЕ СЕ ПОДАВАТ САМО ПРЕЗ КОНСТРУКТОРА
        private float lenght;
        private float width;
        private float height;

        // конструктор
        public Box(float lenght, float width, float height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
        }

        // лице на повърхнина
        public float SurfaceArea()
        {
            return 2 * this.lenght * this.width +
                   2 * this.lenght * this.height +
                   2 * this.width * this.height;
        }

        // околна повърхнина 
        public float LateralSurfaceArea()
        {
            return 2 * this.lenght * this.height +
                   2 * this.width * this.height;
        }

        // обем
        public float Volume()
        {
            return this.lenght * this.width * this.height;
        }
    }
}
