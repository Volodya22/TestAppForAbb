using TestAppForAbb.Core.Interfaces;

namespace TestAppForAbb.Core.Models
{
    /// <inheritdoc cref="IAbstractEntity" />
    public class AbstractEntity : IAbstractEntity
    {
        public int Id { get; set; }
    }
}
