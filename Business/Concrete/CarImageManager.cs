using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _iCarImageDal;

        public CarImageManager(ICarImageDal iCarImageDal)
        {
            _iCarImageDal = iCarImageDal;
        }

        public IResult Add(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_iCarImageDal.GetAll());
        }

        public IResult Update(CarImage carImage)
        {
            throw new NotImplementedException();
        }
    }
}