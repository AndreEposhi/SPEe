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
        public int? NumeroDocumento { get; set; }

        /// <summary>
        /// Data do documento. Informar no formato DD/MM/AAAA
        /// </summary>
        public DateTime? DataDocumento { get; set; }

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

        #region Métodos

        /// <summary>
        /// Cria um registro do tipo dados do sacado do bloqueto
        /// </summary>
        /// <param name="value">Informações do sacado do bloqueto</param>
        /// <returns></returns>
        public static BloquetoSacado Create(BloquetoSacado value)
        {
            return new BloquetoSacado
            {
                CodigoLinhaDigitavel = value.CodigoLinhaDigitavel?.Length > 47 ? value.CodigoLinhaDigitavel?.Substring(0, 47) : value.CodigoLinhaDigitavel,
                NumeroDocumento = Convert.ToInt32(value.NumeroDocumento?.ToString().Substring(0, 17)),
                DataDocumento = value.DataDocumento,
                ValorDocumento = value.ValorDocumento,
                EspecieDocumento = value.EspecieDocumento?.Length > 10 ? value.EspecieDocumento?.Substring(0, 10) : value.EspecieDocumento,
                Aceite = value.Aceite?.Length > 1 ? value.Aceite?.Substring(0, 1) : value.Aceite,
                NossoNumero = value.NossoNumero?.Length > 18 ? value.NossoNumero?.Substring(0, 18) : value.NossoNumero,
                NossoNumeroDV = Convert.ToInt32(value.NossoNumeroDV.ToString().Substring(0, 1)),
                DataProcessamento = value.DataProcessamento,
                DataVencimento = value.DataVencimento,
                UsoBanco = value.UsoBanco?.Length > 17 ? value.UsoBanco?.Substring(0,17) : value.UsoBanco
            };
        }

        #endregion Métodos
    }
}