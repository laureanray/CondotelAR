using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ARMain : MonoBehaviour {


    public Text debugText;
    public Text debugText2;
    public Text debugText3;
    Compass compass = new Compass();
    

	
	// Update is called once per frame
	void Update () {

    

        float acceleration_x = Input.acceleration.x * 100f;
        float acceleration_y = Input.acceleration.y * 100f;
        float acceleration_z = Input.acceleration.z * 100f;

        debugText.text = "X: " + acceleration_x + "\n" +
                        "Y: " + acceleration_y + "\n" +
                        "Z: " + acceleration_z + "\n";
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    
        debugText3.text = compass.trueHeading.ToString();
	}


    IEnumerator Start()
    {

        compass.enabled = true;






        debugText.text = "debug";
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield break;

        // Start service before querying location
        Input.location.Start(0.1f,0.1f);

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
            debugText2.text = "Timed out";
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
           
            debugText2.text = "Unabled to determine device location";
            yield break;
        }
        else
        {
            // Access granted and location value could be retrieved
            debugText2.text = "Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + "\n" + Input.location.lastData.timestamp;
        }
        

    }
}
