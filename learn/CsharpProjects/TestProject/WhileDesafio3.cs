
namespace learn{
    public class WhileDesafio3{
        
        public WhileDesafio3(){
            
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };  
            // string[] myStrings = new string[2] {  "I like pizza","I like all three of the menu choices" };  
            int periodLocation ;

            foreach (string item in myStrings)
            {
                string myString = item;
                periodLocation = myString.IndexOf(".");

                while (periodLocation > -1){

                    Console.WriteLine(myString.Substring(0,periodLocation).TrimStart());

                    myString=myString.Remove(0,periodLocation + 1);
                    periodLocation = myString.IndexOf(".");
                }

                if(myString.Length > 0){
                    Console.WriteLine(myString.Trim());
                }
            }
        }

        // Outra opção de solução
        // public WhileDesafio3(){
            
        //     string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };  
            
        //     int stringsCount = myStrings.Length;

        //     string myString = "";
        //     int periodLocation = 0;

        //     for (int i = 0; i < stringsCount; i++)
        //     {
        //         myString = myStrings[i];
        //         periodLocation = myString.IndexOf(".");

        //         string mySentence;

        //         // extract sentences from each string and display them one at a time
        //         while (periodLocation != -1)
        //         {

        //             // first sentence is the string value to the left of the period location
        //             mySentence = myString.Remove(periodLocation);

        //             // the remainder of myString is the string value to the right of the location
        //             myString = myString.Substring(periodLocation + 1);

        //             // remove any leading white-space from myString
        //             myString = myString.TrimStart();

        //             // update the comma location and increment the counter
        //             periodLocation = myString.IndexOf(".");

        //             Console.WriteLine(mySentence);
        //         }
            
        //         mySentence = myString.Trim();
        //         Console.WriteLine(mySentence);
        //     }
        // }
    }
}