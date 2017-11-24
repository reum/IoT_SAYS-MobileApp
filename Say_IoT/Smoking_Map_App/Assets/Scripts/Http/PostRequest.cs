using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using JsonFx.Json;

public class PostRequest : MonoBehaviour {

    public string Url = "";//http://says.zeroday.me:7579/Mobius/pi_1/sensor
    private float TimeLeft = 5.0f;
    private float nextTime = 0.0f;
    // public Dictionary<int, sEnemy> mDicEnemy = new Dictionary<int, sEnemy>();
    
    // Use this for initialization
    void Start()
    {
        // Url = "http://says.zeroday.me:7579/Mobius/pi_1/sensor";
        //  PostData();
       // string test = GetDataFromSErver(Url);
       // Debug.Log(test);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            //PostData();
            string test = GetDataFromSErver(Url);
            Debug.Log(test);
        }

        
     
    }



    void PostData()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("m2m:ae", "mobius");
        string data = JsonFx.Json.JsonWriter.Serialize(dic);
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Accept", "application/json");
        //headers.Add("locale", "ko");
        headers.Add("X-M2M-RI", "12345");
        headers.Add("X-M2M-Origin", "0.2.481.1.21160310105204806");
        headers.Add("Content-Type", "application/vnd.onem2m-res+json; ty=4");
        headers.Add("Cache-Control", "no-cache");
        /*
        headers.Add("Accept", "application/vnd.onem2m-prsp+xml");
        headers.Add("X-M2M-RI", "12345");
        headers.Add("X-M2M-Origin", "S0.2.481.1.1.232466"); */
        byte[] body = Encoding.UTF8.GetBytes(data);
        WWW www = new WWW(Url, body, headers);
        StartCoroutine("PostdataEnumerator", www);
    }


    string GetDataFromSErver(string url_)
    {

      
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Accept", "application/json");
        headers.Add("X-M2M-RI", "12345");
        headers.Add("X-M2M-Origin", "0.2.481.1.21160310105204806");
        headers.Add("Content-Type", "application/vnd.onem2m-res+json; ty=4");
        headers.Add("Cache-Control", "no-cache");
        Debug.Log("URL : " + url_);
        WWW www = new WWW(url_, null, headers);
        StartCoroutine("dataEnumerator", www);
        return www.text;

    }
    IEnumerator dataEnumerator(WWW www)
    {
        ///Debug.Log("----- www Result: " + www.text);


        yield return www;

        if (www.isDone)
        {

            Debug.Log("Data Submitted");
            Debug.Log("www Result: " + www.text);
         

        }
        else
        {
            Debug.Log(www.error);
        }
    }

   

}
