using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Transform player;

    private void OnMouseDown()
    {
        player.rotation = Quaternion.Euler(0, 0, 0);
    }
    private void OnMouseDrag()
    {
            player.position = new Vector3(player.position.x + 10f * Time.deltaTime, player.position.y, player.position.z);

    }
}
