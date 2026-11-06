using System;

/// <summary>
/// Returns a string with a single character replaced at the given position.
/// <param name="text">String to be modified.</param>
/// <param name="position">The index where the character will be replaced.</param>
/// <param name="letter">The replacement character.</param>
/// <returns>A string with the given character replaced at the given index.</returns>
/// </summary>
static string ReplaceCharInString(string text, int position, char letter)
{
    text = text.Remove(position, 1);
    text = text.Insert(position, letter.ToString());

    return text;
}

///Skapa ett Hangman spel!
///Be först användaren mata in ett ord.
///Be sedan användaren (eller en annan användare) att mata in en bokstav.
///Kontrollera om bokstav finns i det inmatade ordet.
///Om bokstaven finns, använd ReplaceCharInString metoden för att sätta in bokstaven på rätt plats eller platser.
///Om bokstaven inte finns, ta bort ett liv och informera användaren att gissningen var inkorrekt.
///Repetera tills användaren har gissat ordet korrekt eller fått slut på liv.
///


bool vunnit = false;
string ordet = "";
string gömdOrd = "";
string input = "";
char bokstav=' ';
int liv = 8;

Console.WriteLine("person 1: skriv in ett ord och låt inte person 2 se");

ordet = Console.ReadLine();
ordet = ordet.ToLower();

for (int i = 0; i < ordet.Length; i++)
{
    gömdOrd += "_";
}

Console.WriteLine(gömdOrd);

while (vunnit == false)
{
    Console.WriteLine($"liv kvar = {liv}");
    Console.WriteLine("person 2: gissa en bokstav");
    input = Console.ReadLine();
    input = input.ToLower();
    if (input != "")
    {
        bokstav = input[0];
    }

    Console.Clear();


    if (ordet.Contains(bokstav))
    {
        for (int i = 0;i < ordet.Length; i++)
        {
            if (ordet[i] == bokstav)
            {
                gömdOrd = ReplaceCharInString(gömdOrd, i, ordet[i]);
            }
        }
    }
    else
    {
        liv--;
        Console.WriteLine("FEL!");
    }
        Console.WriteLine(gömdOrd);

    // win lose
    if (liv < 1)
    {
        Console.WriteLine($"du förlora. Ordet var '{ordet}'");
        break;
    }
    if (ordet == gömdOrd)
    {
        Console.WriteLine($"Du vann! Ordet var '{ordet}'");
        vunnit = true;
    }
}



// version 1 utan den märkliga metoden. Skitigare kod
/*
string ordet = "";
string gissningar = "";
string bokstav;
int liv = 8;
bool vunnit = false;

Console.WriteLine("person 1: skriv in ett ord och låt inte person 2 se");

ordet = Console.ReadLine();
ordet = ordet.ToLower();

Console.Clear();


while (vunnit == false) {
    Console.WriteLine($"liv kvar = {liv}");
    Console.WriteLine("person 2: gissa en bokstav");
    
    bokstav = Console.ReadLine();
    if (bokstav != "") { 
        gissningar += bokstav[0];
    }

    Console.Clear();

    if (!ordet.Contains(bokstav))
    {
        liv -= 1;
        Console.WriteLine("fel");
    }

    if (liv == 0) {
        Console.WriteLine($"du förlorade. Ordet var '{ordet}'");
        break;
    }

    // sätt in bokstav i ordet. Ändra till märkliga metoden sen
    for  (int i = 0; i < ordet.Length; i++)
    {
        if (gissningar.Contains(ordet[i]))
        {
            Console.Write(ordet[i]);
        }
        else
        {
            Console.Write("_ ");
        }
    }

    // win kod
    for (int i = 0; i < ordet.Length; i++)
    {

        if (gissningar.Contains(ordet[i]))
        {
            if (i == ordet.Length - 1)
            {
                Console.Clear();
                Console.WriteLine($"korrekt! Ordet var {ordet}");
                vunnit = true;
                break;
            }
        }
        else
        {
            break;
        }

    }


    Console.WriteLine("");

}
*/

