#pragma strict

private var m_LastIndex:int;
	
function PlayDoorAnim () 
{
	if(!GetComponent.<Animation>().isPlaying)
	{
		if(m_LastIndex == 0)
		{
			GetComponent.<Animation>().Play("DoorOpen");
			m_LastIndex = 1;
		}
		else 
		{
			GetComponent.<Animation>().Play("DoorClose");
			m_LastIndex = 0;
		}
	}
}