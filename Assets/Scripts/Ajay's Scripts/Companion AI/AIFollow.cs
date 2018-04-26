using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : Node
{
    Transform Player;
    public float CompanionSpeed = 5;
    public CompanionBehaviorTree companion;
    public Animator compnionAnim;
    
    public override void Execute(CompanionBehaviorTree MainBT)
    {
        GameObject companionModel = GameObject.FindGameObjectWithTag("Companion");
        companion = companionModel.GetComponent<CompanionBehaviorTree>();

        compnionAnim = companion.anim;

        Player = MainBT.Player;
        curCondition = Condition.RUNNING;
        //The LookAt Function is currently running
        MainBT.transform.LookAt(Player);
        MainBT.transform.position += MainBT.transform.forward * CompanionSpeed * Time.deltaTime;

        if (Vector3.Distance(Player.position, MainBT.transform.position) < 1)
        {
            compnionAnim.SetTrigger("Idle");
            curCondition = Condition.FAIL;
            CompanionSpeed = 0;
        }
        else
        {
            compnionAnim.SetTrigger("Walk");
            curCondition = Condition.SUCCESS;
            CompanionSpeed = 5;
        }
    }

  

}