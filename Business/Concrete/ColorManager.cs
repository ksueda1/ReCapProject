using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(col => col.ColorId == colorId);
        }

        //public List<Color> GetCarsByColorId(int colorId)
        //{
        //    return _colorDal.GetAll(p => p.ColorId == colorId);

        //}

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Renk sisteme eklendi.");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk sistemden silindi.");
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Renk güncellendi.");
        }


       
    }
}
