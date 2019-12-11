using FluentValidation;


namespace BlazorOverviewShared.Pages.User
{
    public class UserModelValidation : AbstractValidator<UserModel>
    {
        public UserModelValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ime ne smije biti prazno");
            RuleFor(x => x.LastName).MinimumLength(5).WithMessage("Prezime mora sadržavati barem 5 znakova");
            RuleFor(x => x.Level).InclusiveBetween(0, 9).WithMessage("Level mora biti između 0 i 9");
        }
    }
}
