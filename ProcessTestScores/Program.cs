internal class Program
{
    public int[] getScores()
    {
        int[] testScores = new int[6];
        for (int i = 0; i < 6; i++) {
            Console.WriteLine("enter tests score:");
           testScores[i]=int.Parse(Console.ReadLine());
        }
        return testScores;

    }
    public void getHighestScore(int[] testScores) => Console.WriteLine("The highest score is"+testScores.Max());
    public void getLowScore(int[] score)=> Console.WriteLine("The Lowest score is" + score.Min());
    public void getAverageScore(int[] score)=> Console.WriteLine("Average Score is"+score.Average());
    private static void Main(string[] args)
    {
        Program p = new Program();
       int[] scores= p.getScores();
        p.getLowScore(scores);
        p.getHighestScore(scores);
        p.getAverageScore(scores);

    }
}