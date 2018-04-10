using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public enum Condition { READY, SUCCESS, RUNNING, FAIL};
    public Condition curCondition = Condition.READY;

    public List<Node> Children = new List<Node>();

    public virtual void Execute(CompanionBehaviorTree MainBT)
    {
        Debug.Log("State is Ready");
    }
}
