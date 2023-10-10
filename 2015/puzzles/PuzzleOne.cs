public class PuzzleOne
{
    public int getDate(string filepath)
    {
        int result = 0;
        int position = 0;

        StreamReader streamReader = new StreamReader(filepath);
        string data = streamReader.ReadToEnd();

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == '(')
            {
                result += 1;
            }
            else if (data[i] == ')')
            {
                result -= 1;
            }

            position = position == 0 ? (result == -1 ? (i + 1) : 0) : position;
        }
        Console.WriteLine(position);
        return result;
    }
}
