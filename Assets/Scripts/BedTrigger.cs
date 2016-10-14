using UnityEngine;
using System.Collections;

public class BedTrigger : MonoBehaviour {
	bool drink;
	public Texture tex;
	void start()
	{
		drink = false;
	}

	void OnTriggerEnter(Collider myTrigger)
	{
		if (myTrigger.gameObject.name == "ThirdPersonController")
		{
			Debug.LogError ("drink blod");
			drink = true;
		}
		else drink = false;
	}

	void OnGUI()
	{
		if (drink == true) GUI.DrawTexture (new Rect(100,100,100,100), tex);

			
	}
}
