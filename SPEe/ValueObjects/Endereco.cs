namespace SPEe.ValueObjects
{
    /// <summary>
    /// Endereço
    /// </summary>
    public class Endereco
    {
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
    }
}