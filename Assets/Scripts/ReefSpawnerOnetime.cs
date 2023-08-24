using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReefSpawner : MonoBehaviour
{
    public GameObject Reef;
    //암초 위치 배열
    int[] numbers = new int[5] { -3, -1, 0, 1, 3 };




    public void SpawnReef()
    {
        // 배열에서 랜덤한 인덱스를 생성
        int randomIndex = Random.Range(0, 5);
        // 랜덤한 인덱스에 해당하는 배열 요소 출력
        int randomNumber = numbers[randomIndex];
        //배열 중 랜덤 위치에 생성
        Instantiate(Reef, new Vector3(randomNumber, 1, 14), transform.rotation);
    }



}
