
namespace learn{
    public class WhileDesafio3{

        public WhileDesafio3(){
            
            // string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };  
            string[] myStrings = new string[2] {  "I like pizza","I like all three of the menu choices" };  
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
    }
}