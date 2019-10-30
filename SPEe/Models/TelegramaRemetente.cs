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
        public DateTime? DataEnvio { get; set; }

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
        public DateTime? DataPredatado { get; set; }

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
        /// Utilizada para compor o registro
        /// </summary>
        public int NumeralZero => 0;

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        public int NumeralUm => 1;

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        public string LiteralN => "N";

        /// <summary>
        /// Utilizada para compor o registro
        /// </summary>
        public string LiteralBR = "BR";

        /// <summary>
        /// Tipo de Registro: 2 (dois). Texto do Telegrama
        /// </summary>
        public TelegramaTexto Texto { get; set; }

        /// <summary>
        /// Coleção do Tipo de Registro: 3 (três). Dados do(s) Destinatário(s) do Telegrama
        /// </summary>
        public IList<TelegramaDestinatario> Destinatarios { get; set; }

        /// <summary>
        /// Tipo de Registro: 7 (sete). Dados do cedente do Bloqueto
        /// </summary>
        public BloquetoCedente Cedente { get; set; }
        /// <summary>
        /// Tipo de Registro: 8 (oito). Texto para Instruções de Pagamento do Bloqueto
        /// </summary>
        public BloquetoPagamento Pagamento { get; set; }

        /// <summary>
        /// Coleção do Tipo de Registro: 9 (nove). Dados do sacado do Bloqueto
        /// </summary>
        public IList<BloquetoSacado> Sacados { get; set; }

        #endregion Propriedades

        #region Construtor

        /// <summary>
        /// Instancia a classe e inicializa as variáveis
        /// </summary>
        public TelegramaRemetente()
        {
            OID = new Random().Next(999999999);
            Destinatarios = new List<TelegramaDestinatario>();
            Sacados = new List<BloquetoSacado>();
        }

        #endregion Construtor

        /// <summary>
        /// Cria um registo de dados do telegrama e do remetente
        /// </summary>
        /// <param name="value">Informações do telegrama do remetente</param>
        /// <returns></returns>
        public static TelegramaRemetente Create(TelegramaRemetente value)
        {
            var result = new TelegramaRemetente();
            result.Assunto = value.Assunto.Length > 60 ? value.Assunto?.Substring(0, 60) : value.Assunto;
            result.OIDRemetente = Convert.ToInt32(value.OIDRemetente.ToString().PadLeft(9, '0'));
            result.Nominal = value.Nominal;
            result.Endereco = value.Endereco;
            result.Telefone = value.Telefone;
            result.Email = value.Email?.Length > 50 ? value.Email?.Substring(0, 50) : value.Email;
            result.DataEnvio = value.DataEnvio;
            result.DataCadastro = value.DataCadastro;
            result.SRVCC = value.SRVCC?.Length > 1 ? value.SRVCC?.Substring(0, 1) : value.SRVCC;
            result.SRVPC = value.SRVPC?.Length > 1 ? value.SRVPC?.Substring(0, 1) : value.SRVPC;
            result.SRVPH = value.SRVPH?.Length > 1 ? value.SRVPH?.Substring(0, 1) : value.SRVPH;
            result.SRVDH = value.SRVDH?.Length > 1 ? value.SRVDH?.Substring(0, 1) : value.SRVDH;
            result.DataPredatado = value.DataPredatado;
            result.ImgemCabecalho = value.ImgemCabecalho?.Length > 10 ? value.ImgemCabecalho?.Substring(0, 10) : value.ImgemCabecalho;
            result.ImagemRodape = value.ImagemRodape?.Length > 10 ? value.ImagemRodape?.Substring(0, 10) : value.ImagemRodape;
            result.RetornoServico = value.RetornoServico?.Length > 1 ? value.RetornoServico?.Substring(0, 1) : value.RetornoServico;
            result.Usuario = value.Usuario?.Length > 40 ? value.Usuario?.Substring(0, 40) : value.Usuario;
            result.Internacional = value.Internacional;
            result.Texto = value.Texto;
            value.Cedente.OID = result.OID;
            result.Cedente = value.Cedente;
            result.Pagamento = value.Pagamento;

            foreach (var destinatario in value.Destinatarios)
            {
                destinatario.OID = result.OID;
                result.Destinatarios.Add(destinatario);
            }

            foreach (var sacado in value.Sacados)
                result.Sacados.Add(sacado);

            return result;
        }
    }
}