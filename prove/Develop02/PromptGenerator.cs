using System;

// // creates a public class 'PromptGenerator'
// public class PromptGenerator
// {
//     {   
//         // creates member variable
//         public string _prompt;

//         // Creates a new instance of Prompt
//         Prompt prompt1 = new Prompt();
//         prompt1._question = "Who did you talk to today?";
        
//         Prompt prompt2 = new Prompt();
//         prompt2.question = "What scripture did you read today?";
        
//         Prompt prompt3 = new Prompt();
//         prompt3.question = "What spiritual promptings did you receive today?";

//         Prompt prompt4 = new Prompt();
//         prompt4.question = "What was the most inspiring thing you saw or heard today?";

//         Prompt prompt5 = new Prompt();
//         prompt5 = "What are you hoping to happen tomorrow?";

//         // Function that generates a prompt when given code 'Prompt();'
//         static public string PromptGenerator()
//         {
//             _prompt1.Display();
//             prompt2.Display();
//             prompt3.Display();
//             prompt4.Display();
//             prompt5.Display();

//         }
//     }
// }

public class PromptGenerator
{
    public static void main()
    {
        string[] prompts = new string[5];
        prompts[0] = "Who did you talk to today?";
        prompts[1] = "What scripture did you read today?";
        prompts[2] = "What spiritual promptings did you receive today?";
        prompts[3] = "What was the most inspiring thing you saw or heard today?";
        prompts[4] = "What are you hoping to happen tomorrow?";
        Random rnd = new Random();
        Console.WriteLine(prompts[rnd.Next(0,4)]);
    }
}