using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour {

    Transform Player;
    public float CompanionSpeed = 5;

    void Awake()
    {
     
    }

    void Start ()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	
	void Update ()
    {
        //to make the AI look at the player
        transform.LookAt(Player);
        AICompanion();
        StopBehindPlayer();
	}

    void AICompanion ()
    {
        transform.position += transform.forward * CompanionSpeed * Time.deltaTime;
    }

    void StopBehindPlayer()
    {
        if (Vector3.Distance(Player.transform.position, this.transform.position) < 2)
        {
            CompanionSpeed = 0;
        }
        else
        {
            CompanionSpeed = 5;
        }
    }
}
