using SPEe.Models.Base;
using SPEe.ValueObjects;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 3 (três). Dados do(s) Destinatário(s) do Telegrama
    /// </summary>
    public class TelegramaDestinatario : ModelBase
    {
        #region Campos
        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        private const string LiteralT = "T";

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        private const string LiteralD = "D";

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        private const string LiteralN = "N";

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        private const int LiteralUm = 1; 
        #endregion

        #region Propriedades

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 3;

        /// <summary>
        /// Número inteiro, que será usado como chave única para identificação de cada Telegrama
        /// </summary>
        public int OID { get; set; }

        /// <summary>
        /// Número inteiro usado como chave única para identificação de cada Destinatário
        /// </summary>
        public int? OIDContato { get; set; }

        /// <summary>
        /// Dados como nome, título e apelido
        /// </summary>
        public Nominal Nominal { get; set; }

        /// <summary>
        /// Endereco
        /// </summary>
        public Endereco Endereco { get; set; }

        /// <summary>
        /// Código do Endereçamento Eletrônico do Destinatário
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Dados do telefone
        /// </summary>
        public Telefone Telefone { get; set; }

        /// <summary>
        /// Informar 0 (zero) se foi solicitada entrega do telegrama no Endereço do Destinatário. Informar 1 (um) se foi solicitada entrega do telegrama na Caixa
        /// Postal do Destinatário
        /// </summary>
        public int TipoDestino { get; set; }

        #endregion Propriedade
    }
}