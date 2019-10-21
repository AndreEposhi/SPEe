using SPEe.Models.Base;
using SPEe.ValueObjects;
using System.Collections.Generic;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 6 (seis). Dados do(s) Destinatário(s) da Carta
    /// </summary>
    public class CartaDestinatario : ModelBase
    {
        #region Propriedades

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 6;

        /// <summary>
        /// Número inteiro, que será usado como chave única para identificação de cada Carta
        /// </summary>
        public int OID { get; set; }

        /// <summary>
        /// Número inteiro usado como chave única para identificação de cada Destinatário
        /// </summary>
        public int OIDContato { get; set; }

        /// <summary>
        /// Dados como nome, título e apelido
        /// </summary>
        public Nominal Nominal { get; set; }

        /// <summary>
        /// Endereco
        /// </summary>
        public Endereco Endereco { get; set; }

        /// <summary>
        /// Código do Endereçamento Eletrônico do Destinatário
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Dados do telefone
        /// </summary>
        public Telefone Telefone { get; set; }

        /// <summary>
        /// Informar 0 (zero) se foi solicitada entrega do telegrama no Endereço do Destinatário. Informar 1 (um) se foi solicitada entrega do telegrama na Caixa
        /// Postal do Destinatário
        /// </summary>
        public int TipoDestino { get; set; }

        /// <summary>
        /// Usado para compor o registro
        /// </summary>
        public string LiteralC => "C";

        /// <summary>
        /// Usado para compor o registro
        /// </summary>
        public string LiteralD => "D";

        /// <summary>
        /// Usado para compor o registro
        /// </summary>
        public string LiteralN => "N";

        /// <summary>
        /// Usado para compor o registro
        /// </summary>
        public int NumeralUm => 1;

        #endregion Propriedades

        #region Métodos

        /// <summary>
        /// Cria um objeto do tipo Dados do(s) Destinatário(s) da Carta
        /// </summary>
        /// <param name="value">Informações do Dados do(s) Destinatário(s) da Carta</param>
        /// <returns></returns>
        public static CartaDestinatario Create(CartaDestinatario value)
        {
            return new CartaDestinatario
            {
                OIDContato = value.OIDContato,
                Nominal = value.Nominal,
                Endereco = value.Endereco,
                Telefone = value.Telefone,
                Email = value.Email?.Length > 50 ? value.Email?.Substring(0, 50) : value.Email,
                TipoDestino = value.TipoDestino
            };
        }

        /// <summary>
        /// Cria uma coleção de objeto de  Dados do(s) Destinatário(s) da Carta
        /// </summary>
        /// <param name="values">Coleção de  Dados do(s) Destinatário(s) da Carta</param>
        /// <returns></returns>
        public static IList<CartaDestinatario> Create(IList<CartaDestinatario> values)
        {
            var result = new List<CartaDestinatario>();

            foreach (var destinatario in values)
            {
                var destinarioResult = Create(destinatario);
                result.Add(destinarioResult);
            }

            return result;
        }

        #endregion Métodos
    }
}