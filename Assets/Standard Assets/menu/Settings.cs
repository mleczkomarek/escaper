using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

    public InputField musicControl;

	// Use this for initialization
	void Start () {
        musicControl.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        musicControl.text = (AudioListener.volume * 100).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void ValueChangeCheck() {
        int value;
        if (int.TryParse(musicControl.text, out value)) {

            if (value < 0)
            {
                value = 0;
                musicControl.text = "0";
            }
            if (value > 100)
            {
                value = 100;
                musicControl.text = "100";
            }


            float audioVolume = (float)value / 100.0f;

            AudioListener.volume = audioVolume;
        }
    }
}
