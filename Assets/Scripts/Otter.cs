using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otter : MonoBehaviour
{
    private float deadX = 7f;
    void Awake()
    {

    }

    void Start()
    {
        
    }

    void Update()
    {
        DragMovement();
    }

    // Drag Movement
    private void DragMovement()
    {
        if (Input.touchCount > 0)
        {
            //Debug.Log(0.01f * Input.GetTouch(0).position.x);
            transform.position = new Vector3((Input.GetTouch(0).position.x - Screen.width / 2) * (deadX / Screen.width), 0, 0);
        }
    }
}
