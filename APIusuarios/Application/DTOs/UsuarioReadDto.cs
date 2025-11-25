public record UsuarioReadDto
(
    int id,
    string Nome,
    string Email,
    DateTime DataNascimento,
    string? Telefone,
    bool Ativo,
    DateTime DataCriacao 
);