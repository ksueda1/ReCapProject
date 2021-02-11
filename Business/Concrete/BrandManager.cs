using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
using System.Collections.Generic;

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


        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        //public List<Brand> GetCarsByBrandId(int brandId)
        //{
        //    return _brandDal.GetAll(p => p.BrandId == brandId);
        //}



        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Araba sistemden başarıyla silindi.");
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);

        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine("Marka güncellendi");
        }
    }
}
