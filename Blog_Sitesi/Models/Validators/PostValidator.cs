using Blog_Sitesi.Models.Entities;
using FluentValidation;

namespace Blog_Sitesi.Models.Validators
{
    public class PostValidator:AbstractValidator<Post>
    {
        public PostValidator() { 
        RuleFor(x=>x.Title).MaximumLength(100);
        }

    }
}
