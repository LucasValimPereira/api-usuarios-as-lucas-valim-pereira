
public interface IUsuarioService
{
    Task<IEnumerable<UsuarioReadDto>> ListarAsync(CancellationToken ct);
    Task<UsuarioReadDto?> ObterAsync(int id, CancellationToken ct = default);
    Task<UsuarioReadDto> CriarAsync(UsuarioCreateDto dto, CancellationToken ct);
    Task<UsuarioReadDto> AtualizarAsync(int id, UsuarioUpdateDto dto, CancellationToken ct);
    Task<bool> RemoveAsync(int id, CancellationToken ct = default);
    Task<bool> EmailJaCadastradoAsync(string email, CancellationToken ct);
    Task<object?> CriarAsync(string nome, string email, string senha, DateTime dataNascimento, string telefone);
}