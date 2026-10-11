using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models;


[Table("Usuarios")]
public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome de usuário é obrigatório!")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A senha é obrigatória!")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    public Perfil Perfil { get; set; }
}

public enum Perfil
{
    Admin,
    User
}