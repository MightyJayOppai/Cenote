using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour {

    Transform Player;
    public float CompanionSpeed = 3;
   
	void Start ()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	
	void Update ()
    {
        transform.LookAt(Player);
        AICompanion();
	}

    void AICompanion ()
    {
        transform.position += transform.forward * CompanionSpeed * Time.deltaTime;
    }
}
