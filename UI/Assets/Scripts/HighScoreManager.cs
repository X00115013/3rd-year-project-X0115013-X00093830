using UnityEngine;
using System.Collections;
using System;
using System.Data;
using Mono.Data.Sqlite;
using System.Collections.Generic;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour {

    private string connectionString;
    public GameObject scorePrefab;

    public Transform scoreParent;

    public int topScores; // used in unity to show however many scores to show

    public int saveScores;

    public InputField name; // user will enter this

    public GameObject nameDialog;

    private List<HighScoreShooter> highScores = new List<HighScoreShooter>();
    // Use this for initialization
    void Start () {
        connectionString = "URI=file:" + Application.dataPath + "/HighScore.sqlite";
        //InsertScore("JIM", 10 );
        //DeleteScore(2);
        ShowScores();

    }

    private void ShowScores()
    {
        GetScores();
        /*
        // Finds all game objects with the score tag and deletes them
        foreach (GameObject score in GameObject.FindGameObjectsWithTag("Score"))
        {
            Destroy(score);
        }*/

        for (int i = 0; i < topScores; i++)
        {

            if (i <= highScores.Count - 1)
            {
                GameObject tempObject = Instantiate(scorePrefab);

                HighScoreShooter tempScore = highScores[i];

                tempObject.GetComponent<HighScoreScript>().setScore(tempScore.name, tempScore.score.ToString(), "#" + (i + 1).ToString());

                tempObject.transform.SetParent(scoreParent);

                // Takes score and sets its scale to (1,1,1) ReceTransform
                tempObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);

            }

        }
    }





    private void GetScores()
    {
        // emptys the list so if this method is called it will be black and populate from the database
         highScores.Clear();
        // connects to the database
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQueryHighScores = "SELECT * FROM HighScores";

                // executes the query
                dbCmd.CommandText = sqlQueryHighScores;

                // reader to read inside Database

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    // Reader can Read
                    while (reader.Read())
                    {
                        // Testing purpose get the name at position 1 in the index
                        // ID is position 0, name 1, score 2 etc
                         //Debug.Log(reader.GetString(1) +": " +reader.GetInt32(2));

                        // Add from the database to the list 0 is ID, 1 is Name, 2 is score, 3 is the dateTime
                        highScores.Add(new HighScoreShooter(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3)));

                    } // end While

                    // closes the Database
                    dbConnection.Close();
                    reader.Close();
                }
            }
        }
    }

    private void InsertScore(string name, int newScore)
    {
        /*
        GetScores(); // incase database is updated
        int hsCount = highScores.Count;

        if (highScores.Count > 0)
        {
            // get the last score on the high score list
            HighScore lowest = highScores[highScores.Count - 1];

            if ((lowest != null) && (saveScores > 0) && (highScores.Count >= saveScores) && (newScore > lowest.score))
            {
                //DeleteScore(lowest.ID);
                hsCount--;
            }
        }

        if (hsCount < saveScores)
        {*/
            // connects to the database
            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    // string.Format allow variable to be entered {0} 1st parameter (name), {1} 2nd parameter (score)
                    // / are escape characters out of the query to allow variables
                    string sqlQueryInsertScore = string.Format("INSERT INTO HighScores(FirstName,Score) VALUES(\"{0}\", \"{1}\")", name, newScore);

                    // executes the query
                    dbCmd.CommandText = sqlQueryInsertScore;
                    dbCmd.ExecuteScalar(); // puts the inserted values into the database
                    dbConnection.Close();
                }
            }
        }

    private void DeleteScore(int id)
    {
        // connects to the database
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {

                string sqlQuery = string.Format("DELETE FROM HighScores WHERE PlayerID =\"{0}\"", id);

                // executes the query
                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteScalar(); // puts the inserted values into the database
                dbConnection.Close();
            }
        }
    }



    // Update is called once per frame
    void Update () {
	
	}
}
