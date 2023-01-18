using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTesteCodeSpace.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
        public Departamento(){

        }
        public Departamento(int id, string nome){
            Id = id;
            Nome = nome;
        }
    }
}