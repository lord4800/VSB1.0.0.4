﻿using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {
	public Transform goal;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		agent.destination = goal.position;
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = goal.position;
	}
}
