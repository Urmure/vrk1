using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cntrlJump : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    public Vector3 playerPos;

    private void OnMouseDown()
    {
            playerPos = player.GetComponent<Transform>().position;
    }

    private void OnMouseUp()
    {
            player.position = new Vector3(playerPos.x, playerPos.y + 250f * Time.deltaTime, -1); 
    }
}
