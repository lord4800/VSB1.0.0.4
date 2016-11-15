using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BedTrigger : MonoBehaviour {
	public Image cooldown; 
	static float drinktimer = 5f;
	float _time;
	bool drink;
	//public Texture tex;
	void start()
	{
		drink = false;
	}
	void Update () 
	{
		if (drink == true)
		{
			//Reduce fill amount over 30 seconds
			cooldown.fillAmount -= 1.0f/drinktimer * Time.deltaTime;
		}
	}
	void OnTriggerStay(Collider myTrigger) {
		if (myTrigger.gameObject.name == "ThirdPersonController" && drink)
		{
			_time -= Time.deltaTime;
		}
		if(_time >= 0.1f) 
		{
			//drink = false;
			cooldown.fillAmount = 1f;
		}
	}
	void OnTriggerExit(Collider myTrigger)
	{
		if (myTrigger.gameObject.name == "ThirdPersonController")
		{
			Debug.Log ("drink blod");
			drink = false;
			drinktimer = 5f;
			cooldown.fillAmount = 1f;
		}
	} 
	void OnTriggerEnter(Collider myTrigger)
	{
		if (myTrigger.gameObject.name == "ThirdPersonController")
		{
			Debug.Log ("drink blood");
			drink = true;
		}
		//else drink = false;
	}
}
