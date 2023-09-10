using FluentValidation;
using PersonalPortfolio.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Validation
{
    public class ExperienceAddDtoValidator : AbstractValidator<ExperienceAddDto>
    {
        public ExperienceAddDtoValidator()
        {
            RuleFor(x => x.Title)
                   .NotEmpty().WithMessage("Title is required.")
                   .MinimumLength(4).WithMessage("Title must be at least 4 characters.")
                   .MaximumLength(100).WithMessage("Title cannot exceed 100 characters.");

            RuleFor(x => x.Description)
                   .NotEmpty().WithMessage("Desription is required.")
                   .MinimumLength(4).WithMessage("Desription must be at least 4 characters.")
                   .MaximumLength(100).WithMessage("Desription cannot exceed 500 characters.");

            RuleFor(x => x.StartDate)
                   .NotEmpty().WithMessage("Desription is required.");

            RuleFor(x => x.Description)
                   .NotEmpty().WithMessage("Desription is required.");
        }
    }
}
