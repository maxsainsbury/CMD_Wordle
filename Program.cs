using System;

class Program {
  static void Main() {
    string[] answerString = {"thing", "hello", "shine", "pizza", "allow", "alone", "floor", "check", "build", "drive"};
    Random rnd = new Random();
    string answer = "";
    string guess;
    bool quit = false;
    bool reset = true;

    while (!quit) {
      if (reset == true) {
        int answerRnd = rnd.Next(0, answerString.Count());
        Console.WriteLine(answerString.Count());
        answer = answerString[answerRnd];
        reset = false;
      }
      Console.Write("Input a 5 letter word: ");
      guess = Console.ReadLine();
      if (guess.Length == 5) {
        for (int i = 0; i < guess.Length; i++) {
          bool right = false;
          for (int j = 0; j < answer.Length; j++) {
            if (guess[i].Equals(answer[j])) {
              if (j == i) {
                Console.WriteLine((i + 1) + " letter is right");
                right = true;
              }
              else if (j != i){
                Console.WriteLine((i + 1) + " letter is in the wrong spot");
                right = true;
              }
            }
          }
          if (!right) {
            Console.WriteLine((i + 1) + " letter is worng");
          }
          right = false;
        }
        if (guess.Equals(answer)) {
          Console.WriteLine("You Win!");
          Console.WriteLine("Do you want to keep playing?");
          Console.Write("YES or NO: ");
          string quitString = Console.ReadLine();
          quitString = quitString.ToUpper();
          if (quitString == "NO") {
            quit = true;
          }
          else {
            quit = false;
            reset = true;
          }
        }
      }
      else {
        Console.WriteLine("That was a " + guess.Length + " letter word");
      }
    }
  }
}



