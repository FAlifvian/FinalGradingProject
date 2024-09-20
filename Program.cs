// See https://aka.ms/new-console-template for more information

/*
        GRADING SCORE
            These code produced an evaluation or final grade 
            based on their corresponding average score in all assignment.

            If there are any students with number of score more than total assignment number,
            These score will be evaluated as additional score.
            These each additional score will be multiplied by 10% and added to total grade score before 
            calculating its average score (without adding the number of additional score to assignment number).

            The executed code will show the student name, their average score, and their final evaluation

            Note that the evaluation is determined using rounded score. 
            Ex. 69,6 wil become 69 in determining evaluation
*/

string[] studentNames = ["Sophia", "Jones", "Frank", "Meter"];

int assignmentNumber = 5;
int[] sophiaGrades = [90, 86, 87, 98, 100, 94, 90];
int[] jonesGrades = [92, 89, 81, 96, 90, 89];
int[] frankGrades = [90, 85, 87, 98, 68, 89, 89, 89];
int[] meterGrades = [90, 95, 87, 88, 96, 96];

int[] upperLimitGrades = [59, 62, 66, 69, 72, 76, 79, 82, 86, 89, 92, 96, 100];
int[] lowerLimitGrades = [0, 60, 63, 67, 70, 73, 77, 80, 83, 87, 90, 93, 97]; 
string[] gradeResult = ["F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A", "A+"];

Console.WriteLine("*** Final Evaluation ***");
Console.WriteLine("Student:\tGrade:\t\tEvaluation:");

// Adding each student into evaluation list
foreach (string studentName in studentNames){

    int[] currentStudentGrades = new int[10];

    // Determine student name
    if(studentName == "Sophia")
    {
        currentStudentGrades = sophiaGrades;
    }
    else if(studentName == "Jones")
    {
        currentStudentGrades = jonesGrades;
    }
    else if(studentName == "Frank")
    {
        currentStudentGrades = frankGrades;
    }
    else if(studentName =="Meter")
    {
        currentStudentGrades = meterGrades;
    }

    // Calculating sum for determining average grade for score in assignment number
    float totalSum = 0;
    int currentAssignmentNumber = 0;

    foreach (int currentStudentGrade in currentStudentGrades)
    {
        // For scores inside assignment
        if(currentAssignmentNumber < assignmentNumber)
        {
            totalSum += currentStudentGrade;
        } 
        // For scores outside assignment (regarded as additional scores)
        else if (currentAssignmentNumber >= assignmentNumber)
        {
            totalSum += (float)currentStudentGrade / 10f;
        }
        currentAssignmentNumber++;
    }

    // Average grade value
    float averageGrade = totalSum / (float)assignmentNumber;
    averageGrade = MathF.Round(averageGrade, 1);

    // Evaluating grade value
    string evaluatedGrade = "--";
    float roundedAverageGrade = MathF.Round(averageGrade);
    
    for (int i = 0; i < upperLimitGrades.Length; i++){
        if(roundedAverageGrade <= (float)upperLimitGrades[i] && roundedAverageGrade >= (float)lowerLimitGrades[i]){
            evaluatedGrade = gradeResult[i];
        } 
    }

    // Display student name and his/her average grade
    Console.WriteLine($"{studentName}:\t\t{averageGrade}\t\t{evaluatedGrade}"); 
}