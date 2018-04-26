using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDetectImp : Node
{
    public float speed;
    public LayerMask layer;

    public override void Execute(CompanionBehaviorTree MainBT)
    {
        GameObject comp = GameObject.FindGameObjectWithTag("Companion");

        //For every object with the specified layer that collides with the AI sphere range
        Collider[] Hits = Physics.OverlapSphere(comp.transform.position, 1 , layer);
        //if there is at least one object with the layer in the range
        if (Hits.Length > 0)
        {
            float Step = speed * Time.deltaTime;
            comp.transform.position = Vector3.MoveTowards(comp.transform.position, Hits[0].transform.position, Step);
        }
               
        Gizmos.DrawWireSphere(comp.transform.position, 1f);
    }
}
