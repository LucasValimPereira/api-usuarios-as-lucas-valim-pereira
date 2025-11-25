using FluentValidation;

public class UsuarioUpdateDtoValidator : AbstractValidator<UsuarioUpdateDto>
{
    public UsuarioUpdateDtoValidator()
    {
        RuleFor(u => u.Nome)
            .MaximumLength(100)
            .WithMessage("Não pode mais de 100 letras no nome")
            .MinimumLength(3)
            .WithMessage("O nome deve ter no minimo 3 letras.");
        RuleFor(u => u.Email)
            .NotEmpty()
            .WithMessage("Email não pode ser vazio")
            .MaximumLength(200)
            .WithMessage("Email não pode ter mais de 200 letras");
            //fazer na interface primeiro
        //RuleFor(u => u.DataNascimento)
        //    .MinimumLength(18)
        //    .WithMessage("O minimo para a idade é 18.");
    }
}