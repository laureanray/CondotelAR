using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class InitializeGPS : MonoBehaviour {

    // Use this for initialization
    public float lat = 0;
    public float lon = 0;
    public Text debugText;



    IEnumerator Start()
    {

        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield break;

        // Start service before querying location
        Input.location.Start();

        // Wait until service initializes
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            debugText.text = "Timed out";
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {

            debugText.text = "Unabled to determine device location";
            yield break;
        }
        else
        {
            // Access granted and location value could be 
            lat = Input.location.lastData.latitude;
            lon = Input.location.lastData.longitude;
        }

        // Stop service if there is no need to query location updates continuously
     
    }

    // Update is called once per frame
    void Update () {
		
	}


    public void launchARCam()
    {
        SceneManager.LoadScene("Main");
    }

}
