using System.Text.Json;

namespace DataAccessLayer
{
    public class ToLowerNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }

            return name.ToLower();
        }
    }
}
