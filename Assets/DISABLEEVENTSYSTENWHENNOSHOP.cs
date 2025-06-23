using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DISABLEEVENTSYSTENWHENNOSHOP : MonoBehaviour
{
    public GameObject Shop;
	public FirstPersonInputModule stoopid;
	public EventSystem stoopider;
	public StandaloneInputModule stoopidest;
	//public GameObject OptionsMenu;
	//public GameObject PauseMenu;
    void Update()
    {
        if(Shop.activeSelf)
		{
		 stoopid.enabled = true;
		 //stoopider.enabled = true;
		 stoopidest.enabled = false;
		}
		if(!Shop.activeSelf)
		{
		 stoopid.enabled = false;
		 //stoopider.enabled = false;
		 stoopidest.enabled = true;
		}
    }
}
