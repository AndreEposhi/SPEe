namespace SPEe.Models.Base
{
    /// <summary>
    /// Modelo base para todas as classes
    /// </summary>
    public abstract class ModelBase
    {
        #region Propriedades

        /// <summary>
        /// Tipo registro
        /// </summary>
        public abstract int Tipo { get; }

        #endregion Propriedades
    }
}