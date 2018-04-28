using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : Node
{
    Transform Player;
    public float CompanionSpeed = 5;
    public CompanionBehaviorTree companion;
    public Animator companionAnim;
    
    public override void Execute(CompanionBehaviorTree MainBT)
    {
        GameObject companionModel = GameObject.FindGameObjectWithTag("Companion");
        companion = companionModel.GetComponent<CompanionBehaviorTree>();

        companionAnim = companion.anim;

        Player = MainBT.Player;
        curCondition = Condition.RUNNING;
        //The LookAt Function is currently running
        MainBT.transform.LookAt(Player);
        MainBT.transform.position += MainBT.transform.forward * CompanionSpeed * Time.deltaTime;

        if (Vector3.Distance(Player.position, MainBT.transform.position) < 1.5)
        {
            companionAnim.SetTrigger("Idle");
            curCondition = Condition.SUCCESS;
            CompanionSpeed = 0;
            //Companion has reached the player
        }
        else
        {
            companionAnim.SetTrigger("Walk");
            curCondition = Condition.FAIL;
            CompanionSpeed = 5;
            //Companion is far and needs to walk to the player
        }
    }

  

}