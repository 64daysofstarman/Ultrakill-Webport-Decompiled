using UnityEngine;
using UnityEngine.EventSystems;

public class FirstPersonInputModule : StandaloneInputModule
{
    protected override MouseState GetMousePointerEventData(int id) {
		Cursor.lockState = CursorLockMode.None;
		var mouseState = base.GetMousePointerEventData(id);
		Cursor.lockState = CursorLockMode.Locked;
		return mouseState;
	}

	protected override void ProcessMove(PointerEventData pointerEvent) {
		Cursor.lockState = CursorLockMode.None;
		base.ProcessMove(pointerEvent);
		Cursor.lockState = CursorLockMode.Locked;
		Debug.Log("Process Move");
	}

	protected override void ProcessDrag(PointerEventData pointerEvent) {
		Cursor.lockState = CursorLockMode.None;
		base.ProcessDrag(pointerEvent);
		Cursor.lockState = CursorLockMode.Locked;
		Debug.Log("Process Drag");
	}
}
