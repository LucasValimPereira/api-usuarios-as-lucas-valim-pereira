using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var app = builder.Build();

//get para Listar todos os usuarios
app.MapGet("/usuarios", async (IUsuarioService service, CancellationToken ct) =>
{
    return Results.Ok(await service.ListarAsync(ct));
});
//get busca usuario por id
app.MapGet("/usuarios/{id}", (int id, IUsuarioService service, CancellationToken ct) =>
{
    var usuario = service.ObterAsync(id, ct);
    return usuario != null ? Results.Ok(usuario) : Results.NotFound();
});
//post criar novo usuario
app.MapPost("/usuarios/{id}", static async (UsuarioCreateDto usuarioDto, IUsuarioService service, CancellationToken ct, IValidator<UsuarioCreateDto> validator) =>
{
    var validationResult = await validator.ValidateAsync(usuarioDto, ct);
    if (!validationResult.IsValid)
    {
        return Results.ValidationProblem(validationResult.ToDictionary());
    }
    var usuario = await service.CriarAsync(usuarioDto.Nome, usuarioDto.Email, usuarioDto.Senha, usuarioDto.DataNascimento, usuarioDto.Telefone);
    return Results.Created($"/usuarios/{usuario.Id}",usuario);
});
//put para atualizar usuario completo
app.MapPut("/usuarios/{id}", async (int id, UsuarioUpdateDto usuario, IUsuarioService service, CancellationToken ct) =>
{
    var atualizarUsuario = await service.AtualizarAsync(id, usuario, ct);
    if (atualizarUsuario == null) return Results.NotFound();
    return Results.Ok(atualizarUsuario);
});
//delete para remover usuario
app.MapDelete("/usuarios/{id}", async (int id, IUsuarioService service) =>
{
    var usuario = await service.ObterAsync(id);
    if (usuario == null) return Results.NotFound();
    await service.RemoveAsync(id);
    return Results.NoContent();
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();