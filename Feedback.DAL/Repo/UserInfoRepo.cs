using Feedback.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.DAL.Repo
{
    public interface IUserInfoRepo
    {
        List<UserInfo> GetUsers();
    }
    public class UserInfoRepo : IUserInfoRepo
    {
        public List<UserInfo> GetUsers()
        {
            using(FeedBackEntities feedBackEntities = new FeedBackEntities())
            {
                return feedBackEntities.UserInfoes.ToList();
            }
        }
    }
}
