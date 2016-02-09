using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeVolume : MonoBehaviour {

    // The text displaying the current volume level
    public Text volumeLevelText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AdjustVolume(Slider volumeSlider) 
    {
        if (volumeSlider && volumeLevelText) 
        {
            // Set the text based on the curent value of the slider
            volumeLevelText.text = "Volume: " + volumeSlider.value;
        }
    }
}
