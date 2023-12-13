using FDFLodsedler.Data;
using FDFLodsedler.Interface;
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
            Salg salg = context.Salgs.FirstOrDefault(s=>s.Salg_Id==id);
            return salg;
        }

        public IEnumerable<Salg> GetSalg()
        {
            return context.Salgs;
        }

        public void RemoveSalg(Salg salg)
        {
            context.Salgs.Remove(salg);
        }

        public void Update(Salg salg)
        {
            throw new NotImplementedException();
        }
    }
}
