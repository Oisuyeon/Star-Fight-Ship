using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorllBackAct : MonoBehaviour
{

    float speed = 5.0f;  //속도 = 거리/시간; 거리 = 속도*시간
    float backWidth = 11.5f * 1.7f; //배경사진의폭
    float camWidth = 10.5f * 2.0f; //19.0f;  //카메라 폭
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float xoff = -speed * Time.deltaTime;
        transform.Translate(xoff,0.0f,0.0f);
        if (transform.position.x < -camWidth / 2.0f - backWidth / 2.0f) //화면에서 사라지면
        {
            transform.Translate(backWidth*2.0f, 0.0f, 0.0f); //현재 이미지 2개의 폭만큼 앞(오른쪽)

            
        }    
    }
}
