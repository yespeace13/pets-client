using ModelLibrary.View;

namespace IS_5.Services
{
    public interface IPetsAPIClientService<TList, TEdit, TOne>
    {
        public TOne Get(string resources, int id);

        public PageSettings<TList> Get(string resources, PageSettingsView page);

        public void Post(string resources, TEdit view);

        public void Put(string resources, int id, TEdit view);

        public void Delete(string resources, int id);
    }
}
