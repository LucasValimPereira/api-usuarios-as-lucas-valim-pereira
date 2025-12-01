using Application.Interfaces;

namespace Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repo;

        public UsuarioService(IUsuarioRepository repo)
        {
            _repo = repo;
        }

        // public async Task<IEnumerable<Usuario>> ListarAsync(CancellationToken ct =default)
        // {
        //     return await _repo.GetAllAsync(ct);
        // }

        // public async Task<Usuario?> ObterAsync(int id, CancellationToken ct = default)
        // {
        //     if (id <= 0)
        //         throw new ArgumentException("ID inválido");

        //     return await _repo.GetByIdAsync(id, ct);
        // }

        // public async Task<UsuarioReadDto> CriarAsync(int Id, String Nome,String Email, String Senha, DateTime DataNascimento, String Telefone, bool Ativo , DateTime DataCriacao DateTime? DataAtualizacao )
        // {
        //     if(string.IsNullOrWhiteSpace(Nome))
        //         throw new ArgumentException("Nome é obrigatório");
            


        //     await _repo.AddAsync(usuario, ct);
        //     return MappingExtensions.ToReadDto(usuario);
        // }

    //     public async Task<Usuario> AtualizarAsync(int id, UsuarioCreateDto usuario, CancellationToken ct = default)
    // {
    //     var usuarioEncontrado = await _repo.GetByIdAsync(id, ct);
    //     if (usuarioEncontrado == null) return null;
    //     usuarioEncontrado.Nome = usuario.Nome;
    //     usuarioEncontrado.Email = usuario.Email;
    //     usuarioEncontrado.Senha = usuario.Senha;
    //     usuarioEncontrado.DataNascimento = usuario.DataNascimento;
    //     usuarioEncontrado.Telefone = usuario.Telefone;
        
    //     await _repo.UpdateAsync(usuarioEncontrado, ct);
    //     await _repo.SaveChangesAsync(ct);
    //     return usuarioEncontrado;
    
    // }

    // public async Task<UsuarioCreateDto?> AtualizarParcialAsync(int id, Usuario usuario, CancellationToken ct = default)
    // {
    //     var usuarioAtualizado = await _repo.GetByIdAsync(id, ct);
    //     if (usuarioAtualizado == null) return null;
    //     if (!String.IsNullOrWhiteSpace(usuario.Nome))
    //     {
    //         usuarioAtualizado.Nome = usuario.Nome;
    //     }
    //     if (!String.IsNullOrWhiteSpace(usuario.Nome))
    //     {
    //         usuarioAtualizado.Email = usuario.Email;
    //     }
    

    //     await _repo.UpdateAsync(usuarioAtualizado, ct);
    //     await _repo.SaveChangesAsync(ct);
    //     return MappingExtensions.ToCreateDto(usuarioAtualizado);
    // }

        public Task<IEnumerable<UsuarioReadDto>> ListarAsync(CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioReadDto?> ObterAsync(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioReadDto> CriarAsync(UsuarioCreateDto dto, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioReadDto> AtualizarAsync(int id, UsuarioUpdateDto dto, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EmailJaCadastradoAsync(string email, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<object?> CriarAsync(string nome, string email, string senha, DateTime dataNascimento, string telefone)
        {
            throw new NotImplementedException();
        }
    }
}