using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoAddressBook
{
    public class InputOutput
    {
        public void Read(string path)
        {
            using (StreamReader sw = File.OpenText(path))
            {
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
        }
        public void Write(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("FirstName   : Subodh");
                sw.WriteLine("LastName    : Nagalwade");
                sw.WriteLine("Address     : 12 ujjwal nagar");
                sw.WriteLine("PhoneNumber : 1234567890");
                sw.WriteLine("City        : Lakhni");
                sw.WriteLine("State       : Maharastra ");
                sw.WriteLine("Zip         : 441804");
                sw.WriteLine("Email       : Sub@gmail.com");
                sw.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}

