using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pouse : MonoBehaviour
{
    public GameObject menu, cntrl, otherBtn;

    private void OnMouseDown()
    {
        menu.SetActive(true);
        cntrl.SetActive(false);
        otherBtn.SetActive(false);
    }

}
