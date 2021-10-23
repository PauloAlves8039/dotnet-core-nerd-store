using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain.Entities
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }
    }
}
