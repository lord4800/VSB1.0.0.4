using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {
	private Transform waypoints;
	private Transform waypoint;
	private int waypointIndex = -1;
	public Transform goal;
	private bool gethere = false;
	public bool isVisible;
	public int index;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () 
	{
		
		waypoints =GameObject.Find("WayPoints").transform;
		newWayPoint(-1);
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
	public void newWayPoint(int nextPoint)
	{
		nextPoint++;
		if (nextPoint == 4)
		{
			waypointIndex = 0;			
		}
		else 
		{
			waypointIndex = nextPoint;
		}
		waypoint = waypoints.GetChild(waypointIndex);
		Debug.Log("all going good");
		moveTo(waypoint);
	}

}
