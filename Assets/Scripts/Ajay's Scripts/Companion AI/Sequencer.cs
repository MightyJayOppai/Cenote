using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencer : Node {

    public override void Execute(CompanionBehaviorTree MainBT)
    {
        for (int i = 0; i< Children.Count; i++)
        {
            Children[i].Execute(MainBT);


            //If Node is Fail
            if (Children[i].curCondition == Condition.FAIL)
            {
                curCondition = Condition.FAIL;
                return;
            }

            //If Node is Running
            if (Children[i].curCondition == Condition.RUNNING)
            {
                curCondition = Condition.RUNNING;
                return;
            }
        }

        //If Node is Success
        curCondition = Condition.SUCCESS;
        return;
    }
}
