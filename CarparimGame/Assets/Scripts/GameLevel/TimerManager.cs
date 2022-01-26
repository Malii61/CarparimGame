using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerManager : MonoBehaviour
{
    [SerializeField]
    private Text SureText;

    [SerializeField]
    private GameObject sonucPaneli;

    [SerializeField]
    private GameObject sonuclarObje,zamanObje,dogruYanlisObje,playerObje,puanObje;
    int KalanSure ;
    bool sureSaysinmi ;
    void Start()
    {
        KalanSure = 90;
        sureSaysinmi =true;
        sonucPaneli.SetActive(false);

        sonuclarObje.SetActive(true);
        zamanObje.SetActive(true);
        dogruYanlisObje.SetActive(true);
        playerObje.SetActive(true);
        puanObje.SetActive(true);


        StartCoroutine(SureTimerRoutine());

        
        
    }

    IEnumerator SureTimerRoutine(){
        while(sureSaysinmi){
            yield return new WaitForSeconds(1f);
            if(KalanSure<10){
                SureText.text = "0"+KalanSure.ToString();
            }
            else{
                SureText.text = KalanSure.ToString();
            }
            if(KalanSure<=0){
                sureSaysinmi = false;
                SureText.text = "";

                EkraniTemizle();

                sonucPaneli.SetActive(true);
            }
            KalanSure--;
            
        }
    }

    void EkraniTemizle(){

        sonuclarObje.SetActive(false);
        zamanObje.SetActive(false);
        dogruYanlisObje.SetActive(false);
        playerObje.SetActive(false);
        puanObje.SetActive(false);

    }

  
}
