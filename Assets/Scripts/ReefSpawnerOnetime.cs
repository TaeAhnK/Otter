using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReefSpawner : MonoBehaviour
{
    
    public GameObject Reef; 
    public float SpawnRate=2;
    //동시다발 시 암초가 나오는 주기 
    private float RealTime = 0;
    //실제 시간
    private float timer = 0;
    //암초 나오는 주기를 확인하기 위한 타이머
    private int count = 0;
    //동시다발적으로 나올 때의 암초 개수
    private bool flag = false;
    private bool flag2 = false;

    private Transform target; // 암초가 가리킬 대상 //해달

    //암초 위치 배열
    int[] numbers = new int[5] { -3, -1, 0, 1, 3 };
    
    
    void Update()
    {
        RealTime+=Time.deltaTime;
        timer+=Time.deltaTime;

        if(flag == true && RealTime>10)
        //실제 시간이 10초가 됐을 때 동시다발적
        {
            
            if( flag2== false && timer>SpawnRate)
            //SpawnRate마다 암초가 나오도록
            {
                Debug.Log("동시다발");
                SpawnReef();
                count++;
                Debug.Log("더하기");
                timer = 0;
                
                if(count>5)
                //나온 암초가 5개가 돼었을 때
                {
                    count =0;
                    //암초개수 초기화
                    RealTime = 0;
                    //실제시간 초기화
                    flag = false;
                    flag2=true;
                }
                flag2=false;
            }
            
        }

        if(flag == false && RealTime>5)
        //실제 시간이 5초가 됐을 때
        {
            SpawnReef();
            flag = true;
            //flag를 true로 변경시켜 맨 위의 if문으로 이동
            RealTime+=Time.deltaTime;
            Debug.Log("한 번");
            
        }
    }

    

    void SpawnReef()
    {   
        // 배열에서 랜덤한 인덱스를 생성
        int randomIndex = Random.Range(0, 5);
        // 랜덤한 인덱스에 해당하는 배열 요소 출력
        int randomNumber = numbers[randomIndex];
        //배열 중 랜덤 위치에 생성
        Instantiate(Reef, new Vector3(randomNumber, 1, 14), transform.rotation);
    }

    

}
