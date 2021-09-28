using System;

namespace API.Models
{
    public class Livro
    {
        // Construtor
        public Livro() 
        {
            CriadoEm = DateTime.Now;
        }
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int Anopublicacao { get; set; }
        public int Edicao { get; set; }
        public int Pagina { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Marca: {Titulo} | Modelo: {Editora} | Cor: { Edicao } | Criado Em: {CriadoEm}";
    }
}