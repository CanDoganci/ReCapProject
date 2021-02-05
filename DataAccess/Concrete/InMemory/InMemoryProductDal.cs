using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Car> _car;

        public InMemoryProductDal()
        {
            _car = new List<Car>
            {
                new Car{Id=123654, BrandId=25, ColorId=0, ModelYear=2021, DailyPrice=149, Description="Otomatik Sedan"},
                new Car{Id=741258, BrandId=96, ColorId=5, ModelYear=2019, DailyPrice=110, Description="Manuel Sedan"},
                new Car{Id=852741, BrandId=78, ColorId=8, ModelYear=2018, DailyPrice=115, Description="Otomatik SW"},
                new Car{Id=963258, BrandId=85, ColorId=7, ModelYear=2016, DailyPrice=99, Description="Otomatik Hatchback"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);

        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        
    }
}
