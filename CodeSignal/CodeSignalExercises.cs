namespace CodeSignal;
public class CodeSignalExercises
{
    public int JourneyBegins_add(int param1, int param2) {

        if( ( param1 >= -1000 && param1 <= 1000 ) && ( param2 >= -1000 && param2 <= 1000 ) )
        {
            return param1 + param2;
        }
        
        return 0;
    }
    public int JourneyBegins_centuryFromYear(int year) {

        int modcentury =  year % 100;
        double century = year/ 100;
        
        if (modcentury > 0){
            century = century + 1;
        }
            
        return Convert.ToInt32(century);
    }

    public bool JourneyBegins_checkPalindrome(string inputString){

        string part1 = inputString.Substring(0,inputString.Length/2);
        string part2 = new string(inputString.Reverse().ToArray()).Substring(0,inputString.Length/2);

        return part1 == part2;
    }

    public int EdgeOfTheOcean_adjacentElementsProduct(int[] inputArray) {

        int resultado;
        int max;

        resultado = inputArray[0] * inputArray[1];
        max = resultado;

        for (int i = 1; i < inputArray.Length - 1; i++)
        {
            resultado = inputArray[i] * inputArray[i+1];

            if (resultado > max){
                max = resultado;
            }
        }

        return max;
    }
}
