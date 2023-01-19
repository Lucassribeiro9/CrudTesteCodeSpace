using System;
using System.Collections.Generic;


namespace CrudTesteCodeSpace.Models.ViewModels
{
    public class FuncFormViewModel
    {
        public Funcionario Funcionario { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}