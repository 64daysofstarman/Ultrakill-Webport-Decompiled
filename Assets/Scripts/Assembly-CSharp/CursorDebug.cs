using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorDebug : MonoBehaviour
{
    public GameObject BlueImage;
    public GameObject RedImage;
    public GameObject GreenImage; 
    void Update()
    {
        if(Cursor.lockState == CursorLockMode.None)
		{
		  BlueImage.SetActive(false);
		  RedImage.SetActive(true);
		  GreenImage.SetActive(false);
		}
		if(Cursor.lockState == CursorLockMode.Locked)
		{
		  BlueImage.SetActive(true);
		  RedImage.SetActive(false);
		  GreenImage.SetActive(false);
		}
		if(Cursor.lockState == CursorLockMode.Confined)
		{
		  BlueImage.SetActive(false);
		  RedImage.SetActive(false);
		  GreenImage.SetActive(true);
		}		
    }
}
