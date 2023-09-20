internal class Program
{
    private static void Main(string[] args)
    {

        int[] studentennummers = new int[4];

        

        int set = 5;

        studentennummers[0] = 3; studentennummers[1] = 7; studentennummers[2] = 1; studentennummers[3] = 12;

        Console.WriteLine(studentennummers[3]);

        if(studentennummers.Length != set)
        {

            int[] studentennummersKopie = studentennummers;
            studentennummers = new int[set];


            for (int i = 0; i < studentennummers.Length - 1; i++)
            {
                studentennummers[i] = studentennummersKopie[i];
                Console.WriteLine(studentennummersKopie[i]);
            }
            
        }

        
    }
}