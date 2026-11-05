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

