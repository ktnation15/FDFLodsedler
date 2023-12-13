using FDFLodsedler.Data;
using FDFLodsedler.Interface;
using FDFLodsedler.Model;

namespace FDFLodsedler.Services
{
    public class LodseldlerService : ILodseldler
    {

        private ApplicationDBContext Context;

        public LodseldlerService(ApplicationDBContext context)
        {
            Context = context;
        }

        public void Addlodseldler(Lodseldler lodseldler)
        {
            Context.Lodsedlers.Add(lodseldler);
            Context.SaveChanges();
        }

        public Lodseldler GetAllodseldler(int id)
        {
            Lodseldler lodseldler= Context.Lodsedlers.FirstOrDefault(l=>l.Lod_Id==id);

            return lodseldler;
        }

        public IEnumerable<Lodseldler> Getlodseldler()
        {
            return Context.Lodsedlers;
        }

        public void Removelodsseldler(Lodseldler lodseldler)
        {
            Context.Lodsedlers.Remove(lodseldler);
            Context.SaveChanges(); ;
        }

        public void Update(Lodseldler lodseldler)
        {
            throw new NotImplementedException();
        }
    }
}
