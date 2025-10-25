using System;
using System.Linq;


// Ex 06
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Please, insert some words :)");

//        string fullwords = Console.ReadLine();
//        string[] words = fullwords.Split(' ');

//        bool allSameLength = HaveAllSameLength(words);

//        if (allSameLength)
//            Console.WriteLine("All words have the same length!");
//        else
//            Console.WriteLine("The words have different lengths.");
//    }

//    private static bool HaveAllSameLength(string[] strings)
//    {
//        int firstLength = strings[0].Length;
//        int i = 1;
//        while (i < strings.Length)
//        {
//            if (strings[i].Length != firstLength)
//                return false;
//            i++;    
//        }

//        return true;
//    }
//}

// Ex 07
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Please, insert some words :)");

//        string fullwords = Console.ReadLine();
//        string[] words = fullwords.Split(' ');

//        int totalLength = SumAllLengths(words);

//        Console.WriteLine("Total length of all words: " + totalLength);
//    }

//    private static int SumAllLengths(string[] strings)
//    {
//        int sum = 0;
//        int i = 0;
//        while (i < strings.Length)
//        {
//            sum = sum + strings[i].Length;
//            i++;
//        }
//        return sum;
//    }
//}

// Ex 08
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Please, insert a text :)");

//        string text = Console.ReadLine();
//        string result = ReplaceLetters(text);

//        Console.WriteLine("Result: " + result);
//    }

//    private static string ReplaceLetters(string text)
//    {
//        text = text.Replace('v', 'b');
//        text = text.Replace("ão", "om");
//        return text;
//    }
//}

// Ex 09
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Please, insert a text :)");

//        string text = Console.ReadLine();
//        bool isNumeric = IsOnlyDigits(text);

//        if (isNumeric)
//            Console.WriteLine("The text contains only digits!");
//        else
//            Console.WriteLine("The text contains other characters.");
//    }
//    private static bool IsOnlyDigits(string text)
//    {
//        int i = 0;
//        while (i < text.Length)
//        {
//            if (text[i] < '0' || text[i] > '9')
//                return false;
//            i++;
//        }
//        return true;
//    }
//}

// Ex 10
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Please, insert a text :)");

//        string text = Console.ReadLine();
//        bool hasNoDigits = HasNoDigits(text);

//        if (hasNoDigits)
//            Console.WriteLine("The text does not contain digits!");
//        else
//            Console.WriteLine("The text contains digits.");
//    }

//    private static bool HasNoDigits(string text)
//    {
//        int i = 0;
//        while (i < text.Length)
//        {
//            if (text[i] >= '0' && text[i] <= '9')
//                return false;
//            i++;
//        }
//        return true;
//    }
//}

// Ex 11
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Please, insert the first word :)");
//        string word1 = Console.ReadLine();

//        Console.WriteLine("Please, insert the second word :)");
//        string word2 = Console.ReadLine();

//        string result = CompareAlphabetically(word1, word2);
//        Console.WriteLine(result);
//    }

//    private static string CompareAlphabetically(string str1, string str2)
//    {
//        int comparison = string.Compare(str1, str2);

//        if (comparison < 0)
//            return "\"" + str1 + "\" comes first alphabetically.";
//        else if (comparison > 0)
//            return "\"" + str2 + "\" comes first alphabetically.";
//        else
//            return "Both strings are equal.";
//    }
//}

// Ex 12
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        string[] names = new string[10];

//        Console.WriteLine("Please, insert 10 names:");

//        int i = 0;
//        while (i < 10)
//        {
//            Console.Write("Name " + (i + 1) + ": ");
//            names[i] = Console.ReadLine();
//            i++;
//        }

//        string[] sortedNames = SortNamesAlphabetically(names);

//        Console.WriteLine("\nNames in alphabetical order:");
//        i = 0;
//        while (i < sortedNames.Length)
//        {
//            Console.WriteLine(sortedNames[i]);
//            i++;
//        }
//    }

//    private static string[] SortNamesAlphabetically(string[] names)
//    {
//        Array.Sort(names);
//        return names;
//    }
//}

// Ex 13
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("=== JOGO DE ADIVINHAS ===\n");

//        int score = PlayQuizGame();

//        Console.WriteLine("\n=== RESULTADO FINAL ===");
//        Console.WriteLine("Você acertou " + score + " de 10 perguntas!");

//        if (score == 10)
//            Console.WriteLine("Perfeito! Você é um gênio!");
//        else if (score >= 7)
//            Console.WriteLine("Muito bem! Ótimo resultado!");
//        else if (score >= 5)
//            Console.WriteLine("Bom trabalho!");
//        else
//            Console.WriteLine("Tente novamente!");
//    }

//    private static int PlayQuizGame()
//    {
//        string[] questions = new string[10];
//        string[][] options = new string[10][];
//        int[] correctAnswers = new int[10];

//        questions[0] = "Qual a cor do cavalo branco de Napoleão?";
//        options[0] = new string[] { "1. Preto", "2. Branco", "3. Marrom" };
//        correctAnswers[0] = 2;

//        questions[1] = "Quantos meses têm 28 dias?";
//        options[1] = new string[] { "1. Um", "2. Dois", "3. Todos" };
//        correctAnswers[1] = 3;

//        questions[2] = "O que é seu, mas as outras pessoas usam mais do que você?";
//        options[2] = new string[] { "1. Seu nome", "2. Seu carro", "3. Sua casa" };
//        correctAnswers[2] = 1;

//        questions[3] = "Se você tem uma caixa de fósforos e entra em um quarto escuro com uma vela, lamparina e lareira, o que você acende primeiro?";
//        options[3] = new string[] { "1. A vela", "2. O fósforo", "3. A lareira" };
//        correctAnswers[3] = 2;

//        questions[4] = "O que fica molhado enquanto seca?";
//        options[4] = new string[] { "1. Toalha", "2. Esponja", "3. Roupa" };
//        correctAnswers[4] = 1;

//        questions[5] = "Qual o mês do ano que tem menos dias?";
//        options[5] = new string[] { "1. Janeiro", "2. Fevereiro", "3. Dezembro" };
//        correctAnswers[5] = 2;

//        questions[6] = "O pai de Maria tem 5 filhas: Nana, Nene, Nini, Nono. Qual o nome da quinta filha?";
//        options[6] = new string[] { "1. Nunu", "2. Nana", "3. Maria" };
//        correctAnswers[6] = 3;

//        questions[7] = "Se um médico te dá 3 comprimidos e diz para tomar um a cada meia hora, quanto tempo duram os comprimidos?";
//        options[7] = new string[] { "1. 1 hora", "2. 1 hora e meia", "3. 2 horas" };
//        correctAnswers[7] = 1;

//        questions[8] = "Quantos animais de cada espécie Moisés colocou na arca?";
//        options[8] = new string[] { "1. Dois", "2. Nenhum", "3. Um casal" };
//        correctAnswers[8] = 2;

//        questions[9] = "Um avião cai exatamente na fronteira entre Brasil e Argentina. Onde enterram os sobreviventes?";
//        options[9] = new string[] { "1. Brasil", "2. Argentina", "3. Não enterram sobreviventes" };
//        correctAnswers[9] = 3;

//        int score = 0;
//        int i = 0;

//        while (i < 10)
//        {
//            Console.WriteLine("Pergunta " + (i + 1) + ": " + questions[i]);

//            int j = 0;
//            while (j < 3)
//            {
//                Console.WriteLine(options[i][j]);
//                j++;
//            }

//            Console.Write("\nSua resposta (1, 2 ou 3): ");
//            string input = Console.ReadLine();
//            int answer = int.Parse(input);

//            if (answer == correctAnswers[i])
//            {
//                Console.WriteLine("Correto!\n");
//                score++;
//            }
//            else
//            {
//                Console.WriteLine("Errado! A resposta correta era " + correctAnswers[i] + ".\n");
//            }

//            i++;
//        }

//        return score;
//    }
//}

// Ex 14
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Please, insert a word :)");

//        string text = Console.ReadLine();
//        bool isPalindrome = IsPalindrome(text);

//        if (isPalindrome)
//            Console.WriteLine("\"" + text + "\" is a palindrome!");
//        else
//            Console.WriteLine("\"" + text + "\" is NOT a palindrome.");
//    }

//    private static bool IsPalindrome(string text)
//    {
//        int left = 0;
//        int right = text.Length - 1;

//        while (left < right)
//        {
//            if (text[left] != text[right])
//                return false;
            
//            left++;
//            right--;
//        }

//        return true;
//    }
//}