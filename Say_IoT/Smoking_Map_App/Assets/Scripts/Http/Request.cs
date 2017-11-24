using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;

public class Request : MonoBehaviour {

    public string Url = "";//http://says.zeroday.me:7579/Mobius/pi_1/sensor
    public TextAsset jsonppmData;
    private float TimeLeft = 5.0f;
    private float nextTime = 0.0f;
    public int ras_1_ppm;
    private string ppmData;


    // Use this for initialization
    void Start()
    {
        // Url = "http://says.zeroday.me:7579/Mobius/pi_1/sensor";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + TimeLeft;
            GetData(Url);
           
        }

    }



    void PostData()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("m2m:ae", "mobius");
        string data = JsonFx.Json.JsonWriter.Serialize(dic);

        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Accept", "application/json");  
        headers.Add("X-M2M-RI", "12345");
        headers.Add("X-M2M-Origin", "0.2.481.1.21160310105204806");
        headers.Add("Content-Type", "application/vnd.onem2m-res+json; ty=4");
        headers.Add("Cache-Control", "no-cache");
        
        byte[] body = Encoding.UTF8.GetBytes(data);
        WWW www = new WWW(Url, body, headers);
        StartCoroutine("PostdataEnumerator", www);
    }

 
    
    public WWW GetData(string url)
    {
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Accept", "application/json");
        headers.Add("X-M2M-RI", "12345");
        headers.Add("X-M2M-Origin", "0.2.481.1.21160310105204806");
        headers.Add("Content-Type", "application/vnd.onem2m-res+json; ty=4");
        headers.Add("Cache-Control", "no-cache");
        Debug.Log("URL : " + Url);
        WWW www = new WWW(url, null, headers);
        StartCoroutine("dataEnumerator", www);
        return www;

    }
    IEnumerator dataEnumerator(WWW www)
    {
       
        yield return www;

        if (www.error == null)
        {

            Debug.Log("Data Submitted");
            Debug.Log("www Result: " + www.text);
            ProcessPlayer(www.text);

        }
        else
        {
            Debug.Log(www.error);
        }
    }

    void ProcessPlayer(string jsonString)
    {


         JsonData jsonPlayer = JsonMapper.ToObject(jsonString);
         ppmData = jsonPlayer["m2m:cin"]["con"].ToString();
        //Debug.Log(ppmData.Substring(0, 3));
        ras_1_ppm = int.Parse(ppmData.Substring(0,3));
        //getppm = Convert.ToInt32(ppmData);
         Debug.Log(ras_1_ppm);
        Save_Upgrade_PPM();
    }

    public void Save_Upgrade_PPM()
    {
        PlayerPrefs.SetInt("ras_1_ppm", this.ras_1_ppm);
    }

  

}


