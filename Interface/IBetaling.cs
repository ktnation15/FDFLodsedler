using FDFLodsedler.Model;

namespace FDFLodsedler.Interface
{
    public interface IBetaling
    {
        IEnumerable<Betaling> GetBetaling();

        public Betaling GetAllBetaling(int id);

        public void AddBetaling(Betaling betaling);

        public void RemoveBetaling(Betaling betaling);

        public void UpdateBetaling(Betaling betaling);

    }
}