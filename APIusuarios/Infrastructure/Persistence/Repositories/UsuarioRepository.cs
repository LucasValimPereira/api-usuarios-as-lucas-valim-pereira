using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SQLitePCL;
using infrastructure.Persistence;
namespace Infrastructure.Repositories;


public class UsuarioRepository : IUsuarioRepository
{

    private readonly AppDbContext _context;

    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Usuario>> GetAllAsync(CancellationToken ct = default)
    {
        // Permite consultar as entidades do banco de dados sem rastrear as suas entidades através do AsNoTracking, tendo mais desempenho quando precisa fazer leituras.
        return await _context.Usuarios.AsNoTracking().ToListAsync(ct);
    }

    public async Task<Usuario?> GetByIdAsync(int id, CancellationToken ct = default)
    {
        // Busca uma entidade específica no banco de dados através do seu id usando FindAsync.
        return await _context.Usuarios.FirstOrDefaultAsync(p => p.Id == id, ct);
    }

    public async Task<Usuario?> GetByEmailAsync(String email, CancellationToken ct = default)
    {
        // Busca uma entidade específica no banco de dados através do seu id usando FindAsync.
        return await _context.Usuarios.FirstOrDefaultAsync(p => p.Email == email, ct);
    }

    public async Task<bool> EmailExistsAsync(string email, CancellationToken ct)
    {
        // Busca uma entidade específica no banco de dados através do seu id usando FindAsync.
        var existeEmail = await _context.Usuarios.FirstOrDefaultAsync(p => p.Email == email, ct);
        if(existeEmail != null)
        {
            return true;
        }
        return false;
    }

    public async Task AddAsync(Usuario usuario, CancellationToken ct = default)
    {
        // adiciona uma nova entidade ao banco de dados usando AddAsync.
        // salva as alterações que foram feitas ao banco de dados com SaveChangesAsync.
        await _context.Usuarios.AddAsync(usuario, ct);
        await _context.SaveChangesAsync(ct);
    }

    public async Task RemoveAsync(Usuario usuario, CancellationToken ct = default)
    {
        // marca um produto como deleted através do Remove, mas ele é apagado do banco de dados apenas quando a alteração for salva com SaveChangesAsync.
        _context.Remove(usuario);
        await _context.SaveChangesAsync(ct);
    }

    public async Task<int> SaveChancesAsync(CancellationToken ct)
    {
       return await _context.SaveChangesAsync(ct);
    }

    public Task UpdateAsync(Usuario usuario, CancellationToken ct = default)
    {
        _context.Update(usuario);
        return Task.CompletedTask;
    }
}