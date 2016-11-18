using UnityEngine;
using System.Collections;

public class LightScr : MonoBehaviour {
	public bool IsDay;
	private GameObject[] citizens;
	private GameObject[] lights;
	private GameObject light;
	// Use this for initialization
	void Awake()
	{
		setDay();
	}
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.O))
		{
			setDay();
		}
		if(Input.GetKeyDown(KeyCode.P))
		{
			setNight();
		}
	}
	void setDay()
	{
		IsDay = true;
		//GameObject.FindGameObjectsWithTag("");
		lights = GameObject.FindGameObjectsWithTag("Light");
		for(int i = 0; i < lights.Length; i++)
		{
			if (lights[i].name == "Spot")
			{
				lights[i].GetComponent<Light>().enabled = false;
			}
			if (lights[i].name == "Directional light")
			{
				lights[i].GetComponent<Light>().enabled = true;
			}
		}
	}
	void setNight()
	{
		IsDay = false;
		lights = GameObject.FindGameObjectsWithTag("Light");
		for(int i = 0; i < lights.Length; i++)
		{
			if (lights[i].name == "Spot")
			{
				lights[i].GetComponent<Light>().enabled = true;
			}
			if (lights[i].name == "Directional light")
			{
				lights[i].GetComponent<Light>().enabled = false;
			}
		}
	}
}
