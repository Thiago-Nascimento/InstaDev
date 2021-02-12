using System.IO;
using InstaDev.Interfaces;

namespace InstaDev.Models
{
    public class Usuario : InstadevBase , IUsuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }        
        public string Foto { get; set; }
        public string DataDeNascimento { get; set; }        
        public string Email { get; set; }        
        public string Username { get; set; }
        public string Senha { get; set; }

        public const string PATH = "Database/Usuario.csv";

        public string PrepararLinha(Usuario u)
        {
            return $"{u.IdUsuario};{u.Nome};{u.Foto};{u.DataDeNascimento};{u.Email};{u.Username};{u.Senha}";
        }
        
        public void Cadastrar(Usuario user)
        {
            string[] linha = { PrepararLinha(user) };
            File.AppendAllLines(PATH, linha);
        }
    }
}