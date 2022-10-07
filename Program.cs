namespace FileIoAddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputOutput readOrWrite = new InputOutput();
            string path = @"C:\Users\AZ\Desktop\myproject\FileIoAddressBook\AddressBookFile.txt";
            readOrWrite.Read(path);
            readOrWrite.Write(path);
            Console.ReadLine();
        }
    }
}