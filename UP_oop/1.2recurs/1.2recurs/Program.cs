class UP
{
    static void uniqueCombination(int l, int sum, int target, List<int> allCandidates, List<int> newCandidates)
    {
        if (sum == target)
        {
            Console.Write("{");
            for (int i = 0; i < allCandidates.Count; i++)
            {
                if (i != 0)
                {
                    Console.Write(" ");
                }
                Console.Write(allCandidates[i]);
                if (i != allCandidates.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
            return;
        }
        for (int i = l; i < newCandidates.Count; i++)
        {
            if (sum + newCandidates[i] > target)
            {
                continue;
            }
            if (i > l && newCandidates[i] == newCandidates[i - 1])
            {
                continue;
            }
            allCandidates.Add(newCandidates[i]);
            uniqueCombination(i + 1, sum + newCandidates[i], target, allCandidates, newCandidates);
            allCandidates.RemoveAt(allCandidates.Count - 1);
        }
    }
    static void Combination(List<int> newCandidates, int target)
    {
        newCandidates.Sort();
        List<int> allCandidates = new List<int>();
        uniqueCombination(0, 0, target, allCandidates, newCandidates);
    }
    public static void Main()
    {
        int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
        List<int> newCandidates = new List<int>(candidates);
        int target = 8;
        Combination(newCandidates, target);
    }
}