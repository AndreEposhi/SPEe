using SPEe.Models.Base;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 7 (sete). Dados do cedente do Bloqueto
    /// </summary>
    public class BloquetoCedente : ModelBase
    {
        #region Propriedades

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 7;

        /// <summary>
        /// Número inteiro, que será usado como chave única para identificação de cada Carta/Telegrama
        /// </summary>
        public int OID { get; set; }

        /// <summary>
        /// Código FEBRABAN do banco
        /// </summary>
        public int CodigoBanco { get; set; }

        /// <summary>
        /// Código da carteira
        /// </summary>
        public int CodigoCarteira { get; set; }

        /// <summary>
        /// Texto para indicação do local de pagamento do bloqueto
        /// </summary>
        public string TextoLocalPagamento { get; set; }

        /// <summary>
        /// Código da agência do cedente
        /// </summary>
        public int CodigoAgenciaCedente { get; set; }

        /// <summary>
        /// Dígito Verificador (DV) do código da agência do cedente
        /// </summary>
        public int CodigoAgenciaCedenteDV { get; set; }

        /// <summary>
        /// Código do cedente
        /// </summary>
        public int CodigoCedente { get; set; }

        /// <summary>
        /// Dígito Verificador (DV) do código do cedente
        /// </summary>
        public int CodigoCedenteDV { get; set; }

        #endregion Propriedades
    }
}