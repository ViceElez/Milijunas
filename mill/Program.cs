using System.Diagnostics;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using milijunas;

List<question> questionsList = new List<question>();
question q1 = new question("Koji je glavni grad Hrvatske?", "A. Zagreb", "B. Split", "C. Zadar", "D. Osijek", "A. Zagreb");
questionsList.Add(q1);

question q2 = new question("Koliko planeta čini Sunčev sustav?", "A. 8", "B. 9", "C. 7", "D. 6", "A. 8");
questionsList.Add(q2);

question q3 = new question("Koja je rijeka najduža u Europi?", "A. Dunav", "B. Volga", "C. Rajna", "D. Drina", "B. Volga");
questionsList.Add(q3);

question q4 = new question("Tko je napisao 'Ilijadu' i 'Odiseju'?", "A. Homer", "B. Aristotel", "C. Platon", "D. Sofoklo", "A.Homer");
questionsList.Add(q4);

question q5 = new question("Koji je kemijski simbol za zlato?", "A. Zl", "B. Gd", "C. Au", "D. Ag", "C. Au");
questionsList.Add(q5);

question q6 = new question("Koji je najveći kontinent po površini?", "A. Afrika", "B. Europa", "C. Azija", "D. Sjeverna Amerika", "C. Azija");
questionsList.Add(q6);

question q7 = new question("Koliko nogu ima pauk?", "A. 6", "B. 8", "C. 10", "D. 12", "B. 8");
questionsList.Add(q7);

question q8 = new question("Tko je autor romana 'Zločin i kazna'?", "A. Fjodor Dostojevski", "B. Lev Tolstoj", "C. Anton Pavlovič Čehov", "D. Nikolaj Gogolj", "A. Fjodor Dostojevski");
questionsList.Add(q8);

question q9 = new question("Koja životinja je simbol mudrosti u grčkoj mitologiji?", "A. Lav", "B. Sova", "C. Vuk", "D. Delfin", "B. Sova");
questionsList.Add(q9);

question q10 = new question("Koliko minuta ima jedan sat?", "A. 50", "B. 55", "C. 60", "D. 65", "C. 60");
questionsList.Add(q10);

question q11 = new question("Koji je najbliži planet Suncu?", "A. Venera", "B. Zemlja", "C. Merkur", "D. Mars", "C. Merkur");
questionsList.Add(q11);

question q12 = new question("Koji je broj pi približno?", "A. 3.1416", "B. 3.1337", "C. 3.1214", "D. 3.1500", "A. 3.1416");
questionsList.Add(q12);

question q13 = new question("Koji ocean je najveći na svijetu?", "A. Atlantski", "B. Indijski", "C. Tihi", "D. Arktički", "C. Tihi");
questionsList.Add(q13);

question q14 = new question("Koliko kostiju ima ljudsko tijelo?", "A. 200", "B. 206", "C. 208", "D. 210", "B. 206");
questionsList.Add(q14);

question q15 = new question("Tko je bio prvi čovjek na Mjesecu?", "A. Yuri Gagarin", "B. Neil Armstrong", "C. Buzz Aldrin", "D. Michael Collins", "B. Neil Armstrong");
questionsList.Add(q15);

question q16 = new question("Koji je najviši vrh svijeta?", "A. Mont Blanc", "B. K2", "C. Mount Everest", "D. Kilimanjaro", "C. Mount Everest");
questionsList.Add(q16);

question q17 = new question("Koji jezik se najviše govori u Brazilu?", "A. Španjolski", "B. Engleski", "C. Portugalski", "D. Francuski", "C. Portugalski");
questionsList.Add(q17);

question q18 = new question("Tko je naslikao Mona Lisu?", "A. Pablo Picasso", "B. Leonardo da Vinci", "C. Michelangelo", "D. Vincent van Gogh", "B. Leonardo da Vinci");
questionsList.Add(q18);

question q19 = new question("Koje godine je Titanic potonuo?", "A. 1910", "B. 1911", "C. 1912", "D. 1913", "C. 1912");
questionsList.Add(q19);

question q20 = new question("Koliko kontinenata postoji na Zemlji?", "A. 5", "B. 6", "C. 7", "D. 8", "C. 7");
questionsList.Add(q20);

question q21 = new question("Koji je najpoznatiji detektiv u književnosti?", "A. Hercule Poirot", "B. Sherlock Holmes", "C. Miss Marple", "D. Philip Marlowe", "B. Sherlock Holmes");
questionsList.Add(q21);

question q22 = new question("Koja država ima najviše stanovnika na svijetu?", "A. Indija", "B. SAD", "C. Rusija", "D. Kina", "D. Kina");
questionsList.Add(q22);

question q23 = new question("Koji je simbol glazbene note koja traje dva takta?", "A. Cijela nota", "B. Polovinka", "C. Četvrtinka", "D. Osminka", "A. Cijela nota");
questionsList.Add(q23);

question q24 = new question("Tko je napisao 'Malu princezu'?", "A. Antoine de Saint-Exupéry", "B. Mark Twain", "C. Lewis Carroll", "D. J.R.R. Tolkien", "A. Antoine de Saint-Exupéry");
questionsList.Add(q24);

question q25 = new question("Koliko prstenova ima olimpijska zastava?", "A. 4", "B. 5", "C. 6", "D. 7", "B. 5");
questionsList.Add(q25);

bool mainmenu = true;
while (mainmenu)
{
    Console.WriteLine("\t\t DOBRODOSLI");
    Console.WriteLine("\n");
    Console.WriteLine("1.Pocetak igre\n2.Izlaz");
    int input =int.Parse(Console.ReadLine());
    
    switch (input)
    {
        case 1 :
        {
            bool submainmenu = true;
            while(submainmenu)
            {
                Console.Clear();
                Console.WriteLine("1. Nova igra\n2.Povratak na glavni izbornik");
                int subinput = int.Parse(Console.ReadLine());
                switch (subinput)
                {
                    case 1:
                    {
                        Console.Clear();
                        theGame.Start(questionsList);
                        break;
                    }
                    case 2:
                    {
                        submainmenu = false;
                        Console.Clear();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Krivi odabir, pokusaj ponovo");
                        break;
                    }
                }
            }
            
            break;
        }
        case 2:
        {
            System.Environment.Exit(0);
            break;
        }
        default:
        {
            Console.WriteLine("Krivi odabir, pokusaj ponovo");
            break;
        }
    } 
}
