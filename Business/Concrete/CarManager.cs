using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

      

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba sisteme başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine("Arabanın günlük ücreti 0'dan büyük olmalıdır. Lütfen değeri tekrar giriniz.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba sistemden başarıyla silindi.");
        }

        public Car GetById(int Id)
        {
            return _carDal.Get(c => c.Id == Id);

        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails(); 
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba bilgisi güncellendi.");
        }
    }
}
