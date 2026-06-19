using System.Collections.Generic;

namespace ProjetoAPI01.Classes.DTO
{
    public class AdminResponseDTO
    {
        public List<UsuarioDTO> Usuarios { get; set; } = new List<UsuarioDTO>();
    }
}

