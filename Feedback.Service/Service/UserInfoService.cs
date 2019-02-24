using Feedback.DAL.Model;
using Feedback.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Service.Service
{
    public interface IUserInfoService
    {
        List<UserInfo> GetUsers();
    }
    public class UserInfoService : IUserInfoService
    {
        private IUserInfoRepo _userInfoRepo;
        public UserInfoService(IUserInfoRepo userInfoRepo)
        {
            _userInfoRepo = userInfoRepo;
        }
        public List<UserInfo> GetUsers()
        {
            return _userInfoRepo.GetUsers();
        }
    }
}
