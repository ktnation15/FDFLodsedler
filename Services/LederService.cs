using FDFLodsedler.Data;
using FDFLodsedler.Interface;
using FDFLodsedler.Model;

namespace FDFLodsedler.Services
{
    public class LederService : Ileder
    {

        private ApplicationDBContext Context;

        

        public LederService(ApplicationDBContext context)
        {
            Context = context;
        }

        public void AddLeder(Leder leder)
        {
           Context.Leders.Add(leder);
           Context.SaveChanges();
        }

        public Leder GetAlleder(int id)
        {
            Leder leder = Context.Leders.FirstOrDefault(L => L.Leder_Id == id);
            return leder; ;
        }

        public IEnumerable<Leder> GetLeder()
        {
           return Context.Leders;
        }

        public void RemoveLeder(Leder leder)
        {
            Context.Leders.Remove(leder);
            Context.SaveChanges();
        }

        public void UpdateLeder(Leder leder)
        {
            throw new NotImplementedException();
        }
    }
}
