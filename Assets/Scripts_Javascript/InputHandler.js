#pragma strict

function Update () 
{
	if(Input.GetMouseButton(0))
	{
		var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		var rayCastHit : RaycastHit;
		
		if(Physics.Raycast(ray.origin, ray.direction, rayCastHit, Mathf.Infinity))
		{
			var door : Door = rayCastHit.transform.GetComponent(typeof(Door));
			if(door)
			{
				door.PlayDoorAnim();
			}
		}
	}
}