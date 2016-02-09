using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsSceneManager : MonoBehaviour {

    public Slider volumeSlider;
    string sliderKey = "VOLUME_SLIDER_INITIAL_VALUE";

    public Toggle notificationsToggle;
    string toggleKey = "NOTIF_TOGGLE_INITIAL_VALUE";

    public Button barkButton;
    string buttonKey = "BARK_BUTTON_INITIAL_VALUE";

	// Use this for initialization
	void Start () 
    {
        // Check for Volume preferences, create if not exist
        if (PlayerPrefs.HasKey(sliderKey)) 
        {
            volumeSlider.value = PlayerPrefs.GetFloat(sliderKey);
        }
        else 
        {
            PlayerPrefs.SetFloat(sliderKey, volumeSlider.value);
            PlayerPrefs.Save();
        }

        // Check for Notification preferences, create if not exist
        // If toggle is checked set value to 1, else set value to 0
        if (PlayerPrefs.HasKey(toggleKey)) {
            if (PlayerPrefs.GetInt(toggleKey) == 1)
            {
                notificationsToggle.isOn = true;    
            }
            else notificationsToggle.isOn = false;
        }
        else 
        {
            if (notificationsToggle.isOn)
            {
                PlayerPrefs.SetInt(toggleKey, 1);
                PlayerPrefs.Save();
            }
            else
            {
                PlayerPrefs.SetInt(toggleKey, 0);
                PlayerPrefs.Save();
            }
            
        }

        // Check for Bark preferences, create if not exist
        if (PlayerPrefs.HasKey(buttonKey)) {
            barkButton.GetComponentInChildren<Text>().text = 
                PlayerPrefs.GetString(buttonKey);
        }
        else {
            PlayerPrefs.SetString(buttonKey, 
                barkButton.GetComponentInChildren<Text>().text);
            PlayerPrefs.Save();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Saves the currently set volume level
    public void SaveVolumeLevel() 
    {
        PlayerPrefs.SetFloat(sliderKey, volumeSlider.value);
        PlayerPrefs.Save();
    }

    // Saves the currently set notification settings (on or off)
    public void SaveNotificationSetting()
    {
        if (notificationsToggle.isOn)
        {
            PlayerPrefs.SetInt(toggleKey, 1);
        }
        else
        {
            PlayerPrefs.SetInt(toggleKey, 0);
        }

        PlayerPrefs.Save();
    }

    // Saves the currently set volume level
    public void SaveBarks()
    {
        PlayerPrefs.SetString(buttonKey, 
            barkButton.GetComponentInChildren<Text>().text);
        PlayerPrefs.Save();
    }
}
