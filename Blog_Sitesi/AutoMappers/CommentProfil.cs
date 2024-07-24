using AutoMapper;
using Blog_Sitesi.Models.Entities;
using Blog_Sitesi.Models.ViewModels;

namespace Blog_Sitesi.AutoMappers
{
    public class CommentProfil:Profile
    {
        public CommentProfil()
        {
            CreateMap<Comment, CommentsOfPostViewModel>();
            CreateMap<CommentsOfPostViewModel, Comment>();
        }
    }
}
