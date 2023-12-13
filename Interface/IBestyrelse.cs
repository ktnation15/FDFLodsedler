using FDFLodsedler.Model;

namespace FDFLodsedler.Interface
{
    public interface IBestyrelse
    {
        IEnumerable<Bestyrelse> GetMedlemmer();

        public Bestyrelse GetMedlemmer(int id);

        public void AddMedlemmer(Bestyrelse bestyrelse);

        public void RemoveMedlemmer(Bestyrelse bestyrelse);

        public void UpdateMedlemmer(Bestyrelse bestyrelse);
    }
}
