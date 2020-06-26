using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coin;
    public Transform block;

    void Start()
    {
        foreach (Transform child in block)
        {
            Instantiate(coin, new Vector3(child.position.x, child.position.y + 1.6f, 0), Quaternion.identity);
        }
    }

}
