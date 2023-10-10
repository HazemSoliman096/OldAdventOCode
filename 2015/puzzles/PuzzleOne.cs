public class PuzzleOne
{
    public int getDate(string filepath)
    {
        int result = 0;
        StreamReader streamReader = new StreamReader(filepath);
        string data = streamReader.ReadToEnd();

        foreach (Char letter in data)
        {
            if (letter == '(')
            {
                result += 1;
            }
            else if (letter == ')')
            {
                result -= 1;
            }
        }
        return result;
    }
}
