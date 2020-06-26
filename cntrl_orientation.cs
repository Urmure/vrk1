using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cntrl_orientation : MonoBehaviour
{
    public GameObject left, right, jump;
    void Start()
    {
        Resolution resolution = Screen.currentResolution;
        print(resolution);
        if (resolution.ToString() == "800 x 480 @ 60Hz")
        {
            print("800 na 480");
        }

        if (resolution.ToString() == "1280 x 720 @ 60Hz")
        {
            left.GetComponent<BoxCollider>().center = new Vector3(-1, 0, 0);
            left.GetComponent<BoxCollider>().size = new Vector3(2, 3, 1);
            right.GetComponent<BoxCollider>().center = new Vector3(1, 0, 0);
            right.GetComponent<BoxCollider>().size = new Vector3(2, 3, 1);
            jump.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
            jump.GetComponent<BoxCollider>().size = new Vector3(1, 3, 1);
        }

        if (resolution.ToString() == "1920 x 1080 @ 60Hz")
        {
            left.GetComponent<BoxCollider>().center = new Vector3(-3, 0, 0);
            left.GetComponent<BoxCollider>().size = new Vector3(3, 3, 1);
            right.GetComponent<BoxCollider>().center = new Vector3(3, 0, 0);
            right.GetComponent<BoxCollider>().size = new Vector3(3, 3, 1);
            jump.GetComponent<BoxCollider>().center = new Vector3(0, 0, 0);
            jump.GetComponent<BoxCollider>().size = new Vector3(2, 3, 1);
        }
    }

}
