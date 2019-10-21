using SPEe.Models.Base;

namespace SPEe.Models
{
    /// <summary>
    /// Tipo de Registro: 2 (dois). Texto do Telegrama
    /// </summary>
    public class TelegramaTexto : ModelBase
    {
        #region Propriedades

        /// <summary>
        /// Tipo de registro
        /// </summary>
        public override int Tipo => 2;

        /// <summary>
        /// Texto da mensagem
        /// </summary>
        public string Texto { get; set; }

        #endregion Propriedades

        #region Métodos

        /// <summary>
        /// Cria um obejto do tipo TelegramaTexto
        /// </summary>
        /// <param name="value">Informações do texto do telegrama</param>
        /// <returns></returns>
        public static TelegramaTexto Create(TelegramaTexto value)
        {
            return new TelegramaTexto
            {
                Texto = value.Texto
            };
        }

        #endregion Métodos
    }
}