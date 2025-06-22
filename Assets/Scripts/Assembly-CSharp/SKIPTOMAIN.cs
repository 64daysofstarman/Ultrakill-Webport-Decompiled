using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SKIPTOMAIN : MonoBehaviour
{
	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void Update()
	{
			if (!GameProgressSaver.GetIntro() || !GameProgressSaver.GetTutorial())
			{
				SceneManager.LoadScene("Tutorial");
			}
			else
			{
				SceneManager.LoadScene("Main Menu");
			}
	}
}
