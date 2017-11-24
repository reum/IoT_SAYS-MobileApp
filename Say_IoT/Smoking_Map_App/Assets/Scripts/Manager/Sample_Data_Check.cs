using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Data_Check : MonoBehaviour {

    public int ras_1_ppm;

    // Use this for initialization
    void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Save_Upgrade_PPM();


    }

    public void OnclickBtn_PPM_Sample()
    {
        ras_1_ppm = 100;
        Save_Upgrade_PPM();


    }

    public void OnclickBtn_PPM_Sample2()
    {
        ras_1_ppm = 50;
        Save_Upgrade_PPM();


    }
    public void OnclickBtn_PPM_Sample3()
    {
        ras_1_ppm = 10;
        Save_Upgrade_PPM();


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
