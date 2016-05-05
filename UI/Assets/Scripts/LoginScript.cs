using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour {

    string email, password;

    public void Email(string nameIn)
    {

        email = nameIn;
    }
    public void PassW(string nameIn)
    {

        password = nameIn;
    }

}

