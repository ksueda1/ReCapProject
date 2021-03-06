﻿using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate==null)
            {

            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);

        }

        //public IResult Add(Rental rental)
        //{

        //    var result = CheckReturnDate(rental.CarId);
        //    if (!result.Success)
        //    {
        //        return new ErrorResult(result.Message);
        //    }
        //    _rentalDal.Add(rental);
        //    return new SuccessResult(result.Message);

        //}

        //public IResult CheckReturnDate(int carId)
        //{
        //    var result = _rentalDal.GetRentalDetails(x => x.CarId == carId && x.ReturnDate == null);
        //    if (result.Count > 0)
        //    {
        //        return new ErrorResult(Messages.RentalAddedError);
        //    }
        //    return new SuccessResult(Messages.RentalAdded);

        //}

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId), Messages.RentalsListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
