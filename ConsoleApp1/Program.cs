Console.WriteLine("Upisite rijec");
string rijec=Console.ReadLine();
string rijecSMalimSlovima = rijec.ToLower();
int j = rijecSMalimSlovima.Length-1;
int br = 0;
for (int i = 0; i < rijecSMalimSlovima.Length; i++)
{
    if (rijecSMalimSlovima == " ")
        i--;
    else
    {
        br++;
    }
}
Console.WriteLine(br);

//broj rijeci u recenici i broj slova u recenici

