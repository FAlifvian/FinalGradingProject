# GRADING SCORE FOR FINAL EVALUATION

These code produced a final grade based on their corresponding overall score in mandatory assignment
and additional assignment. 

The mandatory assignment is set to 5 tasks, while additional assignment is limitless in this code. (The number of mandatory assignment can be set up).  

The overall score will be calculated from the average of mandatory assignment total score added by extra credit that student gained from additional assignment. Extra credit is calculated using the average score of any additional assignment score the students have multiplied by 10% (These can be set up) and divided by number of mandatory assignment.

Example:
Students A have mandatory assignment score of 90, 95, 90, 100, 85
with additional assignment score of 90, 90

The overall score of students A is:
average mandatory assignment score + Extra credit from additional assignment score
((90+95+90+100+85)/5) + (90+90 * (10%) / 5)

The evaluation used in these code is stored in Grade array while the lowerLimit and upperLimit array act as the range of score for evaluation. These range and evaluation are set up within the same index.
UpperLimitGrades = [59, 62, 66, 69, 72, 76, 79, 82, 86, 89, 92, 96, 100];
LowerLimitGrades = [0, 60, 63, 67, 70, 73, 77, 80, 83, 87, 90, 93, 97]; 
GradeResult = ["F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A", "A+"];

This is equal to:
Score           Grade
0-59            F
60-62           D-
63-66           D
67-69           D+
70-72           C-
73-76           C
77-79           C+
80-82           B-
83-86           B
87-89           B+
90-92           A-
93-96           A
97-100          A+

Note that the evaluation is determined using rounded score. 
Ex. 69,6 wil become 69 in determining evaluation

## About the Code
These code is written as a learning project for author that is offered in Foundation C# Course that is offered by Microsoft.

## Version
### v.1.0
- The output of the code will show the student name, total score, and final evaluation.


### v.1.1
- The mandatory assignment score and additional task score is displayed separately.
- The average score of additional task is displayed with its portion of point that added into overall score is showed within parentheses
- Total score now displayed as overall score

## Author
FAlifvian

