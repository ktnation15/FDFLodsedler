using FDFLodsedler.Model;

namespace FDFLodsedler.Interface
{
    public interface ILodseldler
    {
        public IEnumerable<Lodseldler> Getlodseldler();

        public Lodseldler GetAllodseldler(int id);

        public void Addlodseldler(Lodseldler lodseldler);

        public void Removelodsseldler(Lodseldler lodseldler);

        public void Update(Lodseldler lodseldler);
    }
}
