#nullable disable
Console.Clear();

// quiz
Console.WriteLine("Welcome to the Quiz");
double score = 0;
Console.WriteLine("\n1) What is 3 + 3?"); 
Console.Write("Question Answer: ");int q1Input = Convert.ToInt32(Console.ReadLine());

if(q1Input == 6){
    Console.WriteLine("Correct");
    score = score + 1;
} else {
    Console.WriteLine("Wrong");
}

Thread.Sleep(1000);
Console.WriteLine("\n2) Who is your Computing Science Teacher?");
Console.Write("Question Answer: "); string q2Input = Console.ReadLine();

if(q2Input.ToLower() == "mr. veldkamp" || q2Input.ToLower() == "veldkamp" || q2Input.ToLower() == "mr. v"){
    Console.WriteLine("Correct");
    score = score + 1;
} else {
    Console.WriteLine("Wrong");
}

Thread.Sleep(1000);
Console.WriteLine("\n3) How many more questions can i think up?");
Console.Write("Question Answer (a number): "); int q3Input = Convert.ToInt32(Console.ReadLine());

if(q3Input == 0){
    Console.WriteLine("Correct");
    score = score + 1;
} else {
    Console.WriteLine("Wrong");
}

Thread.Sleep(1000);
Console.WriteLine("\n4) What are the two numbers in this sentence");
Console.Write("Question Answer (Number 1): "); int q4Input1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Question Answer (Number 2): "); int q4Input2 = Convert.ToInt32(Console.ReadLine());

if(q4Input1 == 4 || q4Input1 == 2 && q4Input2 == 4 || q4Input2 == 2 && q4Input1 != q4Input2){
    Console.WriteLine("Correct");
    score = score + 1;
} else {
    Console.WriteLine("Wrong");
}

Console.Clear();
Console.WriteLine("Calculating Score...");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("YOUR RESULTS:");
Console.WriteLine($"{score} / 4 ({((score / 4) * 100)})");
if(score >= 3) {
    Console.WriteLine("Great Job");
}
if(score <= 2) {
    Console.WriteLine("you need to study : (");
}