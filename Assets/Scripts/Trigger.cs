using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour 
{
	public Vector3 teleportPosition;
	void OnTriggerEnter(Collider myTrigger)
	{
		if (myTrigger.gameObject.name == "ThirdPersonController")
		{
			//myTrigger.gameObject.transform.position = new Vector3(3f,0.04f,5.8f);
			myTrigger.gameObject.transform.position = teleportPosition;
			Debug.LogError ("hit");
		}
	}
		
}
