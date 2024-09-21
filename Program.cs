// See https://aka.ms/new-console-template for more information

/*
        GRADING SCORE
            These code produced an evaluation or final grade 
            based on their corresponding average score in all assignment.  
            See README.md for more information.      
*/

string[] studentNames = ["Sophia", "Jones", "Frank", "Meter"];

const int mandatoryAssignmentNumber = 5;
const double additionalScorePercentage = 0.1;
int[] sophiaGrades = [90, 86, 87, 98, 100, 94, 90];
int[] jonesGrades = [92, 89, 81, 96, 90, 89];
int[] frankGrades = [90, 85, 87, 98, 68, 89, 89, 89];
int[] meterGrades = [90, 95, 87, 88, 96, 96];

int[] upperLimitGrades = [59, 62, 66, 69, 72, 76, 79, 82, 86, 89, 92, 96, 100];
int[] lowerLimitGrades = [0, 60, 63, 67, 70, 73, 77, 80, 83, 87, 90, 93, 97]; 
string[] gradeResult = ["F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A", "A+"];

Console.WriteLine("*** Final Evaluation ***");
Console.WriteLine("Student:\tExam Score:\tOverall:\tGrade:\t\tExtra Credit:");

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

    // Calculating total overall score, total of only assignment score, and total of only additional score
    double totalOverallScore = 0;
    double totalAssignmentScore = 0;
    double totalAdditionalScore = 0;

    int currentAssignmentNumber = 0;
    int additionalNumber = 0;
    foreach (int currentStudentGrade in currentStudentGrades)
    {
        // For only assignment score
        if(currentAssignmentNumber < mandatoryAssignmentNumber)
        {
            totalOverallScore += currentStudentGrade;
            totalAssignmentScore += currentStudentGrade;
        } 
        // For only additional score
        else if (currentAssignmentNumber >= mandatoryAssignmentNumber)
        {
            totalOverallScore += (double)currentStudentGrade * additionalScorePercentage;
            totalAdditionalScore += currentStudentGrade;
            additionalNumber += 1;
        }
        currentAssignmentNumber++;
    }

    // Calculating average overall, only assignment, and only additional score
    double averageOverallScore = Math.Round((totalOverallScore / mandatoryAssignmentNumber), 2);
    double averageAssignmentScore = totalAssignmentScore / mandatoryAssignmentNumber;
    double averageAdditionalScore = totalAdditionalScore / additionalNumber;

    // Calculating extra credit point to add into exam score to gain overall score
    double extraCreditPoint = totalAdditionalScore * (additionalScorePercentage/mandatoryAssignmentNumber);

    // Evaluating grade value from overall score
    string evaluatedGrade = "";
    double roundedAverageOverallScore = Math.Round(averageOverallScore);
    
    for (int i = 0; i < upperLimitGrades.Length; i++){
        if(roundedAverageOverallScore <= upperLimitGrades[i] && roundedAverageOverallScore >= lowerLimitGrades[i]){
            evaluatedGrade = gradeResult[i];
        } 
    }

    // Display student name and his/her average grade
    Console.WriteLine($"{studentName}:\t\t{averageAssignmentScore}\t\t{averageOverallScore}\t\t{evaluatedGrade}\t\t{averageAdditionalScore} ({extraCreditPoint} pts)"); 
}