using System;

namespace SPEe.ValueObjects
{
    /// <summary>
    /// Endereço
    /// </summary>
    public class Endereco
    {
        #region Propriedades

        /// <summary>
        /// Código de Endereçamento Postal do endereço (formato 999999999, só dígitos)
        /// </summary>
        public int CEP { get; set; }

        /// <summary>
        /// Nome do Logradouro
        /// </summary>
        public string Logradouro { get; set; }

        /// <summary>
        /// Número do Logradouro
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Complemento do Logradour
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// Nome do Bairro do Logradouro
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Nome da Cidade
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Sigla da Unidade da Federação
        /// </summary>
        public string UF { get; set; }

        /// <summary>
        /// Código de Endereçamento Postal da Caixa Postal (formato 999999999, só dígitos)
        /// </summary>
        public string CEPCxPostal { get; set; }

        /// <summary>
        /// Número da Caixa Postal
        /// </summary>
        public string CaixaPostal { get; set; }

        /// <summary>
        /// Código do país, conforme tabela fornecida pelos CORREIOS(Ex: Estados Unidos –Sigla – US)
        /// </summary>
        public string Pais { get; set; }

        /// <summary>
        /// Código da Província, conforme tabela fornecida pelos CORREIOS(Ex :Província New Jersey – Sigla NJ)
        /// </summary>
        public string Provincia { get; set; }

        #endregion Propriedades

        /// <summary>
        /// Cria um objeto do endereço
        /// </summary>
        /// <param name="value">Valor do objeto endereço</param>
        /// <returns></returns>
        public static Endereco Create(Endereco value)
        {
            return new Endereco
            {
                CEP = Convert.ToInt32(value.CEP.ToString().Replace(".", "").Replace("-", "")),
                Logradouro = value.Logradouro?.Length > 72 ? value.Logradouro?.Substring(0, 72) : value.Logradouro,
                Numero = value.Numero?.Length > 6 ? value.Numero?.Substring(0, 6) : value.Numero,
                Complemento = value.Complemento?.Length > 30 ? value.Complemento?.Substring(0, 30) : value.Complemento,
                Bairro = value.Bairro?.Length > 72 ? value.Bairro?.Substring(0, 72) : value.Bairro,
                Cidade = value.Cidade?.Length > 72 ? value.Cidade?.Substring(0, 72) : value.Cidade,
                UF = value.UF?.Length > 2 ? value.UF?.Substring(0, 2) : value.UF,
                Pais = value.Pais?.Length > 2 ? value.Pais?.Substring(0, 2) : value.Pais,
                Provincia = value.Provincia?.Length > 2 ? value.Provincia?.Substring(0, 2) : value.Provincia
            };
        }

    }
}