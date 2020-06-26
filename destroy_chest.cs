using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_chest : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "player")
        {
            if(gameObject.tag == "bigChest")
            {
                Destroy(gameObject);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 20);
            }
            else
            {
                Destroy(gameObject);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 10);
            }
        }
      
    }
}
