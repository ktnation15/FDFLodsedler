using FDFLodsedler.Data;
using FDFLodsedler.Interface;
using FDFLodsedler.Migrations;
using FDFLodsedler.Model;

namespace FDFLodsedler.Services
{
    public class BetalingService : IBetaling
    {
        private ApplicationDBContext context;

        public BetalingService(ApplicationDBContext context)
        {
            this.context = context;
        }
        public void AddBetaling(Betaling betaling)
        {
            context.Betalings.Add(betaling);
            context.SaveChanges();
        }

        public Betaling GetAllBetaling(int id)
        {
            Betaling betaling = context.Betalings.FirstOrDefault(b => b.Betal_Id == id);
            return betaling;
        }

        public IEnumerable<Betaling> GetBetaling()
        {
            return context.Betalings;
        }

        public IEnumerable<Betaling> GetBetailing(int id)
        {
            return context.Betalings;
        }

        public void RemoveBetaling(Betaling betaling)
        {
            context.Betalings.Remove(betaling);
            context.SaveChanges();
        }

        public void UpdateBetaling(Betaling Updatedbetaling)
        {
            Betaling Existingbetaling = context.Betalings.FirstOrDefault(b => b.Betal_Id == Updatedbetaling.Betal_Id);
            if (Existingbetaling != null)
            {
                Existingbetaling.BørneId = Updatedbetaling.BørneId;
                Existingbetaling.PaymentMethod = Updatedbetaling.PaymentMethod;
                Existingbetaling.Amount = Updatedbetaling.Amount;


            }
            context.SaveChanges();



        }
    }
}