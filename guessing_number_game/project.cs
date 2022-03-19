using System;


namespace number_guessing_game
{
    class project
    {
        static void Main(string[] args)
        {
            do
            {   
                int random = (new Random()).Next(1,10);
                int turn=5;
                int i=0;
                int number;
                double point=100/turn;

                while(turn>0)
                {
                    i++;
                    Console.Write("number: ");
                    number = int.Parse(Console.ReadLine());  //user guess
                    turn--;

                    if(number == random)
                    {
                        double _point = 100-(point*(i-1));   //calculate point if guess is true 
                        Console.WriteLine("Congratilations! You win.");
                        Console.WriteLine($"Total Point: {_point}");
                        break;
                    }

                    else{
                            if(turn==0)   
                                break;

                            if(random>number)  //gives clue
                                Console.WriteLine("High"); 
                            else
                                Console.WriteLine("Low");
                    }

                }
                Console.WriteLine("Game Over!");
                Console.Write("Do you want to play again? (yes/no): ");
                string result = Console.ReadLine();

                if(result=="no")
                    break;

            } while(true);
        }
    }
}