using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Vector2 mouselook;
    private Vector2 smoothV;
    private float sensetivity = 5.0f;
    private float smoothing = 2.0f;

    private GameObject character;


    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    void Update()
    {
        var mouseMovement = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        if (mouselook.y >= 50)
        {
            mouselook.y = 50;
        }

        if (mouselook.y <= -50)
        {
            mouselook.y = -50;
        }
        
        mouseMovement = Vector2.Scale(mouseMovement, new Vector2(sensetivity * smoothing, sensetivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, mouseMovement.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, mouseMovement.y, 1f / smoothing);
        mouselook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouselook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouselook.x, character.transform.up);
    }
}
