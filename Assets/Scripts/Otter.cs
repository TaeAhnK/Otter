using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otter : MonoBehaviour
{
    public GameObject gameLogic;

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

    private void OnTriggerEnter(Collider collide)
    {
        // Collision with Enemy
        if (collide.gameObject.CompareTag("Enemy"))
        {
            gameLogic.GetComponent<GameLogic>().addOtterLife(-1);
            Debug.Log("Otter Hit Enemy: " + gameLogic.GetComponent<GameLogic>().getOtterLife());
        }

        // Collision with Reef
        if (collide.gameObject.CompareTag("Reef"))


        {
            gameLogic.GetComponent<GameLogic>().addOtterLife(-1);
            Debug.Log("Otter Hit Reef: " + gameLogic.GetComponent<GameLogic>().getOtterLife());
        }

        // Collision with Item
        // if (collide.gameObject.CompareTag("Item"))
        // {
        //     Debug.Log("Otter Hit Item");
        // }
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

    // When Dies
    public void OtterDeath()
    {
        Debug.Log("Otter Death");
    }
}
