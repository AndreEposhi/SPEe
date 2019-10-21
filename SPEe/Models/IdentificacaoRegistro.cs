using SPEe.Models.Base;
using System;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 0 (zero). Identificação do Arquivo
    /// </summary>
    public class IdentificacaoRegistro : ModelBase
    {
        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 0;

        /// <summary>
        /// Texto “ARQUIVOS DE “ seguido da data e hora de geração do arquivo. A data no formato dd/mm/aaaa e a hora no formato hh:mm:ss.
        /// </summary>
        public string DadoGeracaoArquivo { get; set; }

        /// <summary>
        /// Parâmetro opcional. Valor numérico que identifica a versão do layout do arquivo. Valores válidos: 1 e 2.
        /// </summary>
        public string VersaoLayout { get; set; }

        /// <summary>
        /// Instancia a classe e inicializa as variáveis
        /// </summary>
        public IdentificacaoRegistro()
        {
            DadoGeracaoArquivo = $"ARQUIVOS DE {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
        }

        public static IdentificacaoRegistro Create(IdentificacaoRegistro value)
        {
            return new IdentificacaoRegistro
            {
                VersaoLayout = value.VersaoLayout
            };
        }
    }
}