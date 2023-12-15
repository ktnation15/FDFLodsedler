using FDFLodsedler.Data;
using FDFLodsedler.Interface;
using FDFLodsedler.Migrations;
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
            Bestyrelse bestyrelse = Context.Bestyrelses.FirstOrDefault(b => b.Bestyrelse_Id == id);
            return bestyrelse;
        }

        public void RemoveMedlemmer(Bestyrelse bestyrelse)
        {
            Context.Bestyrelses.Remove(bestyrelse);
            Context.SaveChanges();
        }

        public void UpdateMedlemmer(Bestyrelse bestyrelse)
        {
            Bestyrelse Existingbestyrelse = Context.Bestyrelses.FirstOrDefault(b => b.Bestyrelse_Id == bestyrelse.Bestyrelse_Id);

            if (Existingbestyrelse != null)
            {
                Existingbestyrelse.Navn = bestyrelse.Navn;

            }
            Context.SaveChanges();
        }
    }
}