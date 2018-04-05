using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : Node
{
    Transform Player;
    public float CompanionSpeed = 5;

    public override void Execute(CompanionBehaviorTree MainBT)
    {
        Player = MainBT.Player;
        curCondition = Condition.RUNNING;
        //The LookAt Function is currently running
        MainBT.transform.LookAt(Player);
        MainBT.transform.position += MainBT.transform.forward * CompanionSpeed * Time.deltaTime;

        if (Vector3.Distance(Player.position, MainBT.transform.position) < 2)
        {
            curCondition = Condition.FAIL;
            CompanionSpeed = 0;
        }
        else
        {
            curCondition = Condition.SUCCESS;
            CompanionSpeed = 5;
        }
    }

  

}