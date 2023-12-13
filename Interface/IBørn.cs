using FDFLodsedler.Model;

namespace FDFLodsedler.Interface
{
    public interface IBørn
    {
        IEnumerable<Børn> GetBørn();

        public Børn GetAllBørn(int id);

        public void AddBørn(Børn børn);

        public void RemoveBørn(Børn børn);

        public void Update(Børn børn);
    }
}
