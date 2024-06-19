using ApiUsuarioCurso.Dto.Usuario;
using ApiUsuarioCurso.Models;

namespace ApiUsuarioCurso.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDto usuarioCriacaoDto);
    }
}
