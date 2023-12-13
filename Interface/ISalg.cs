using FDFLodsedler.Model;

namespace FDFLodsedler.Interface
{
    public interface ISalg
    {
        IEnumerable<Salg> GetSalg();

        public Salg GetAllSalg(int id);

        public void AddSalg(Salg salg);

        public void RemoveSalg(Salg salg);

        public void Update(Salg salg);
    }
}
