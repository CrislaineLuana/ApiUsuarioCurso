using ApiUsuarioCurso.Dto.Login;
using ApiUsuarioCurso.Dto.Usuario;
using ApiUsuarioCurso.Models;

namespace ApiUsuarioCurso.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDto usuarioCriacaoDto);
        Task<ResponseModel<List<UsuarioModel>>> ListarUsuarios();
        Task<ResponseModel<UsuarioModel>> BuscarUsuarioPorId(int id);
        Task<ResponseModel<UsuarioModel>> EditarUsuario(UsuarioEdicaoDto usuarioEdicaoDto);
        Task<ResponseModel<UsuarioModel>> RemoverUsuario(int id);
        Task<ResponseModel<UsuarioModel>> Login(UsuarioLoginDto usuarioLoginDto);
    }
}
