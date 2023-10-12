class PuzzleTwo
{
    public int getTotalWrappingPaper(string input)
    {
        StreamReader streamReader = new StreamReader(input);
        string line = string.Empty;
        int total = 0;

        while ((line = streamReader.ReadLine()) != null)
        {
            total += getSum(line);
        }

        streamReader.Close();
        return total;
    }

    private int getSum(string input)
    {
        int l = int.Parse(input.Split('x')[0]);
        int w = int.Parse(input.Split('x')[1]);
        int h = int.Parse(input.Split('x')[2]);

        int[] sides = { l * w, w * h, l * h };

        Array.Sort(sides);

        int smallest = sides[0];

        int total = sides.Aggregate(smallest, (total, item) => total += item * 2);

        return total;
    }
}
