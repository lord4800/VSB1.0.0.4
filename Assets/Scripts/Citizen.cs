using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Citizen : MonoBehaviour {
	private Transform waypoints;

	private int waypointIndex;
	public Transform firstpoint;
	Transform goal;



	NavMeshAgent agent;
	// Use this for initialization
	void Start () 
	{

		waypoints = GameObject.Find("WayPointsCitizen").transform;
		moveTo(firstpoint);
		agent = GetComponent<NavMeshAgent>();

	}
		
	void moveTo(Transform _goal)
	{
		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		agent.destination = _goal.position;
	}
	public void newWayPoint(List<Transform> list)
	{
		waypointIndex = Random.Range(0, list.Count); 
		moveTo(list[waypointIndex]);

	}
}
