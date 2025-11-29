using Application.Interfaces;

namespace infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync(CancellationToken ct = default)
        {
            return await _context.Usuarios.AsNoTracking().ToListAsync(ct);
        }

        public async Task<IEnumerable<Usuario>> GetByIdAsync(int id, CancellationToken ct = default)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(p => p.Id == id, ct);
        }

        public async Task AddAsync(Usuario usuario, CancellationToken ct = default)
        {
            await _context.Usuarios.AddAsync(usuario, ct);
            await _context.SaveChangesAsync(ct);
        }

        public async Task RemoveAsync(Usuario usuario, CancellationToken ct = default)
        {
            _context.Remove(usuario);
            await _context.SaveChangesAsync(ct);
        }

        public async Task SaveChangesAsync(CancellationToken ct = default)
        {
            await _context.SaveChangesAsync(ct);
        }

        public Task UpdateAsync(Usuario usuario, CancellationToken ct = default)
        {
            _context.Update(usuario);
            return Task.CompletedTask;
        }
    }
}