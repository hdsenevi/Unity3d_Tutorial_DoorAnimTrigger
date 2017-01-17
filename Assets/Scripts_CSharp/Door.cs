using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	private int m_LastIndex;
	
	public void PlayDoorAnim () 
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
}
