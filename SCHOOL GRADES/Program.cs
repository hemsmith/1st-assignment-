using System;

namespace SCHOOL_GRADES
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal MATHEMATICSSCORE = 0;
			decimal ENGLISHSCORE = 0;
			decimal CHEMISTRYSCORE = 0;
			decimal PHYSISSCORE = 0;
			decimal ICTSCORE = 0;
			decimal ECONOMICSSCORE = 0;
			decimal CHRISTIANRELIGIOUSSTUDIESSCORE = 0;
			decimal LITERATUREINENGLISHSCORE = 0;
			decimal average = 0;
			decimal sum = 0;
			Console.WriteLine(" HELLO STUDENT: ");

			Console.Write(" ENTER YOUR MATHEMATICS SCORE: ");
			MATHEMATICSSCORE = decimal.Parse(Console.ReadLine());
			Console.Write(" ENTER YOUR ENGLISH SCORE: ");
			ENGLISHSCORE = decimal.Parse(Console.ReadLine());
			Console.Write(" ENTER YOUR CHEMISTRY SCORE: ");
			CHEMISTRYSCORE = decimal.Parse(Console.ReadLine());
			Console.Write(" ENTER YOUR PHYSIS SCORE: ");
			PHYSISSCORE = decimal.Parse(Console.ReadLine());
			Console.Write(" ENTER YOUR ICT SCORE: ");
			ICTSCORE = decimal.Parse(Console.ReadLine());
			Console.Write(" ENTER YOUR ECONOMICS SCORE: ");
			ECONOMICSSCORE = decimal.Parse(Console.ReadLine());
			Console.Write(" ENTER YOUR CHRISTIAN RELIGIOUS STUDIES SCORE: ");
			CHRISTIANRELIGIOUSSTUDIESSCORE = decimal.Parse(Console.ReadLine());
			Console.Write(" ENTER YOUR LITERATURE-IN-ENGLISH SCORE: ");
			LITERATUREINENGLISHSCORE = decimal.Parse(Console.ReadLine());
			sum = MATHEMATICSSCORE + ENGLISHSCORE + CHEMISTRYSCORE + PHYSISSCORE + ICTSCORE + ECONOMICSSCORE + CHRISTIANRELIGIOUSSTUDIESSCORE + LITERATUREINENGLISHSCORE;
			Console.WriteLine("TOTAL SCORE: " + sum);

			average = sum / 8;
			Console.WriteLine("YOUR AVERAGE SCORE IS: " + average);

			if (average > 69)
			{
				Console.Write("YOUR FINAL GRADE IS: A ");
			}
			if (average > 59 && average < 70)
			{
				Console.Write("YOUR FINAL GRADE IS: B ");
			}
			if (average > 49 && average < 60)
			{
				Console.Write("YOUR FINAL GRADE IS: C ");
			}
			if (average > 39 && average < 50)
			{
				Console.Write("YOUR FINAL GRADE IS: D ");
			}
			Console.ReadLine();
		}
	}
}
