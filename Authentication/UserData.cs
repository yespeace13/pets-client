using ModelLibrary.Model.Authentication;

namespace PetsClient.Authentication
{
    public class UserData
    {
        public static List<UserPossibilities>? Possibilities { get; set; }

        public static List<string> PossibilitiesForEntity(string entity)
        {
            return Possibilities.Where(p => p.Entity == entity)
                .Select(p => p.Possibility)
                .ToList();
        }
    }
}
