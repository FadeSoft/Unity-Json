using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Access : MonoBehaviour
{
    Data data = new Data();
    //Data class'ýma eriþiyorum.
    void Start()
    {
        data.name = "samet";
        data.sname = "batmansdsadsa";
        data.age = 21;
        //Data.cs'deki verilere atama yapýyorum.
    }

    public void Register()
    {
        string json = JsonUtility.ToJson(data);
        print(json);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/json2.json", json);
        //Verilerin .json dosyasýna kaydedilme iþlemleri.
        print(Application.persistentDataPath);
        //.json dosyasýnýn konumunu yazdýrýyorum.

    }
    public void Read()
    {
        string json= System.IO.File.ReadAllText(Application.persistentDataPath + "/json2.json");
        print("okundu" + json);
        //Verilerin .json dosyasýndan okunma iþlemleri
    }
}
