﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userManager;

        public UserManager(IUserDal userManager)
        {
            _userManager = userManager;
        }

        public void TAdd(User t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(User t)
        {
            throw new NotImplementedException();
        }

        public User TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> TGetList()
        {
            return _userManager.GetList();
        }

        public void TUpdate(User t)
        {
            throw new NotImplementedException();
        }
    }
}
