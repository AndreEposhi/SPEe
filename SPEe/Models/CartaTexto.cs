using SPEe.Models.Base;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 5 (cinco). Texto da Carta
    /// </summary>
    public class CartaTexto : ModelBase
    {
        #region Propriedades

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 5;

        /// <summary>
        /// Texto da Mensagem
        /// </summary>
        public string Texto { get; set; }

        #endregion Propriedades
    }
}