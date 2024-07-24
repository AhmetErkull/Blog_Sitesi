using AutoMapper;
using Blog_Sitesi.Models.Entities;
using Blog_Sitesi.Models.ViewModels;

namespace Blog_Sitesi.AutoMappers
{
    public class UserProfil:Profile
    {
        public UserProfil()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
        }

    }
}
