public class Program
{
    public static void Main()
    {
        // Creating a new list object as string type
        List<string> invitee = new List<string>() { "Bülent Ersoy", "Ajda Pekkan", "Tarkan", "Ebru Gündeş", "Demet Akalın" };

        Console.WriteLine("Davetliler:");
      
        //Printing the names of the invitees to the console using a for loop
        for (int i = 0; i < invitee.Count; i++)
        {
            Console.WriteLine(invitee[i]);
        }
    
    }
}