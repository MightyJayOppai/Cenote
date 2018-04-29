using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionBehaviorTree : MonoBehaviour {

    public Node root;
    public float CompanionSpeed;
    public Transform Player;

    public Collider CompSphere;
    public GameObject ObjImp;

    public Animator anim;

    public bool StopFollow;

	void Start ()
    {
        anim = GetComponent<Animator>();
        CompSphere = GetComponent<Collider>();

        Selector selectNode = new Selector();
        Selector sequencerNode = new Selector();

        
        root = selectNode;   
        selectNode.Children.Add(sequencerNode);
        selectNode.Children.Add(new AIDetectImp());

        selectNode.Children.Add(new AIFollow());
        


	}


	void Update ()
    {
        root.Execute(this);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            ObjImp = other.gameObject;
        }
    }
}
