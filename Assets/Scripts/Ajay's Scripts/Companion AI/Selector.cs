using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Node {

    public override void Execute(CompanionBehaviorTree MainBT)
    {
        for (int i = 0; i < Children.Count; i++)
        {
            
            Children[i].Execute(MainBT);
            //The Condition for the children will be checked

            //If Node is Success
            if (Children[i].curCondition == Condition.SUCCESS)
            {
                curCondition = Condition.SUCCESS;
                return;
            }

            //If Node is Running
            if (Children[i].curCondition == Condition.RUNNING)
            {
                curCondition = Condition.SUCCESS;
                return;
            }
        }

        //When Node is Fail
        curCondition = Condition.FAIL;
        return;

    }
	
}
