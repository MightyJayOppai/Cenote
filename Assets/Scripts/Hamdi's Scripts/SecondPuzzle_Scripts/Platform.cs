using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public List<Bridge> bridges = new List<Bridge>();

    public GolemBehaviorTree golem;

    public Gate GateToRoomThree;

    private void Start()
    {
        GameObject golemModel = GameObject.FindGameObjectWithTag("Golem");
        golem = golemModel.GetComponent<GolemBehaviorTree>();

        GameObject gateModel = GameObject.FindGameObjectWithTag("Gate");
        GateToRoomThree = gateModel.GetComponent<Gate>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.name == "PlatformG" && collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < bridges.Count; i++)
            {
                bridges[i].way = false;
            }

            golem.controlledByPlayer = false;
            GateToRoomThree.gateShouldMove = true;
            this.gameObject.SetActive(false);
        }

        else if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Golem"))
        {
            for (int i = 0; i < bridges.Count; i++)
            {
                bridges[i].way = true;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && this.gameObject.name == "PlatformE")//for bridge 4 bug
        {
            for (int i = 0; i < bridges.Count; i++)
            {
                bridges[i].way = true;
            }
        }
    }

    /*void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && (this.gameObject.name == "PlatformE" || this.gameObject.name == "PlatformD"))
        {
            for (int i = 0; i < bridges.Count; i++)
            {
                bridges[i].way = false;
            }
        }
    }*/
}
