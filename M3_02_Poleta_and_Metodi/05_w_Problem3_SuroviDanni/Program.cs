using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_w_Problem3_SuroviDanni
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToList();
                Model model = new Model(line[0], int.Parse(line[1]), int.Parse(line[2]));
                Tovar tovar = new Tovar(int.Parse(line[3]), line[4]);
                Tyres[] tyres = new Tyres[4];
                tyres[0] = new Tyres(double.Parse(line[5]), int.Parse(line[6]));
                tyres[1] = new Tyres(double.Parse(line[7]), int.Parse(line[8]));
                tyres[2] = new Tyres(double.Parse(line[9]), int.Parse(line[10]));
                tyres[3] = new Tyres(double.Parse(line[11]), int.Parse(line[12]));

                Car kola = new Car(model, tovar, tyres);
                cars.Add(kola);

                // Кратък запис на горните 2 реда
                //cars.Add(new Car(model, tovar, tyres));
            }

            // print
            var type = Console.ReadLine();
            switch (type)
            {
                // fragile
                case "fragile":
                    var fragile = cars.Where(x => (x.CarTyres[0].Nalqgane < 1) &&
                                                  (x.CarTyres[1].Nalqgane < 1) &&
                                                  (x.CarTyres[2].Nalqgane < 1) &&
                                                  (x.CarTyres[3].Nalqgane < 1))
                                       .Select(y => y.CarModel.CarModel).ToList();
                    Console.WriteLine(string.Join("\n", fragile));
                    break;
                // flamable
                case "flamable":
                    var flamable = cars.Where(x => x.CarModel.Power > 250)
                                       .Select(y => y.CarModel.CarModel).ToList();
                    Console.WriteLine(string.Join("\n", flamable));
                    break;
            }
        }
    }
}
