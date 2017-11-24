using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nav_Instance : MonoBehaviour {

    [HideInInspector] public Transform tm;

  
    public void OnclickBtn_Nav()
    {

        Nav_Header Nav_Headercs = ObjectPoolManager.GetInstance().Nav_Headerpool.PopObject() as Nav_Header;
        //Debug.Log("Fuck");
   
    }
}
