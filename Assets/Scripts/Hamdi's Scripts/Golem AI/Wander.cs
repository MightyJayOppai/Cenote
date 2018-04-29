using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    public GameObject golem;
    public float speed;
    public float AngleShift;

    Vector3 target;

    public float circleDistance;

    public float circleRadius;

    float wanderAngle;

    public Rigidbody rB;

    public Animator anim;

    private void Start()
    {
        golem = this.gameObject;

        wanderAngle = 3;
        circleRadius = 2;
        circleDistance = 2;
        AngleShift = 30;
        speed = 1;

        target = this.transform.position;

        rB = GetComponent<Rigidbody>();

        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        anim.SetTrigger("Walk");

        this.transform.rotation = Quaternion.LookRotation(rB.velocity, Vector3.up);

        Vector3 circleOffset = rB.velocity.normalized;

        circleOffset = circleOffset * circleDistance;

        wanderAngle += Random.Range(-AngleShift, AngleShift);

        Vector3 displacment = new Vector3(0, 0, -1);
        displacment = displacment * circleRadius;
        displacment = Quaternion.Euler(0, wanderAngle, 0) * displacment;

        Vector3 wanderForce = circleOffset + displacment;

        rB.AddForce(wanderForce * 5f);//add float
        rB.velocity = Vector3.ClampMagnitude(rB.velocity, speed);
    }
}
