using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Descrição não pode ser vazio");
                }
                _descricao = value;
            }
        }
        public decimal Preco { get; set; }
    }
}
