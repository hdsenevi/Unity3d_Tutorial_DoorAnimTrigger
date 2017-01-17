#pragma strict

private var m_LastIndex:int;
	
function PlayDoorAnim () 
{
	if(!animation.isPlaying)
	{
		if(m_LastIndex == 0)
		{
			animation.Play("DoorOpen");
			m_LastIndex = 1;
		}
		else 
		{
			animation.Play("DoorClose");
			m_LastIndex = 0;
		}
	}
}