internal class Kluis
{
    private string _toegangscode;
    public bool IsOpen { get; private set; } 

    public Kluis()
    {
       IsOpen = false;
    }

    public string CodeInstellen(string toegangscode)
    {
        string succesBericht = """
        Code opgeslagen.
        De kluis is nu beveiligd met de nieuwe toegangscode.
        """;
        if (toegangscode.Length < 4)
        {
            return "Code is ongeldig, probeer opnieuw";
        }
        else
        {
            _toegangscode = toegangscode;
        }

        return succesBericht;
    }

    private void Opslaan()
    {
        
    }
}