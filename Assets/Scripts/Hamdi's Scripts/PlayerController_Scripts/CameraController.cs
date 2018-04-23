using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Vector2 mouselook;
    public Vector2 smoothV;
    public float sensetivity = 5.0f;
    public float smoothing = 2.0f;

    public GameObject character;

    public PauseMenu pauseMenu;


    void Start()
    {
        character = this.transform.parent.gameObject;

        GameObject ui = GameObject.FindGameObjectWithTag("UI");
        pauseMenu = ui.GetComponent<PauseMenu>();
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

        if (pauseMenu.paused == false)
        {
            mouseMovement = Vector2.Scale(mouseMovement, new Vector2(sensetivity * smoothing, sensetivity * smoothing));
            smoothV.x = Mathf.Lerp(smoothV.x, mouseMovement.x, 1f / smoothing);
            smoothV.y = Mathf.Lerp(smoothV.y, mouseMovement.y, 1f / smoothing);
            mouselook += smoothV;

            transform.localRotation = Quaternion.AngleAxis(-mouselook.y, Vector3.right);
            character.transform.localRotation = Quaternion.AngleAxis(mouselook.x, character.transform.up);
        }
    }
}
