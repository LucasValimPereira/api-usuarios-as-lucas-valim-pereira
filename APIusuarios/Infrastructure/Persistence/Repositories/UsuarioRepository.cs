using Application.Interfaces;

public interface IProdutoRepository
{
    Task<Usuario> GetByIdAsync(int id);
    Task<IEnumerable<Usuario>> GetAllAsync();
    Task AddAsync(Usuario usuario);
    Task UpdateAsync(Usuario usuario);
    Task DeleteAsync(int id);
} 