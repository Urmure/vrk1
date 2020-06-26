using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins_count : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
    }

    private void FixedUpdate()
    {
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
    }

}
