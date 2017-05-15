using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour, IPointerClickHandler {

    public Text Text;
    public Text[] textToShow;
    public Text[] textToHide;
    public GameObject inputToHide = null;
	// Use this for initialization
	void Start () {
        if (Text.text.ToLower() == "ustawienia")
        {
            foreach (Text item in textToShow)
            {
                item.enabled = false;
            }
            if (inputToHide != null)
                inputToHide.SetActive(false);
        }
        if (Text.text.ToLower().StartsWith("fullscreen"))
            Text.text = Screen.fullScreen ? "Fullscreen - TAK" : "Fullscreen - NIE";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Text.text.ToLower() == "nowa gra")
        {
            SceneManager.LoadScene("scena");
        }
        else if (Text.text.ToLower() == "ustawienia")
        {
            foreach (Text item in textToShow)
            {
                item.enabled = true;
            }
            foreach (Text item in textToHide)
            {
                item.enabled = false;
            }
            inputToHide.SetActive(true);
        }
        else if (Text.text.ToLower().StartsWith("fullscreen"))
        {
            Screen.fullScreen = !Screen.fullScreen;
            Text.text = Screen.fullScreen ? "Fullscreen - TAK" : "Fullscreen - NIE";

        }
        else if (Text.text.ToLower() == "wróć") {
            foreach (Text item in textToShow)
            {
                item.enabled = true;
            }
            foreach (Text item in textToHide)
            {
                item.enabled = false;
            }
            inputToHide.SetActive(false);
        }
        else if (Text.text.ToLower() == "wyjście")
        {
            Application.Quit();
        }
    }
}
