using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_Scene_Mgr : MonoBehaviour {

    public void OnclickBtn_Go_Py_1()
    {
        SceneManager.LoadScene("Py_1");
    }

    public void OnclickBtn_Go_Main()
    {
        SceneManager.LoadScene("Main");
    }
}
