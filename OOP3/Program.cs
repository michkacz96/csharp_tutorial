namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powButt = new PowerButton(TV);

            powButt.Execute();
            powButt.Undo();
            powButt.Execute();
            powButt.Undo();
            powButt.Execute();
            powButt.Undo();
        }
    }
}