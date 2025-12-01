using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Key]
    public int Id {get; set;}

    [Required]
    [MaxLength(100)]
    public String Nome {get; set;}

    [Required]
    [MaxLength(500)]
    public String Email {get; set;}

    [Required]
    [MaxLength(30)]
    public String Senha {get; set;}

    [Required]
    public DateTime DataNascimento {get;set;}

    [Required]
    public String Telefone {get; set;}
    public bool Ativo {get; set;}
    public DateTime DataCriacao {get; set;}
    public DateTime? DataAtualizacao {get; set;} 
}