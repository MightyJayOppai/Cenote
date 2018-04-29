using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public bool way;
    private float speed;
    Vector3 upPosition;
    Vector3 downPosition;

    private AudioSource aSource;

    void Start ()
    {
        aSource = GetComponent<AudioSource>();

        downPosition = this.transform.position;
        upPosition = downPosition + new Vector3(0f, 0.6f, 0f);
        speed = 2f;
    }
	
	void Update ()
    {
        if (way)
        {
            float step = speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, upPosition, step);
            aSource.Play();
        }
        else if (!way)
        {
            float step = speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, downPosition, step);
            aSource.Play();
        }

        if ((this.gameObject.transform.position == upPosition) || (this.gameObject.transform.position == downPosition))
        {
            aSource.Pause();
        }
    }
}