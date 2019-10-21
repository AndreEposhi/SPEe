using SPEe.Models.Base;
using SPEe.ValueObjects;
using System;
using System.Collections.Generic;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 4 (quatro). Dados da Carta e do Remetente
    /// </summary>
    public class CartaRemetente : ModelBase
    {
        #region Propriedades

        /// <summary>
        /// Tipo de registro
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
        public DateTime? DataEnvio { get; set; }

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

        /// <summary>
        /// Tipo de Registro: 5 (cinco). Texto da Carta
        /// </summary>
        public CartaTexto Texto { get; set; }

        /// <summary>
        /// Coleção de registro do tipo Dados do(s) Destinatário(s) da Carta
        /// </summary>
        public IList<CartaDestinatario> Destinatarios { get; set; }

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        public int NumeralZero => 0;

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        public string LiteralN => "N";

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        public string LiteralBR => "BR";

        #endregion Propriedades

        #region Construtor

        /// <summary>
        /// Instancia a classe e inicializa os objetos
        /// </summary>
        public CartaRemetente()
        {
            OID = new Random().Next(999999999);
            Destinatarios = new List<CartaDestinatario>();
        }

        #endregion Construtor

        /// <summary>
        /// Cria um objeto do tipo Dados do(s) Destinatário(s) da Carta
        /// </summary>
        /// <param name="value">Informações do Dados do(s) Destinatário(s) da Carta</param>
        /// <returns></returns>
        public static CartaRemetente Create(CartaRemetente value)
        {
            var result = new CartaRemetente();
            result.Assunto = value.Assunto.Length > 60 ? value.Assunto?.Substring(0, 60) : value.Assunto;
            result.OIDRemetente = Convert.ToInt32(value.OIDRemetente.ToString().PadLeft(9, '0'));
            result.Nominal = value.Nominal;
            result.Endereco = value.Endereco;
            result.Telefone = value.Telefone;
            result.Email = value.Email?.Length > 50 ? value.Email?.Substring(0, 50) : value.Email;
            result.DataEnvio = value.DataEnvio;
            result.DataCadastro = value.DataCadastro;
            result.IndicadorNomeFonte = value.IndicadorNomeFonte;
            result.IndicadorEntreLinhas = value.IndicadorEntreLinhas;
            result.IndicadorEstiloFonte = value.IndicadorEstiloFonte;
            result.IndicadorTamnhoFonte = value.IndicadorTamnhoFonte;
            result.SVRAR = value.SVRAR?.Length > 1 ? value.SVRAR?.Substring(0, 1) : value.SVRAR;
            result.Usuario = value.Usuario?.Length > 40 ? value.Usuario?.Substring(0, 40) : value.Usuario;
            result.Internacional = value.Internacional;
            result.ImgemCabecalho = value.ImgemCabecalho?.Length > 10 ? value.ImgemCabecalho?.Substring(0, 10) : value.ImgemCabecalho;
            result.ImagemRodape = value.ImagemRodape?.Length > 10 ? value.ImagemRodape?.Substring(0, 10) : value.ImagemRodape;

            result.Texto = value.Texto;

            foreach (var destinatario in result.Destinatarios)
            {
                destinatario.OID = result.OID;
                result.Destinatarios.Add(destinatario);
            }

            return result;
        }
    }
}