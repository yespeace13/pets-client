using ModelLibrary.View;

namespace PetsClient.Services
{
    public interface IPetsAPIClientService<TList, TEdit, TOne>
    {
        public TOne Get(string resources, int id);

        public PageSettings<TList> Get(string resources, PageSettingsView page);

        public byte[] GetFile(string resources, FilterSetting filters);

        public string? Post(string resources, TEdit view);

        public string? Put(string resources, int id, TEdit view);

        public void Delete(string resources, int id);
    }
}
