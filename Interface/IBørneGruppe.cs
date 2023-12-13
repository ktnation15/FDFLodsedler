using FDFLodsedler.Model;

namespace FDFLodsedler.Interface
{
    public interface IBørneGruppe
    {
        IEnumerable<BørneGruppe> GetBørn();

        public BørneGruppe GetAllBørn(int id);

        public void AddBørneGrupppe(BørneGruppe børn);

        public void RemoveBørneGruppe(BørneGruppe børn);

        public void Update(BørneGruppe børn);
    }
}
