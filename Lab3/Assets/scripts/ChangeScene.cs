using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // On button click, opens the specified scene
    public void ChangeSceneByName(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }
}
