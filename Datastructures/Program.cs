

Console.WriteLine("Hello, please enter a word to be reversed:");
string theWord = Console.ReadLine();

Console.WriteLine(Reverse(theWord));


  
//method
static string Reverse(string x)
{
  Stack<char> myStack = new Stack<char>();
   string reversies = "";
     char[] letters =  x.ToCharArray();
    foreach (char b in letters)
    {
        myStack.Push(b);
       
       
       
    }
    foreach (char b in myStack)
    {
        reversies += b;
    }
     return reversies;
   
  
}

//char[] letters = input.ToCharArray();
//Stack<char> leettersTack = new srack<char>();

//foreach (char c in letters)
//{ lettersSTack.Push(c);


//}
//foreach (char c in lettersSTack)
//{ Console.Write(c)
//        }

