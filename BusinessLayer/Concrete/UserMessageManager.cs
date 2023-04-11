using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _messageDal;

        public UserMessageManager(IUserMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<UserMessage> GetMessagesWithUsers()
        {
            return _messageDal.GetMessagesWithUsers();
        }

        public void TAdd(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList()
        {
            return _messageDal.GetList();
        }

        public void TUpdate(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
