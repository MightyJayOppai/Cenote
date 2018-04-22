using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public List<Bridge> bridges = new List<Bridge>();


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < bridges.Count; i++)
            {
                bridges[i].way = false;
            }
        }
    }
}
