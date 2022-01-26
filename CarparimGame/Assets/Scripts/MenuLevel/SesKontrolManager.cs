using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrolManager : MonoBehaviour
{
    private void Start(){
        sesiAc();
    }
    public void sesiAc(){
        PlayerPrefs.SetInt("sesDurumu",1);
    }

    public void sesiKapat(){
        PlayerPrefs.SetInt("sesDurumu",0);
    }
}
