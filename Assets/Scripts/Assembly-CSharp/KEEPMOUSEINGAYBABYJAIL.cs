using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Note: This Script was made by Cake Logic to combat the camera issues in Level 0-2
//I Call it a KEEPMOUSEINGAYBABYJAIL because it rhymes with grug
public class KEEPMOUSEINGAYBABYJAIL : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject OptionsMenu;
    public GameObject Intro;
    public GameObject Intro2;
    public bool UsingIntro;
    void Update()
    {
        if (PauseMenu.activeSelf || OptionsMenu.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (UsingIntro == true)
        {
            if (Intro.activeSelf || Intro2.activeSelf)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            if (!Intro.activeSelf && !Intro2.activeSelf)
            {
                UsingIntro = false;
            }
        }
        if (!PauseMenu.activeSelf && !OptionsMenu.activeSelf && !Intro.activeSelf && !Intro2.activeSelf)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
