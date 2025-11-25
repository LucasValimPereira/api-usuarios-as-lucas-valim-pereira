public record UsuarioUpdateDto
(
    string Nome,
    string Email,
    DateTime AnoNascimento,
    string? Telefone,
    bool Ativo
);