using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanvasSwitch : MonoBehaviour {
    private GameObject GameMenuPanel, OptionCanvas, RegisterCanvas, GameSelectCanvas, LoginCanvas, CreditsCanvas,FlightGame, PickUpGame, SnookerGame;
    void Awake()
    {
        GameMenuPanel = GameObject.Find("GameMenuPanel");
        OptionCanvas = GameObject.Find("OptionsView");
        RegisterCanvas = GameObject.Find("RegisterView");
        GameSelectCanvas = GameObject.Find("GameSelectView");
        LoginCanvas = GameObject.Find("LoginView");
        CreditsCanvas = GameObject.Find("creditsView");
        FlightGame = GameObject.Find("FlightGame");
        PickUpGame = GameObject.Find("PickUp");
        SnookerGame = GameObject.Find("Snooker");
    }

    void Start()
    {
        GameMenuPanel.SetActive(true);
        OptionCanvas.SetActive(false);
        RegisterCanvas.SetActive(false);
        GameSelectCanvas.SetActive(false);
        LoginCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
        FlightGame.SetActive(false);
        PickUpGame.SetActive(false);
        SnookerGame.SetActive(false);

    }

}

