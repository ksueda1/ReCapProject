using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);

                Console.WriteLine("Marka sisteme başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine("Marka isminin uzunluğu en az 2 karakterli olmalıdır. Lütfen tekrar giriniz.");
            }
        }
    }
}
