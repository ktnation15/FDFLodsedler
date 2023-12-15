using FDFLodsedler.Data;
using FDFLodsedler.Interface;
using FDFLodsedler.Migrations;
using FDFLodsedler.Model;

namespace FDFLodsedler.Services
{


    public class SalgService : ISalg
    {

        private ApplicationDBContext context;

        public SalgService(ApplicationDBContext context)
        {
            this.context = context;
        }

        public void AddSalg(Salg salg)
        {
            context.Salgs.Add(salg);
            context.SaveChanges();
        }

        public Salg GetAllSalg(int id)
        {
            Salg salg = context.Salgs.FirstOrDefault(s => s.Salg_Id == id);
            return salg;
        }

        public IEnumerable<Salg> GetSalg()
        {
            return context.Salgs;
        }

        public void RemoveSalg(Salg salg)
        {
            context.Salgs.Remove(salg);
            context.SaveChanges();
        }

        public IEnumerable<Salg> TopSalg()
        {


            var TopSellers = context.Salgs.OrderByDescending(s => s.AntalSolgt)

             .Take(1);
            return TopSellers;
        }

        public void Update(Salg Updatesalg)
        {
            Salg Existingsalg = context.Salgs.FirstOrDefault(s => s.Salg_Id == Updatesalg.Salg_Id);

            if (Existingsalg != null)
            {
                Existingsalg.BørneId = Updatesalg.BørneId;
                Existingsalg.AntalSolgt = Updatesalg.AntalSolgt;
                Existingsalg.AntalReturneret = Updatesalg.AntalReturneret;
            }

            context.SaveChanges();
        }
    }
}