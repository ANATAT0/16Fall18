﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIAgent : MonoBehaviour 
{
    private NavMeshAgent agent;

	public Transform destination;
    
    
	void Start ()
	{
	    agent = GetComponent<NavMeshAgent>();
	}
	
	
	void Update ()
	{
		agent.destination = destination.position;
	}
}
