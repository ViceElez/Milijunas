namespace milijunas;

public class theGame
{ 
    public static void Start(List<question> questionsList)
    {
        List<int> questionsThatAleradyCame = new List<int>();
        int j = 0;
        int br = 0;
        int i=1;
        for ( i=1; i < 16;i++)
        {
            Console.Clear();
            Console.WriteLine(i+".pitanje\n");
            Random rnd= new Random();
            j=rnd.Next(0,questionsList.Count);
            while (true)
            {
                if (questionsThatAleradyCame.Contains(j))
                {
                    j=rnd.Next(0,questionsList.Count);
                    continue;
                }
                else
                {
                    break;
                }
            }
            questionsThatAleradyCame.Add(j);
            Console.WriteLine(questionsList[j].Question+"\n");
            Console.WriteLine(questionsList[j].Option1+"\n");
            Console.WriteLine(questionsList[j].Option2+"\n");
            Console.WriteLine(questionsList[j].Option3+"\n");
            Console.WriteLine(questionsList[j].Option4+"\n");
            Console.WriteLine("Odaberite odgovor: ");
            char answer = char.Parse(Console.ReadLine());
            if (questionsList[j].Right[0] == answer)
            {
                Console.WriteLine("Tocan odgovor na "+i+". pitanje");
                Console.ReadKey();
                br = i;
            }
            else
            {
                Console.WriteLine("Netocan odgovor na "+i+".pitanje");
                Console.WriteLine("Kraj igre.Izgubili ste");
                Console.ReadKey();
                return;
            }
        }

        if (br == 15)
        {
            Console.WriteLine("Cestitke, uspjesno ste odigrali igru!");
            Console.ReadKey();
            return;
        }
    }
}