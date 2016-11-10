using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WayPointScr : MonoBehaviour {
	public List<Transform> list;
	public int localNumberPoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider myTrigger)
	{
		if (myTrigger.gameObject.name == "Sphere")
		{
			myTrigger.gameObject.GetComponent<MoveTo>().newWayPoint(list);
		}
	}
}
