using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveTo : MonoBehaviour {
	private Transform waypoints;
	private Transform waypoint;
	private int waypointIndex = -1;
	public Transform firstpoint;
	public Transform goal;
	private bool gethere = false;
	public bool isVisible;
	public int index;


	//public Transform[] WayPointList;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () 
	{
		
		waypoints = GameObject.Find("WayPoints").transform;
		//newWayPoint(firstpoint);
		moveTo(firstpoint);
		agent = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//moveTo(goal);
		if (isVisible) moveTo(goal);

	}
	void moveTo(Transform _goal)
	{
		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		Debug.Log(_goal.position.ToString());
		agent.destination = _goal.position;
	}
	public void newWayPoint(List<Transform> list)
	{
		waypointIndex = Random.Range(0, list.Count); //(0, WayPointList.GetLength);
		moveTo(list[waypointIndex]);

	}

}
