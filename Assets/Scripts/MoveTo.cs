using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {
	private Transform waypoints;
	private Transform waypoint;
	private int waypointIndex = -1;
	public Transform goal;
	public bool gethere = false;
	public bool isVisible;
	public int index;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () 
	{
		
		waypoints =GameObject.Find("WayPoints").transform;
		NextWaypoint();
		agent = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (isVisible) moveTo(goal);
		else
		{
			if(!gethere) moveTo(waypoint);
			else 
			{
				gethere = false;
				NextWaypoint();
			}

		}
	}
	void moveTo(Transform _goal)
	{
		agent.destination = _goal.position;
	}
	void NextWaypoint()
	{
		waypointIndex++;
		if (waypointIndex == 4)
		{
			waypointIndex = 0;			
		}
		waypoint = waypoints.GetChild(waypointIndex);
	}

}
