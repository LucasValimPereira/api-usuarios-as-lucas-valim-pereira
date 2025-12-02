
    public static class MappingExtensions
    {
        // converte entidade em DTO de leitura
        public static UsuarioReadDto ToReadDto(this Usuario p)
        {
            return new UsuarioReadDto(
                p.Id,
                p.Nome,
                p.Email,
                p.DataNascimento,
                p.Telefone,
                p.Ativo,
                p.DataCriacao
            );
        }
        public static UsuarioCreateDto ToCreateDto(this Usuario p)
        {
            return new UsuarioCreateDto(
                p.Nome,
                p.Email,
                p.Senha,
                p.DataNascimento,
                p.Telefone
            );
        }

    }