using System.IO;

namespace WinFormsApp5
{
    public static class UserStore
    {
        public static string FilePath = "users.txt";

        public static void Save(string username, string password)
        {
            File.WriteAllText(FilePath, username + ";" + password);
        }

        public static bool Load(out string username, out string password)
        {
            username = "";
            password = "";

            if (!File.Exists(FilePath)) return false;

            var line = File.ReadAllText(FilePath);
            var parts = line.Split(';');
            if (parts.Length != 2) return false;

            username = parts[0];
            password = parts[1];
            return true;
        }
    }
}
