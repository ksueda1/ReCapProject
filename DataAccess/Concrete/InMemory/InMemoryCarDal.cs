﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId=1, ColorId=1, DailyPrice= 150, Description= "Sedan, Manuel vites, Benzin, Klima var", ModelYear= 2010},
                new Car{Id = 2, BrandId=1, ColorId=2, DailyPrice= 190, Description= "Sedan, Otomatik vites, Dizel, Klima var", ModelYear= 2014},
                new Car{Id = 3, BrandId=2, ColorId=3, DailyPrice= 300, Description= "Sedan, Otomatik vites, Dizel, Klima var", ModelYear= 2018},
                new Car{Id = 4, BrandId=2, ColorId=1, DailyPrice= 340, Description= "SUV/Jeep, Otomatik vites, Dizel, Klima var", ModelYear= 2017},
                new Car{Id = 5, BrandId=3, ColorId=2, DailyPrice= 240, Description= "SUV/Jeep, Manuel vites, Benzin, Klima var", ModelYear= 2011},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
