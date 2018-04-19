using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGolemControl : MonoBehaviour {

    public GolemBehaviorTree golem;

	void Start ()
    {
        GameObject golemModel = GameObject.FindGameObjectWithTag("Golem");
        golem = golemModel.GetComponent<GolemBehaviorTree>();
	}
	
	
	void Update ()
    {
		
	}
}
