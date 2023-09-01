using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    private GameLogic gameLogic;
    private float deadZ = -6;

    void Start()
    {
        gameLogic = GameObject.FindWithTag("Logic").GetComponent<GameLogic>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * -1 * gameLogic.getItemSpeed() *Time.deltaTime);
        if (transform.position.z < deadZ)
        {
            Destroy(gameObject);
        }
    }
}
