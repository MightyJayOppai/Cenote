using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDetectImp : Node
{
    public float speed;
    public LayerMask layer;
    public CompanionBehaviorTree companion;
    public float IntendedDis;

    public override void Execute(CompanionBehaviorTree MainBT)
    {
        GameObject comp = GameObject.FindGameObjectWithTag("Companion");
        GameObject companionModel = GameObject.FindGameObjectWithTag("Companion");
        companion = companionModel.GetComponent<CompanionBehaviorTree>();

        IntendedDis = 1;


        
        
        //if there is at least one object with the layer in the range
        if (companion.ObjImp != null)
        {
            curCondition = Condition.RUNNING;
            Debug.Log("RUNNING");
            companion.StopFollow = true;
            float Step = speed * Time.deltaTime;
            comp.transform.position = Vector3.MoveTowards(comp.transform.position, companion.ObjImp.transform.position, Step);

        }
        if (companion.ObjImp != null)
        {
            if (Vector3.Distance(comp.transform.position, companion.ObjImp.transform.position) <= IntendedDis)
            {
                curCondition = Condition.SUCCESS;
                companion.StopFollow = false;
                Debug.Log("SUCCESS");
            }
        }

        if(companion.ObjImp = null)
        {
            curCondition = Condition.FAIL;
            companion.StopFollow = false;
            Debug.Log("FAIL");

        }

    }
}
