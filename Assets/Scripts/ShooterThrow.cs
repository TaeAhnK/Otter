using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterThrow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shellReady; //총알 적재
    public GameObject shellPos; //총구
    float coolTime = 0.5f; //총알쿨타임
    float shellTimer = 0; //쿨타임 재는 타이머
    
    void Start()
    {
        GameObject Shell = Instantiate(shellReady); //총알준비
        Shell.transform.position = shellPos.transform.position; //총알발사
    }

    // Update is called once per frame
    void Update()
    {
        shellTimer += Time.deltaTime;
        if (shellTimer >= coolTime) // 쿨타임 지나면 발사
        {
            GameObject Shell = Instantiate(shellReady); //총알준비
            Shell.transform.position = shellPos.transform.position; //총알발사
            shellTimer = 0; //타이머 초기화
        }
        
    }
}
