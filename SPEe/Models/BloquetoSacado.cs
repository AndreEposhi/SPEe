using SPEe.Models.Base;
using System;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 9 (nove). Dados do sacado do Bloqueto
    /// </summary>
    public class BloquetoSacado : ModelBase
    {
        #region Propriedades

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 9;

        /// <summary>
        /// Linha digitável. Incluir apenas os dígitos numéricos.Qualquer outro tipo de caracter gerará erro na importação
        /// </summary>
        public string CodigoLinhaDigitavel { get; set; }

        /// <summary>
        /// Número do documento
        /// </summary>
        public int NumeroDocumento { get; set; }

        /// <summary>
        /// Data do documento. Informar no formato DD/MM/AAAA
        /// </summary>
        public DateTime DataDocumento { get; set; }

        /// <summary>
        /// Valor do documento. Os separadores de milhar serão desprezados(caracter ponto). O caracter decimal deve ser a vírgula
        /// </summary>
        public double ValorDocumento { get; set; }

        /// <summary>
        /// Espécie do documento
        /// </summary>
        public string EspecieDocumento { get; set; }

        /// <summary>
        /// Aceite. Valores válidos: S(Sim), N(Não)
        /// </summary>
        public string Aceite { get; set; }

        /// <summary>
        /// Nosso número
        /// </summary>
        public string NossoNumero { get; set; }

        /// <summary>
        /// Dígito Verificador (DV) do nosso número
        /// </summary>
        public int NossoNumeroDV { get; set; }

        /// <summary>
        /// Data do processamento. Informar no formato DD/MM/AAAA
        /// </summary>
        public DateTime DataProcessamento { get; set; }

        /// <summary>
        /// Data de vencimento. Informar no formato DD/MM/AAAA
        /// </summary>
        public DateTime DataVencimento { get; set; }

        /// <summary>
        /// Uso do banco
        /// </summary>
        public string UsoBanco { get; set; }

        #endregion Propriedades
    }
}