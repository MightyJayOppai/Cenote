using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionBehaviorTree : MonoBehaviour {

    public Node root;
    public float CompanionSpeed;
    public Transform Player;

    public float CompanionFollowDistance;
    public float DistanceToPlayer;

    public Animator anim;

	void Start ()
    {
        anim = GetComponent<Animator>();

        Selector selectNode = new Selector();
        Sequencer sequencerNode = new Sequencer();

        
      //root = selectNode;
        root = new AIFollow();
        selectNode.Children.Add(sequencerNode);
        selectNode.Children.Add(new AIDetectImp());

        selectNode.Children.Add(new AIFollow());
        //selectNode.Children.Add(new AIDetectImp());


	}
	
	
	void Update ()
    {
        root.Execute(this);
	}
}
