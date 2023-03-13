using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CriWare;

public class PressToCuePlay : MonoBehaviour
{
    //CRI公開メンバ関数等取得用グローバル変数定義
    float sendLevel = 1.0f;
    [Header("CRIWARESuperviser")]
    public GameObject soundManeger;
    CriAtomCont mainSpeaker;
    CriAtomSource audio;
    // Start is called before the first frame update

    void Awake() 
    {
        //CRI戻値等取得
        mainSpeaker = soundManeger.GetComponent<CriAtomCont>();
        sendLevel = mainSpeaker.mainVolumeControll();
        audio = (CriAtomSource)GetComponent("CriAtomSource");
    }
    void Start()
    {

    }

    //当たり判定クリック時、コンポーネントに設定のCRI音楽データ再生
    void OnMouseDown()
    {
        //CRICue指定再生
        audio.cueSheet = "NumeralForceCueSheet";
        audio = (CriAtomSource)GetComponent("CriAtomSource");
        audio.Play(1);
    }

    // Update is called once per frame
    void Update()
    {
        //CRI統括音量反映
        sendLevel = mainSpeaker.mainVolumeControll();
        audio.SetBusSendLevel(0, sendLevel);
    }
}
