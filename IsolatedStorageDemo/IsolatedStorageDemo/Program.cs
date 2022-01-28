using System.IO;
using System.IO.IsolatedStorage;

namespace IsolatedStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            IsolatedStorageFile userStore = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new 
                IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStore);
            StreamWriter userWriter = new StreamWriter(userStream); 
            userWriter.WriteLine("Ezhiki i barashki");
            userWriter.Close();

            string[] files = userStore.GetFileNames("UserSettings.set");
            if (files.Length == 0)
            {
                // ...
                Console.WriteLine("yokoguluyok yok :(\n");
            }
            else
            {
                userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Open, userStore); 
                StreamReader userReader = new StreamReader(userStream); 
                string contents = userReader.ReadToEnd();

                Console.WriteLine(contents);
            }

        }
    }
}
