using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Apresentacao
{
    public class Cliente
    {
        public string Documento { get; private set; }
        public string Nome { get; private set; }

        public Cliente(string documento, string nome)
        {
            Documento = documento;
            Nome = nome;

            ValidarDocumento();
            ValidarNome();
        }

        private void ValidarNome()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new ArgumentOutOfRangeException(nameof(Nome));
        }

        private void ValidarDocumento()
        {
            if (string.IsNullOrEmpty(Documento) || (Documento.Length != 11 && Documento.Length != 14))
                throw new ArgumentOutOfRangeException(nameof(Documento));
        }

        public override string ToString()
        {
            return $"{Documento} - {Nome}";
        }
    }
}