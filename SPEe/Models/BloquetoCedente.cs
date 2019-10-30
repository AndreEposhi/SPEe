using SPEe.Models.Base;
using System;

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

        #region Métodos
        /// <summary>
        /// Cria um registro do tipo dados do cedente do bloqueto
        /// </summary>
        /// <param name="value">Informações do cedente do bloqueto</param>
        /// <returns></returns>
        public static BloquetoCedente Create(BloquetoCedente value)
        {
            return new BloquetoCedente
            {
                CodigoBanco = Convert.ToInt32(value.CodigoBanco.ToString().Substring(0, 3)),
                CodigoCarteira = Convert.ToInt32(value.CodigoCarteira.ToString().Substring(0, 6)),
                TextoLocalPagamento = value.TextoLocalPagamento?.Length > 76 ? value.TextoLocalPagamento?.Substring(0, 76) : value.TextoLocalPagamento,
                CodigoAgenciaCedente = Convert.ToInt32(value.CodigoAgenciaCedente.ToString().Substring(0, 6)),
                CodigoAgenciaCedenteDV = Convert.ToInt32(value.CodigoAgenciaCedenteDV.ToString().Substring(0, 1)),
                CodigoCedente = Convert.ToInt32(value.CodigoCedente.ToString().Substring(0, 9)),
                CodigoCedenteDV = Convert.ToInt32(value.CodigoCedenteDV.ToString().Substring(0, 1))
            };
        } 
        #endregion
    }
}