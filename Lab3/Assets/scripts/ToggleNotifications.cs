using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleNotifications : MonoBehaviour {

    // The toggle that controls notification settings (on/off)
    public Toggle toggle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToggleNotificationsText() 
    {
        if (toggle) 
        {
            // Get text to change (Label text)
            Text toggleText = toggle.GetComponentInChildren<Text>();

            // If toggle is checked, notifications are on
            if (toggle.isOn) 
            {
                toggleText.text = "Notifications On";
            }
            else // If toggle is unchecked, notifications are off
            { 
                toggleText.text = "Notifications Off";
            }
        }
        
    }
}
