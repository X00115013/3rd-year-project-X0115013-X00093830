using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// List uses this IComparable for the sort
class HighScoreShooter 
{
    public int score { get; set; }
    public string name { get; set; }
    public DateTime date { get; set; }
    public int ID { get; set; }

    public HighScoreShooter(int idIn, string nameIn, int scoreIn, DateTime dateIn)
    {
        ID = idIn;
        score = scoreIn;
        name = nameIn;
        date = dateIn;
    }
    /*
    // Comparing the scores, this is the highScores.sort() uses  to sort
    public int CompareTo(HighScore other)
    {
        if (other.score > score)
        {
            return 1;
        }

        else if (other.score < score)
        {
            return -1;
        }

        else if (other.date > date)
        {
            return 1;
        }
        else if (other.date < date)
        {
            return -1;
        }

        // Same Score On the same date don't swap
        return 0;
    }*/
}

