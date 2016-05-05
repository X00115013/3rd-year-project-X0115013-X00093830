using UnityEngine;
using System.Collections;
using System;
using System.Data;
using Mono.Data.Sqlite;
using System.Collections.Generic;
using UnityEngine.UI;

public class RegisterInput : MonoBehaviour
{
    private string connectionString;
    public InputField FirstName;
    public InputField SurName;
    public InputField Email;
    public InputField Password;
    public InputField PasswordVerifie;
    string fName, sName, email, password, passwordC;
    void Start()
    {
        connectionString = "URI=file:" + Application.dataPath + "/HighScore.sqlite";
    }
    

    public void FirstN(string nameIn)
    {

        fName = nameIn;
    }
    public void SurN(string nameIn)
    {

        sName = nameIn;
    }
    public void EmailIn(string nameIn)
    {

        email = nameIn;
    }
    public void PassW(string nameIn)
    {

        password = nameIn;
    }
    public void PassWConfirm(string nameIn)
    {

        passwordC = nameIn;
    }


    private void InsertScore(string name, int newScore)
    {

        // connects to the database
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                // string.Format allow variable to be entered {0} 1st parameter (name), {1} 2nd parameter (score)
                // / are escape characters out of the query to allow variables
                string sqlQueryInsertScore = string.Format("INSERT INTO Register(FirstName,SurName,Email,Password) VALUES(\"{0}\", \"{1}\", \"{2}\", \"{3}\")", fName, sName, email, password);

                // executes the query
                dbCmd.CommandText = sqlQueryInsertScore;
                dbCmd.ExecuteScalar(); // puts the inserted values into the database
                dbConnection.Close();
            }
        }
    }
}