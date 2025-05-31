using System;
using System.Collections.Generic;

class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public int CorrectAnswerIndex { get; set; } // zero-based index

    public Question(string text, List<string> options, int correctAnswerIndex)
    {
        Text = text;
        Options = options;
        CorrectAnswerIndex = correctAnswerIndex;
    }
}

class Program
{
    static void Main()
    {
        var questions = new List<Question>
        {
            new Question("What is the capital of France?", new List<string> { "Berlin", "London", "Paris", "Madrid" }, 2),
            new Question("Which planet is known as the Red Planet?", new List<string> { "Earth", "Mars", "Jupiter", "Venus" }, 1),
            new Question("Who wrote 'Hamlet'?", new List<string> { "Charles Dickens", "William Shakespeare", "Mark Twain", "Jane Austen" }, 1),
            new Question("What is the largest ocean on Earth?", new List<string> { "Atlantic", "Indian", "Arctic", "Pacific" }, 3),
        };

        var rnd = new Random();
        int score = 0;

        Console.WriteLine("Welcome to the Quiz! Answer by entering option number.\n");

        // Shuffle questions by random order
        var shuffled = new List<Question>(questions);
        for (int i = shuffled.Count - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            var temp = shuffled[i];
            shuffled[i] = shuffled[j];
            shuffled[j] = temp;
        }

        // Ask all questions
        foreach (var q in shuffled)
        {
            Console.WriteLine(q.Text);
            for (int i = 0; i < q.Options.Count; i++)
                Console.WriteLine($"{i + 1}. {q.Options[i]}");

            Console.Write("Your answer (1-{0}): ", q.Options.Count);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userAnswer) &&
                userAnswer - 1 == q.CorrectAnswerIndex)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong! Correct answer: {q.Options[q.CorrectAnswerIndex]}\n");
            }
        }
        Console.WriteLine($"Quiz finished! Your score: {score} / {questions.Count}");
    }
}
