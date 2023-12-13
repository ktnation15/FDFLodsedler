using FDFLodsedler.Data;
using FDFLodsedler.Interface;
using FDFLodsedler.Model;

namespace FDFLodsedler.Services
{
    
    public class BestyrelseService : IBestyrelse
    {
        private ApplicationDBContext Context;

        public BestyrelseService(ApplicationDBContext context)
        {
            Context = context;
        }

        public void AddMedlemmer(Bestyrelse bestyrelse)
        {
            Context.Bestyrelses.Add(bestyrelse);
            Context.SaveChanges();
        }

        public IEnumerable<Bestyrelse> GetMedlemmer()
        {
            return Context.Bestyrelses;
        }

        public Bestyrelse GetMedlemmer(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveMedlemmer(Bestyrelse bestyrelse)
        {
            throw new NotImplementedException();
        }

        public void UpdateMedlemmer(Bestyrelse bestyrelse)
        {
            throw new NotImplementedException();
        }
    }
}
