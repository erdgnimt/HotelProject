using FluentValidation;
using HotelProject.UI.Models.Setting;

namespace HotelProject.UI.ValidationRules.AppUserValidationRules
{
    public class AppUserValidator:AbstractValidator<UserEditViewModel>
    {
        public AppUserValidator()
        {
            RuleFor(p => p.Password).Matches(@"[A-Z]+").WithMessage("Şifreniz en az bir büyük harf içermelidir.");
            RuleFor(p => p.Password).Matches(@"[a-z]+").WithMessage("Şifreniz en az bir küçük harf içermelidir");
            RuleFor(p => p.Password).Matches(@"[0-9]+").WithMessage("Şifreniz en az bir rakam  içermelidir");
            RuleFor(p => p.Password).Matches(@"[\!\?\*\.]*$").WithMessage("Şifreniz en az bir sembol içermelidir");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre boş bırakılamaz!");
            RuleFor(p=>p.ConfirmPassword).NotEmpty().WithMessage("Şifrenizi onaylayın!");
            RuleFor(p => p.Password).MinimumLength(8).WithMessage("Şifre 8 karakterden oluşmalı!");
            RuleFor(p => p.ConfirmPassword).MinimumLength(8).WithMessage("Şifre 8 karakterden oluşmalı!");
            
        }
    }
}
