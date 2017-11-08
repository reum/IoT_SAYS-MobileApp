using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Mgr : MonoBehaviour {

    private float Start_Time; // 시작시간 설정
    private float Time_span;  //경과 시간을 갖는 변수

    // Use this for initialization
    void Awake()
    {

        Time_span = 0.0f; //경과시간 초기화
        Start_Time = 1.5f; //시작시간 고정
    }

    // Update is called once per frame
    void Update()
    {

        Time_span += Time.deltaTime; //경과시간


        if (Time_span > Start_Time)  // 경과 시간이 특정 시간이 보다 커졋을 경우
        {

            Time_span = 0.0f;
            Start_Scene();
        }

    }

    private void Start_Scene()
    {
        SceneManager.LoadScene("Main");
    }
}
