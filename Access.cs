using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Access : MonoBehaviour
{
    Data data = new Data();
    //Data class'�ma eri�iyorum.
    void Start()
    {
        data.name = "samet";
        data.sname = "batmansdsadsa";
        data.age = 21;
        //Data.cs'deki verilere atama yap�yorum.
    }

    public void Register()
    {
        string json = JsonUtility.ToJson(data);
        print(json);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/json2.json", json);
        //Verilerin .json dosyas�na kaydedilme i�lemleri.
        print(Application.persistentDataPath);
        //.json dosyas�n�n konumunu yazd�r�yorum.

    }
    public void Read()
    {
        string json= System.IO.File.ReadAllText(Application.persistentDataPath + "/json2.json");
        print("okundu" + json);
        //Verilerin .json dosyas�ndan okunma i�lemleri
    }
}
