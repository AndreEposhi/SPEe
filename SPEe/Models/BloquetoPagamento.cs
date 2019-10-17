using SPEe.Models.Base;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 8 (oito). Texto para Instruções de Pagamento do Bloqueto
    /// </summary>
    public class BloquetoPagamento : ModelBase
    {
        #region Propriedades

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 8;

        /// <summary>
        /// Texto para instruções de pagamento
        /// </summary>
        public string Instrucao { get; set; }

        #endregion Propriedades
    }
}