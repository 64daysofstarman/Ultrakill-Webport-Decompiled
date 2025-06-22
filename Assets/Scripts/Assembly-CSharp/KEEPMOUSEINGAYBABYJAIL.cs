using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Note: This Script was made by Cake Logic to combat the camera issues in Level 0-2
//I Call it a KEEPMOUSEINGAYBABYJAIL because it rhymes with grug
public class KEEPMOUSEINGAYBABYJAIL : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject OptionsMenu;
    void Update()
    {
        if (PauseMenu.activeSelf || OptionsMenu.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
