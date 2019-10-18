using SPEe.Models.Base;
using SPEe.ValueObjects;
using System;
using System.Collections.Generic;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 1 (um). Dados do Telegrama e do Remetente
    /// </summary>
    public class TelegramaRemetente : ModelBase
    {
        #region Campos

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        private const int NumeralZero = 0;

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        private const int NumeralUm = 1;

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        private const string LiteralN = "N";

        #endregion Campos

        #region Propriedades

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 1;

        /// <summary>
        /// Número inteiro, que será usado como chave única para identificação de cada Telegrama
        /// </summary>
        public int OID { get; set; }

        /// <summary>
        /// Sinopse do texto do Telegrama
        /// </summary>
        public string Assunto { get; set; }

        /// <summary>
        /// Número inteiro, usado como chave única para identificação de cada Remetente
        /// </summary>
        public int? OIDRemetente { get; set; }

        public Nominal Nominal { get; set; }

        /// <summary>
        /// Endereço do Remetente
        /// </summary>
        public Endereco Endereco { get; set; }

        /// <summary>
        /// Código do Endereçamento Eletrônico do Remetente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Informações do telefone
        /// </summary>
        public Telefone Telefone { get; set; }

        /// <summary>
        /// Data em que o Telegrama foi disponibilizado para envio (dd/mm/aaaa)
        /// </summary>
        public DateTime DataEnvio { get; set; }

        /// <summary>
        /// Data em que o Telegrama foi criado(dd/mm/aaaa)
        /// </summary>
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// Informar o caractere S se foi solicitado o serviço de cópia do Telegrama
        /// </summary>
        public string SRVCC { get; set; }

        /// <summary>
        /// Informar o caractere S se foi solicitado o serviço de Pedido de Confirmação para entrega do Telegrama
        /// </summary>
        public string SRVPC { get; set; }

        /// <summary>
        /// Informar o caractere S se foi solicitado o serviço de Telegrama Pré-Datado
        /// </summary>
        public string SRVPD { get; set; }

        /// <summary>
        /// Informar o caractere S se foi solicitado o serviço de Telegrama Pré-Horado
        /// </summary>
        public string SRVPH { get; set; }

        /// <summary>
        /// Informar o caractere S se foi solicitado o serviço de Telegrama Duas-Horas
        /// </summary>
        public string SRVDH { get; set; }

        /// <summary>
        /// Dia, Mês, Ano, Hora, Minuto e Segundo para os serviços de data e hora(dd/mm/aaaa hh:00:00)
        /// </summary>
        public string DataPredatado { get; set; }

        /// <summary>
        /// Código da imagem que será impressa no cabeçalho do Telegrama
        /// </summary>
        public string ImgemCabecalho { get; set; }

        /// <summary>
        /// Código da imagem que será impressa no rodapé do Telegrama
        /// </summary>
        public string ImagemRodape { get; set; }

        /// <summary>
        /// Informar o caractere N se oretorno do serviço se efetivará com entrega pelos Correios. Informar o caractere E se o retorno do serviço será por meio
        /// de correio eletrônico
        /// </summary>
        public string RetornoServico { get; set; }

        /// <summary>
        /// Identificação do operador que confeccionou o Telegrama
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Informar o caractere 1 no caso de destinatário internacional e 0 no caso de destinatário nacional
        /// </summary>
        public bool Internacional { get; set; }

        /// <summary>
        /// Tipo de Registro: 2 (dois). Texto do Telegrama
        /// </summary>
        public TelegramaTexto TelegramaTexto { get; set; }

        /// <summary>
        /// Coleção do Tipo de Registro: 3 (três). Dados do(s) Destinatário(s) do Telegrama
        /// </summary>
        public IList<TelegramaDestinatario> TelegramaDestinatarios { get; set; }

        #endregion Propriedades

        #region Construtor

        /// <summary>
        /// Instancia a classe e inicializa as variáveis
        /// </summary>
        public TelegramaRemetente()
        {
            OID = new Random().Next(999999999);
            TelegramaDestinatarios = new List<TelegramaDestinatario>();
        }

        #endregion Construtor

        /// <summary>
        /// Cria um registo de dados do telegrama e do remetente
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TelegramaRemetente Create(TelegramaRemetente value)
        {
            var result = new TelegramaRemetente();
            result.Assunto = value.Assunto;
            result.OIDRemetente = value.OIDRemetente;
            result.Nominal = value.Nominal;
            result.Endereco = value.Endereco;
            result.Telefone = value.Telefone;
            result.Email = value.Email;
            result.DataEnvio = value.DataEnvio;
            result.DataCadastro = value.DataCadastro;
            result.SRVCC = value.SRVCC;
            result.SRVPC = value.SRVPC;

            return result;
        }
    }
}