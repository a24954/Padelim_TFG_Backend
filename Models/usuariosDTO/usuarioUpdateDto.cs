namespace TFGBackend.Models.DTOs
{
    public class UsuarioUpdateDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserRole Rol { get; set; }

        public enum UserRole
        {
            Admin,
            StandardUser,
            OwnerUser
        }
    }
}