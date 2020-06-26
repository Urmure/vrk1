using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    private bool pathV, pathH;

    private GameObject[] masObH, masObV, mas;
    private Vector3[] masVecH, masVecV, masVecEndH, masVecEndV;

    private void Start()
    {
        pathV = true;
        pathH = true;

        masObH = GameObject.FindGameObjectsWithTag("blockMoveHorizontal");
        masObV = GameObject.FindGameObjectsWithTag("blockMoveVertical");

        masVecH = new Vector3[masObH.Length];
        masVecV = new Vector3[masObV.Length];
        masVecEndH = new Vector3[masObH.Length];
        masVecEndV = new Vector3[masObV.Length];
        mas = new GameObject[masObH.Length + masObV.Length];

        for (int i = 0; i < masObH.Length; i++)
        {
            masVecH[i] = new Vector3(masObH[i].GetComponent<Transform>().position.x, masObH[i].GetComponent<Transform>().position.y, masObH[i].GetComponent<Transform>().position.z);
            masVecEndH[i] = new Vector3(masObH[i].GetComponent<Transform>().position.x + 5f, masObH[i].GetComponent<Transform>().position.y, masObH[i].GetComponent<Transform>().position.z);
            mas[i] = masObH[i];
        }

        for (int i = 0; i < masObV.Length; i++)
        {
            masVecV[i] = new Vector3(masObV[i].transform.position.x, masObV[i].transform.position.y, masObV[i].transform.position.z);
            masVecEndV[i] = new Vector3(masObV[i].transform.position.x, masObV[i].transform.position.y + 5f, masObV[i].transform.position.z);
            mas[i + masObH.Length] = masObV[i];
        }

    }


private void FixedUpdate()
    {
        foreach (GameObject child in mas)
        {
            if (child.tag == "blockMoveVertical")
            {
                if (pathV == true)
                {
                    for (int i = 0; i < masObV.Length; i++)
                    {
                        child.transform.position = Vector3.MoveTowards(child.transform.position, masVecEndV[i], Time.deltaTime * 4f);
                        if (child.transform.position == masVecEndV[i]) pathV = false;
                        print(masVecV[i]);
                        print("K" + masVecEndV[i]);
                    }
                }

                if (pathV == false)
                {
                    for (int i = 0; i < masObV.Length; i++)
                    {
                        child.transform.position = Vector3.MoveTowards(child.transform.position, masVecV[i], Time.deltaTime * 4f);
                        if (child.transform.position == masVecV[i]) pathV = true;
                    }
                }
            }
            if (child.tag == "blockMoveHorizontal")
            {
                if (pathH == true)
                {
                    for (int i = 0; i < masObH.Length; i++)
                    {
                        child.transform.position = Vector3.MoveTowards(child.transform.position, masVecEndH[i], Time.deltaTime * 4f);
                        if (child.transform.position == masVecEndH[i]) pathH = false;
                    }
                }

                if (pathH == false)
                {
                    for (int i = 0; i < masObH.Length; i++)
                    {
                        child.transform.position = Vector3.MoveTowards(child.transform.position, masVecH[i], Time.deltaTime * 4f);
                        if (child.transform.position == masVecH[i]) pathH = true;

                    }
                }
            }
        }
    }
}
