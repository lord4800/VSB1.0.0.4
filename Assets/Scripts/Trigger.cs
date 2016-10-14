using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour 
{
	
	void OnTriggerEnter(Collider myTrigger)
	{
		if (myTrigger.gameObject.name == "ThirdPersonController")
		{
			myTrigger.gameObject.transform.position = new Vector3(3f,0.04f,5.8f);
			Debug.LogError ("hit");
		}
	}
		
}
