using SPEe.Models.Base;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 6 (seis). Dados do(s) Destinatário(s) da Carta
    /// </summary>
    public class CartaDestinatario : ModelBase
    {
        #region Campos

        /// <summary>
        /// Usado para compor o registro
        /// </summary>
        private const string LiteralC = "C";

        /// <summary>
        /// Usado para compor o registro
        /// </summary>
        private const string LiteralD = "D";

        /// <summary>
        /// Usado para compor o registro
        /// </summary>
        private const string LiteralN = "N";

        /// <summary>
        /// Usado para compor o registro
        /// </summary>
        private const int NumeralUm = 1;

        #endregion Campos

        #region Propriedades

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 6;

        /// <summary>
        /// Número inteiro, que será usado como chave única para identificação de cada Carta
        /// </summary>
        public int OID { get; set; }

        /// <summary>
        /// Número inteiro usado como chave única para identificação de cada Destinatário
        /// </summary>
        public int OIDContato { get; set; }

        #endregion Propriedades
    }
}