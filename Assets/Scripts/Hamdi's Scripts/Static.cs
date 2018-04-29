using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{
    //Hamdi
    public bool doneFromSecondPuzzle;
    //Ajay
    public bool doneFromThirdPuzzle;
    //End game
    public bool controlsDisabled;
    public bool disablePlayerRigidBody;

    void Start ()
    {
        DontDestroyOnLoad(this.gameObject);
	}
}
