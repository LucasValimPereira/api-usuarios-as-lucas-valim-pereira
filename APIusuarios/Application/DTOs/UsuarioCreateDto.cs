public record usuarioCreateDto
(
    string Nome,
    string Email,
    string Senha,
    DateTime DataNascimento,
    string? Telefone
);