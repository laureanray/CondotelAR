using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomHandler : MonoBehaviour {

    public Dropdown dropdown;

    List<string> m_DropOptions = new List<string> { "Option 1", "Option 2" };
	// Use this for initialization
	void Start () {
        dropdown.ClearOptions();
        dropdown.AddOptions(m_DropOptions);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
