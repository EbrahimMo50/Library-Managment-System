namespace Phase_2_DB
{
    internal static class Program
    {
        public static string connString = "Server=DESKTOP-UOED81F\\SQLEXPRESS; Database=Library; Integrated Security=True;";
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            System.Environment.Exit(0);
        }
    }
}