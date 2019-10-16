using SPEe.Models.Base;
using SPEe.ValueObjects;
using System;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 4 (quatro). Dados da Carta e do Remetente
    /// </summary>
    public class CartaRemetente : ModelBase
    {
        /// <summary>
        /// Numeral
        /// </summary>
        public override int Tipo => 4;

        /// <summary>
        /// Número inteiro, que será usado como chave única para identificação de cada Carta
        /// </summary>
        public int OID { get; set; }

        /// <summary>
        /// Sinopse do texto da Carta
        /// </summary>
        public string Assunto { get; set; }

        /// <summary>
        /// Número inteiro, usado como chave única para identificação de cada Remetente
        /// </summary>
        public int? OIDRemetente { get; set; }

        /// <summary>
        /// Dados como título, nome e apelido
        /// </summary>
        public Nominal Nominal { get; set; }

        /// <summary>
        /// Dados do endereço
        /// </summary>
        public Endereco Endereco { get; set; }

        /// <summary>
        /// Dados do telefone
        /// </summary>
        public Telefone Telefone { get; set; }

        /// <summary>
        /// Código do Endereçamento Eletrônico do Remetente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Data em que o Telegrama foi disponibilizado para envio (dd/mm/aaaa)
        /// </summary>
        public DateTime DataEnvio { get; set; }

        /// <summary>
        /// Data em que o Telegrama foi criado(dd/mm/aaaa)
        /// </summary>
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// Informar o número 16602 se deseja a Fonte Arial.Informar o número 4099 se deseja a fonte Currier. Informar o número 16901 se deseja a Fonte Times New Roman
        /// </summary>
        public int IndicadorNomeFonte { get; set; }

        /// <summary>
        /// Se desejar o distanciamento de 1.0 entre as linhas do texto informe o número 6. Para o distanciamento 1.5, informe o número 4. Para o distanciamento 2.0,
        /// informe o número 3
        /// </summary>
        public int IndicadorEntreLinhas { get; set; }

        /// <summary>
        /// Informe o número 0 (zero) se deseja o estilo Normal.Informe o número um para estilo Itálico.Informe dois para o estilo Negrito.Informe três
        /// para o estilo Negrito e Itálico
        /// </summary>
        public int IndicadorEstiloFonte { get; set; }

        /// <summary>
        /// Informe o tamanho da fonte
        /// </summary>
        public int IndicadorTamnhoFonte { get; set; }

        /// <summary>
        /// Informe a Letra S de deseja o serviço de aviso de recebimento
        /// </summary>
        public string SVRAR { get; set; }

        /// <summary>
        /// Identificação do operador que confeccionou a Carta
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Informar caractere 1 no caso de destinatário internacional e 0 no caso de destinatário nacional
        /// </summary>
        public bool Internacional { get; set; }

        /// <summary>
        /// Código da imagem que será impressa no cabeçalho do Carta
        /// </summary>
        public string ImgemCabecalho { get; set; }

        /// <summary>
        /// Código da imagem que será impressa no rodapé do Carta
        /// </summary>
        public string ImagemRodape { get; set; }
    }
}