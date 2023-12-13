using FDFLodsedler.Model;

namespace FDFLodsedler.Interface
{
    public interface Ileder
    {
        IEnumerable<Leder> GetLeder();

        public Leder GetAlleder(int id);

        public void AddLeder(Leder leder);

        public void RemoveLeder(Leder leder);

        public void UpdateLeder(Leder leder);
    }
}
