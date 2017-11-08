using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section_Instance : MonoBehaviour {

    [HideInInspector] public Transform tm;

    public int ras_1_ppm;
    private bool CheckThis;

    // Use this for initialization
    void Awkae () {
        Get_Upgrade_PPM();
        CheckThis = false;

    }

    void Start()
    {
        checkInsance();
    }
	
	// Update is called once per frame
	void Update () {

        Get_Upgrade_PPM();
       
            checkInsance();


    }

    void checkInsance()
    {
        if(CheckThis == false)
        {
            Section_12_W Section_12_Wcs = ObjectPoolManager.GetInstance().Section_12_pool.PopObject() as Section_12_W;
            CheckThis = true;
        }
       
    }

    public void Get_Upgrade_PPM()
    {

        ras_1_ppm = PlayerPrefs.GetInt("ras_1_ppm");
    }
}
