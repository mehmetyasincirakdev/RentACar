﻿using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class UserManager : IUserService
{
    IUserDal _userdal;

    public UserManager(IUserDal userDal)
    {
        _userdal = userDal;
    }

    public IResult Add(User user)
    {
        _userdal.Add(user);
        return new SuccessResult(Messages.UserAdded);
    }

    public IResult Delete(User user)
    {
        _userdal.Delete(user);
        return new SuccessResult(Messages.UserDeleted);
    }

    public IDataResult<List<User>> GetAll()
    {
        return new SuccessDataResult<List<User>>(_userdal.GetAll());
    }

    public User GetByMail(string email)
    {
        return _userdal.Get(u => u.eMail == email);
    }

    public List<OperationClaim> GetClaims(User user)
    {
        return _userdal.GetClaims(user);
    }

    public IDataResult<User> GetUserById(int id)
    {
        return new SuccessDataResult<User>(_userdal.Get(c => c.Id == id));
    }

    public IResult Update(User user)
    {
        _userdal.Update(user);
        return new SuccessResult(Messages.UserUpdated);
    }
}
