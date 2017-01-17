using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	private int m_LastIndex;
	
	public void PlayDoorAnim () 
	{
		if(!GetComponent<Animation>().isPlaying)
		{
			if(m_LastIndex == 0)
			{
				GetComponent<Animation>().Play("DoorOpen");
				m_LastIndex = 1;
			}
			else 
			{
				GetComponent<Animation>().Play("DoorClose");
				m_LastIndex = 0;
			}
		}
	}
}
