using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}", car.Id, car.BrandName, car.ColorName, car.Descriptions, car.DailyPrice);
            //}

            //add and delete functions

            /*carManager.Add(new Car { BrandId=2, ColorId = 3, DailyPrice = 330, ModelYear = 2018 });
            carManager.Add(new Car { BrandId = 2, ColorId = 3, DailyPrice = 0, ModelYear = 2018 });
            brandManager.Add(new Brand { BrandName = "vw" });
            brandManager.Add(new Brand { BrandName = "Hyundai" });*/

        }
    }
}



