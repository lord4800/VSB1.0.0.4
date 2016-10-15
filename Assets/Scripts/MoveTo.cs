using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {
	public Transform goal;
	public bool isVisible;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		moveTo(isVisible);
	}
	
	// Update is called once per frame
	void Update () {
		moveTo(isVisible);
	}
	void moveTo(bool Visible)
	{
		if (Visible) agent.destination = goal.position;
	}
}
