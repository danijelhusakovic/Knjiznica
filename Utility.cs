public static class Utility
{
    public static Ucenik StringToUcenik(string input, char delimiter)
    {
        string[] splitString = input.Split(delimiter);
        int razred= int.Parse(splitString[3]);
        Ucenik result = new Ucenik(splitString[0], splitString[1], splitString[2], razred);
        return result;
    }
}