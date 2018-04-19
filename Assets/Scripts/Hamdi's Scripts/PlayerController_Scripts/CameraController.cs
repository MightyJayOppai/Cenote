using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    Vector2 mouselook;
    Vector2 smoothV;
    public float sensetivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject character;


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
