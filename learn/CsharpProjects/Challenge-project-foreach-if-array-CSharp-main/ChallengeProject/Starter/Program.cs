/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];  

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;
    int sumExtraCredit = 0;
    int countExtraCredit = 0;
    decimal currentStudentGrade = 0;
    decimal currentExtraCredit = 0;
    decimal currentOverallCredit = 0;
    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else{
            countExtraCredit++;
            sumExtraCredit += score ;
        }
            
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
    currentOverallCredit = (decimal)(sumAssignmentScores + (decimal)(sumExtraCredit * 0.1))/(examAssignments);
    currentExtraCredit = (decimal)(sumExtraCredit) / countExtraCredit;

    decimal currentExtraCreditPoint =  (decimal)(sumExtraCredit * 0.1) / (examAssignments );



 Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{currentOverallCredit}\t{currentStudentLetterGrade}\t{currentExtraCredit} ({currentExtraCreditPoint} pts)");    if (currentOverallCredit >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentOverallCredit >= 93)
        currentStudentLetterGrade = "A";

    else if (currentOverallCredit >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentOverallCredit >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentOverallCredit >= 83)
        currentStudentLetterGrade = "B";

    else if (currentOverallCredit >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentOverallCredit >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentOverallCredit >= 73)
        currentStudentLetterGrade = "C";

    else if (currentOverallCredit >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentOverallCredit >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentOverallCredit >= 63)
        currentStudentLetterGrade = "D";

    else if (currentOverallCredit >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-
    
    // Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\tGrade\tLetter Grade\tExtra Credit\n");
    // currentOverallCredit
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{currentOverallCredit}\t{currentStudentLetterGrade}\t{currentExtraCredit} ({currentExtraCreditPoint} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
