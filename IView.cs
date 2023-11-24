namespace PetsClient
{
    public interface IView
    {
        protected static DialogResult ShowErrorMessage(string error)
        {
            return MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
