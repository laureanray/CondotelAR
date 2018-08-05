using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

        
    public void launchAR()
    {
        Debug.Log("Launch AR");
        SceneManager.LoadScene("Main");
    }

    public void menu2()
    {
        SceneManager.LoadScene("MenuScene3");
    }
}
