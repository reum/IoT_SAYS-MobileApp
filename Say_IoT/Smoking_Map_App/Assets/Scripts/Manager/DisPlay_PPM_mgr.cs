using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisPlay_PPM_mgr : MonoBehaviour {

    public int ras_1_ppm;
    public Text TextPPM = null;

    // Use this for initialization
    void Awake () {

        Get_Upgrade_PPM();


    }
	
	// Update is called once per frame
	void Update () {
        Get_Upgrade_PPM();
        Dispaly();
    }

    void Dispaly()
    {

        TextPPM.text = "광개토관 Co 농도 : " + ras_1_ppm + "ppm";
    }

    public void Get_Upgrade_PPM()
    {
        ras_1_ppm = PlayerPrefs.GetInt("ras_1_ppm");
    }
}
