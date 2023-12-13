using FDFLodsedler.Data;
using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.EntityFrameworkCore;

namespace FDFLodsedler.Services
{
    public class BørneGruppeService : IBørneGruppe
    {

        private ApplicationDBContext context;

        public BørneGruppeService(ApplicationDBContext context)
        {
            this.context = context;
        }

        public void AddBørneGrupppe(BørneGruppe børn)
        {
            context.BørnGruppes.Add(børn);
            context.SaveChanges();  
        }

        public BørneGruppe GetAllBørn(int id)
        {
            BørneGruppe børngruppe = context.BørnGruppes.FirstOrDefault(b => b.Gruppe_Id == id);
            return børngruppe;
        }
        public IEnumerable<BørneGruppe> GetBørn()
        {
                return context.BørnGruppes;
            
        }

        public void RemoveBørneGruppe(BørneGruppe børn)
        {
            context.BørnGruppes.Remove(børn);
            context.SaveChanges();  
        }

        public void Update(BørneGruppe børn)
        {
            throw new NotImplementedException();
        }
    }
}
