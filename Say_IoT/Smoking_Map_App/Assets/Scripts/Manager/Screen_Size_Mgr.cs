using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Size_Mgr : MonoBehaviour {

    private static Screen_Size_Mgr singleton;
    public static Screen_Size_Mgr instance;   //싱글톤 패턴


    void Awake()
    {
        if (singleton != null && singleton != this)
        {
            Destroy(gameObject);
        }
        else
        {
            singleton = this;
            DontDestroyOnLoad(this);

        }

        Screen_Size_Mgr.instance = this;  //변수 초기화부  다른 스크립트에서 이 스크립트 함수를 사용 가능하게 만든다// 



    }



    // Use this for initialization
    void Start()
    {


        //스크린사이즈
        Screen.SetResolution(Screen.width, (Screen.width * 16) / 9, true);
        //자동 화면 잠금 방지
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        ApplicationChrome.statusBarState = ApplicationChrome.States.Visible;



    }
}
