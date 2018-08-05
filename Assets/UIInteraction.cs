using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIInteraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScene");
        }
	}

    public void Exit_()
    {
        Application.Quit();
    }

    public void launchAR()
    {
        Debug.Log("Launch AR");
        SceneManager.LoadScene("Main");
    }


}
