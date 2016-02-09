using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bark : MonoBehaviour {

    // The button we are going to make bark (by changing the text)
    public Button button;

    // Tracks the number of button clicks
    int woofCounter;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Change button text to display the number of times barked
    public void AddBark() 
    {
        if (button) 
        {
            // Get text to change
            Text buttonText = button.GetComponentInChildren<Text>();   
            ++woofCounter;  // increment button click counter
            buttonText.text = woofCounter + " Woof";    // Update text
        }
    }
}
