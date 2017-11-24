using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Mgr : MonoBehaviour
{


    private static Data_Mgr singleton;
    public static Data_Mgr instance;   //변수 선언부 다른 스크립트에서 참조 가능하게 만든다// 

    public int ras_1_ppm;




    // Use this for initialization
    void Awake()
    {


        //about get data
        //Save_Upgrade_PPM();
        Get_Upgrade_PPM();





        if (singleton != null && singleton != this)
        {
            Destroy(gameObject);
        }
        else
        {
            singleton = this;
            // DontDestroyOnLoad(this);

        }

        Data_Mgr.instance = this;  //변수 초기화부  다른 스크립트에서 이 스크립트 함수를 사용 가능하게 만든다// 




    }

    // Update is called once per frame
    void Update()
    {

       // Save_Upgrade_PPM();
        Get_Upgrade_PPM();



    }



    public void Save_Upgrade_PPM()
    {
        PlayerPrefs.SetInt("ras_1_ppm", this.ras_1_ppm);
    }

    public void Get_Upgrade_PPM()
    {
        ras_1_ppm = PlayerPrefs.GetInt("ras_1_ppm");
    }

}
