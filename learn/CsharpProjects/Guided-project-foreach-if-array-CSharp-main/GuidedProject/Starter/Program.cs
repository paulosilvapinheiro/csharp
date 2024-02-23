using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
string currentStudentLetterGrade = "";
int[] notasSofia = new int[]{90,86,87,98,100,94,90};
int[] notasAndrew = new int[]{92,89,81,96,90,89};
int[] notasEmma = new int[]{90,85,87,98,68,89,89,89};
int[] notasLogan = new int[]{90,95,87,88,96,96};
int[] notasBecky = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] notasChris = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] notasEric = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] notasGregor = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

int[] notasAlunos = new int[10];

// Student names
string[] alunos = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tGrade\n");

foreach(string aluno in alunos){

    if(aluno == "Sophia"){
        notasAlunos = notasSofia;
    }
    else if(aluno == "Andrew"){
        notasAlunos = notasAndrew;
    }
    else if(aluno == "Emma"){
        notasAlunos = notasEmma;
    }
    else if(aluno == "Logan"){
        notasAlunos = notasLogan;
    }
    else if (aluno == "Becky")
        notasAlunos = notasBecky;
    else if (aluno == "Chris")
        notasAlunos = notasChris;
    else if (aluno == "Eric")
        notasAlunos = notasEric;
    else if (aluno == "Gregor")
        notasAlunos = notasGregor;
    // else
    //     continue;

    int sumNota = 0;
    int countNota = 1;
    foreach(int nota in notasAlunos){
        
        if (countNota < 6){
            sumNota += nota;
        }else{
            sumNota += (int)(nota * 0.1);
        }
        countNota++;
    }

    decimal scoreFinal = (decimal)sumNota/currentAssignments;

    if (scoreFinal >= 97)
        currentStudentLetterGrade = "A+";

    else if (scoreFinal >= 93)
        currentStudentLetterGrade = "A";

    else if (scoreFinal >= 90)
        currentStudentLetterGrade = "A-";

    else if (scoreFinal >= 87)
        currentStudentLetterGrade = "B+";

    else if (scoreFinal >= 83)
        currentStudentLetterGrade = "B";

    else if (scoreFinal >= 80)
        currentStudentLetterGrade = "B-";

    else if (scoreFinal >= 77)
        currentStudentLetterGrade = "C+";

    else if (scoreFinal >= 73)
        currentStudentLetterGrade = "C";

    else if (scoreFinal >= 70)
        currentStudentLetterGrade = "C-";

    else if (scoreFinal >= 67)
        currentStudentLetterGrade = "D+";

    else if (scoreFinal >= 63)
        currentStudentLetterGrade = "D";

    else if (scoreFinal >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{aluno}:\t\t{scoreFinal}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
