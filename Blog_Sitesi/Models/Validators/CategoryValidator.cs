using Blog_Sitesi.Models.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Blog_Sitesi.Models.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).MaximumLength(25).WithMessage("Kategori ismi 25 karakterden uzun olamaz.");
            RuleFor(x => x.Description).MaximumLength(150).WithMessage("Kategori açıklaması 150 karakterden uzun olamaz."); 
        }
    }
}
