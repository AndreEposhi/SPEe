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

        #region Métodos
        /// <summary>
        /// Cria um registro do tipo instruções do pagamento do bloqueto
        /// </summary>
        /// <param name="value">Informações do pagamento do bloqueto</param>
        /// <returns></returns>
        public static BloquetoPagamento Create(BloquetoPagamento value)
        {
            return new BloquetoPagamento
            {
                Instrucao = value.Instrucao
            };
        } 
        #endregion
    }
}