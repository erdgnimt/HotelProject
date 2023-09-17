using FluentValidation;
using HotelProject.UI.DTO.GuestDTO;

namespace HotelProject.UI.ValidationRules.GuestValidationRules
{
    public class GuestAddValidator:AbstractValidator<GuestAddDTO>
    {
        public GuestAddValidator()
        {
            RuleFor(g=>g.Name).NotEmpty().WithMessage("Müşteri adı girilmeli!");
            RuleFor(g=>g.Surname).NotEmpty().WithMessage("Müşteri soyadı girilmeli!");
            RuleFor(g=>g.City).NotEmpty().WithMessage("Şehir girimeli!");
            RuleFor(g=>g.Name).MinimumLength(2).WithMessage("Ad en az 2 karakterden oluşmalı!");
            RuleFor(g => g.Surname).MinimumLength(2).WithMessage("Soyad en az 2 karakterden oluşmalı!");
            RuleFor(g => g.City).MinimumLength(3).WithMessage("Şehir adı en az 3 karakterden oluşmalı!");
            RuleFor(g => g.Name).MaximumLength(20).WithMessage("Ad en fazla 20 karakterden oluşmalı!");
            RuleFor(g => g.Surname).MaximumLength(30).WithMessage("Soyad en fazla 30 karakterden oluşmalı!");
            RuleFor(g => g.City).MaximumLength(20).WithMessage("Şehir adı en fazla 20 karakterden oluşmalı!");

        }
    }
}
