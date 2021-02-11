using System;
using System.Collections.Generic;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        Car GetById(int Id);

        List<CarDetailDto> GetCarDetails();

        

    }
}
