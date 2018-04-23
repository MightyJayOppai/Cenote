using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public bool way;
    private float speed;
    Vector3 upPosition;
    Vector3 downPosition;

    void Start ()
    {
        downPosition = this.transform.position;
        upPosition = downPosition + new Vector3(0f, 6.95f, 0f);
        speed = 5f;
    }
	
	void Update ()
    {
        if (way)
        {
            float step = speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, upPosition, step);

        }
        else if (!way)
        {
            float step = speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, downPosition, step);

        }
    }
}