//Using a stack to create a code linter (verifies if code has the correct closing and opening bracket sequences), exits as soon as the wrong matching bracket is found.

using System.Collections.Generic;
using System;

bool IsCodeCorrect(string code)
{
    Stack<char> openBracketStack = new Stack<char>();
    foreach (char currCharacterInCode in code)
    {
        bool isCharacterAnOpenBracket = currCharacterInCode == '(' || currCharacterInCode == '{' || currCharacterInCode == '[';
        if (isCharacterAnOpenBracket) //Add all the opening brackets into the stack
        {
            openBracketStack.Push(currCharacterInCode);
        }
        char? expectedClosingBracket = null;
        SetupClosingBrackets(currCharacterInCode, expectedClosingBracket); //Set the expected matchingBracket for the current pointer
        char? topOfStackBracket = null;
        if (expectedClosingBracket != null) //i.e. its not a closing bracket
        {
            if (openBracketStack.Count > 0)
                topOfStackBracket = openBracketStack.Pop();//Grab the top most item on the stack (newest added)
            if (topOfStackBracket == null) //If there is nothing popped off the stack then an opening brace is missing
            {
                Console.WriteLine("There is a missing opening brace");
                return false;
            }
            //If the top of the stack doesn't match the matching bracket then the wrong sequence of brackets has been entered
            else if (topOfStackBracket != expectedClosingBracket)
            {
                Console.WriteLine("The wrong sequence of brackets has been entered");
                return false;
            }
        }
    }
    return true;
}
void SetupClosingBrackets(char currCharacterInCode, char? expectedClosingBracket)
{
    if (currCharacterInCode == ')')
        expectedClosingBracket = '(';
    else if (currCharacterInCode == '}')
        expectedClosingBracket = '{';
    else if (currCharacterInCode == ']')
        expectedClosingBracket = '[';
    else
        expectedClosingBracket = null;
}
string codeCorrect = "if(y + x == 10 && IDExists(5)) { Console.WriteLine('True'); }";
string codeWrongCase1 = "if[y + x == 10 && IDExists(5)) { Console.WriteLine('True'); }"; // first bracket should be curved not square 
string codeWrongCase2 = "if(y + x == 10 && IDExists(5)) { Console.WriteLine('True');"; // last curly bracket missing
string codeWrongCase3 = "if(y + x == 10 && IDExists(5)) { Console.WriteLine('True'}; )"; // wrong close order


Console.WriteLine("Expecting true. " + IsCodeCorrect(codeCorrect));
Console.WriteLine("Expecting false. " + IsCodeCorrect(codeWrongCase1));
Console.WriteLine("Expecting false. " + IsCodeCorrect(codeWrongCase2));
Console.WriteLine("Expecting false. " + IsCodeCorrect(codeWrongCase3));