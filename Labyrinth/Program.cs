using System.Net;
using System;

string room = "tiny hut";
//string description = "a dingy and decrepid room with only one entrance and exit.";

while (room != "void"){
    if(room == "tiny hut"){
        Console.WriteLine($"You are in a {room}, it is a tiny hut with only one entrance and exit.");
        Console.WriteLine("Do you want to leave?");
        string where = Console.ReadLine();
        where = where.ToLower();
        if(where == "leave" || where == "yes" || where == "y"){
            Console.WriteLine($"You left {room}");
            room = "outside";
            Console.WriteLine($"You are now {room}, you are in a swamp with a very thick fog.\nWhere would you want to go?\nBig lake:\nSmall cave:\nSpaceship:");
            where = Console.ReadLine();
            where = where.ToLower();
            if (where == "go back"){
                Console.WriteLine($"You left {room}");
                room = "tiny hut";
                Console.WriteLine($"You decided to stay in {room}");
                Console.ReadLine();
                Environment.Exit();
            }
            else if (where == "stay"){
                Console.WriteLine($"You decided to stay {room}");
                Console.ReadLine();
                Environment.Exit();
            }
            
            
        }


    }
             
}



