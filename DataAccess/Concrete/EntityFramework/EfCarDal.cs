using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(CarRentalDBContext context = new CarRentalDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join col in context.Colors
                             on c.ColorId equals col.ColorId
                             select new CarDetailDto { Id = c.Id, BrandName = b.BrandName, ColorName = col.ColorName, DailyPrice = c.DailyPrice, Descriptions = c.Descriptions };
                return result.ToList();
            }
        }
    }
}
