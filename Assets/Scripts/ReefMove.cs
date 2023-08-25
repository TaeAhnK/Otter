using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReefMove : MonoBehaviour
{
    private GameLogic logic;
    public float deadZone = -10;
    private float rspeed;
    private float mspeed;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }


    void Update()
    {

        mspeed = logic.SpeedControl();
        
        transform.position = transform.position + (Vector3.back * mspeed) * Time.deltaTime;
        
        //파이프가 일정 구간 넘어가면(deadZone) 암초를 없앰
        if (transform.position.z<deadZone)
        {
            Destroy(gameObject);
        }
    }
}
