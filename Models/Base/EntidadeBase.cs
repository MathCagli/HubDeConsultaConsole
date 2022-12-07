
namespace HubDeConsultaConsole.Models.Base
{
    public abstract class EntidadeBase
    {
        public Guid Identificador { get; private set; }
        public EntidadeBase()
        {
            Identificador = Guid.NewGuid();
        }
    }
}
