using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{
    public bool doneFromSecondPuzzle;

	void Start ()
    {
        DontDestroyOnLoad(this.gameObject);
	}
}
