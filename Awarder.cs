namespace knightmoves;
public class Awarder
{
    // Add your code here
    public string CalculateAward(int points) {
        if (points > 99) {
            return "First Place";
        }
        else if (points > 49 && points < 100) {
            return "Second Place";
        }
        else {
            return "Participation Award";
        }
    }
}

//should create a method named CalculateAward that takes one parameter points and returns the string "First Place" when points are over 99
//should return the string "Second Place" from CalculateAward when points are over 49 and under 100
//should return the string "Participation Award" from CalculateAward for everything else
