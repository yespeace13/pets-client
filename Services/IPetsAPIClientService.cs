using ModelLibrary.View;

namespace IS_5.Services
{
    public interface IPetsAPIClientService<T>
    {
        public T Get(string resources, int id);

        public PageSettings<T> Get(string resources, PageSettingsView page);

        public void Post(string resources, T view);

        public void Put(string resources, int id, T view);

        public void Delete(string resources, int id);
    }
}
