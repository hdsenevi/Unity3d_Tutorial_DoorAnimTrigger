using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour 
{
	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit rayCastHit;
			
			if(Physics.Raycast(ray.origin, ray.direction, out rayCastHit, Mathf.Infinity))
			{
				Door door = rayCastHit.transform.GetComponent<Door>();
				if(door)
				{
					door.PlayDoorAnim();
				}
			}
		}
	}
	
	void OnGUI()
	{
		 GUI.Label(new Rect(10, 10,	500, 20), "Click on the door to trigger the animations!");
	}
}
