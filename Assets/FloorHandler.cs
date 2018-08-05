using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorHandler : MonoBehaviour {

    public Dropdown floorDropdown;
    public Dropdown roomDropdown;

    List<string> _1F = new List<string> {
        "100",
        "101",
        "102",
        "103",
        "104",
        "105",
        "106",
        "107",
        "108",
        "109",
        "110",
        "111",
        "112",

    };
    List<string> _2F = new List<string> {
        "200",
        "201",
        "202",
        "203",
        "204",
        "205",
        "206",
        "207",
        "208",
        "209",
        "210",
        "211",
        "212",
    };
    List<string> _3F = new List<string> {
        "300",
        "301",
        "302",
        "303",
        "304",
        "305",
        "306",
        "307",
        "308",
        "309",
        "310",
        "311",
        "312",
    };
    List<string> _4F = new List<string> {
        "400",
        "401",
        "402",
        "403",
        "404",
        "405",
        "406",
        "407",
        "408",
        "409",
        "410",
        "411",
        "412",
    };
    List<string> _5F = new List<string> {
        "500",
        "501",
        "502",
        "503",
        "504",
        "505",
        "506",
        "507",
        "508",
        "509",
        "510",
        "511",
        "512",
    };

    // Use this for initialization
    void Start () {
        floorDropdown.value = 0;
        roomDropdown.ClearOptions();
        floorDropdown.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(floorDropdown);
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DropdownValueChanged(Dropdown change)
    {
        int floorDropDownIndex = floorDropdown.value;
        if(floorDropDownIndex == 0)
        {
            // First Floor
            roomDropdown.ClearOptions();
            roomDropdown.AddOptions(_1F);

        }else if(floorDropDownIndex == 1)
        {
            // Second Floor
            roomDropdown.ClearOptions();
            roomDropdown.AddOptions(_2F);
        }else if(floorDropDownIndex == 2)
        {
            // Third Floor
            roomDropdown.ClearOptions();
            roomDropdown.AddOptions(_3F);
        }
        else if(floorDropDownIndex == 3)
        {
            // Fourth Floor
            roomDropdown.ClearOptions();
            roomDropdown.AddOptions(_4F);
        }else if(floorDropDownIndex == 4)
        {
            // Fifth Floor
            roomDropdown.ClearOptions();
            roomDropdown.AddOptions(_5F);
        }
    }
}
