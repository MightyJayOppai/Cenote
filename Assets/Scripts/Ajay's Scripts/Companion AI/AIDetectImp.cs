using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDetectImp : MonoBehaviour
{
    public float speed;
    public LayerMask layer;

    void Start()
    {
        
    }

    void Update()
    {
        //For every object with the specified layer that collides with the AI sphere range
        Collider[] Hits = Physics.OverlapSphere(transform.position, 10 , layer);
        //if there is at least one object with the layer in the range
        if (Hits.Length > 0)
        {
            float Step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Hits[0].transform.position, Step);
        }
               
        //foreach (Collider hit in Hits)
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(this.transform.position, 10f);
    }
}
