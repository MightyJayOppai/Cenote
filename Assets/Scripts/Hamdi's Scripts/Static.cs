using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{
    //Hamdi
    public bool doneFromSecondPuzzle;
    //Ajay
    public bool doneFromThirdPuzzle;

	void Start ()
    {
        DontDestroyOnLoad(this.gameObject);
	}
}
