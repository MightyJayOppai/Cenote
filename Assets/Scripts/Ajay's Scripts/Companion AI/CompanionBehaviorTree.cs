using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionBehaviorTree : MonoBehaviour {

    public Node root;
    public float CompanionSpeed;
    public Transform Player;

    public float CompanionFollowDistance;
    public float DistanceToPlayer;
    public float Angle;
    public Vector3 TargetDir;

	void Start ()
    {
        Selector selectNode = new Selector();
        Sequencer sequencerNode = new Sequencer();

        root = selectNode;
        selectNode.Children.Add(sequencerNode);
        //!!!!Recheck this line!!!!
        //selectNode.Children.Add(new AIFollow());
	}
	
	
	void Update ()
    {
        root.Execute(this);
	}
}
