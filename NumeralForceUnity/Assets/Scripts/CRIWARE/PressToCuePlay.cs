using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CriWare;

public class PressToCuePlay : MonoBehaviour
{
    //CRI���J�����o�֐����擾�p�O���[�o���ϐ���`
    float sendLevel = 1.0f;
    [Header("CRIWARESuperviser")]
    public GameObject soundManeger;
    CriAtomCont mainSpeaker;
    CriAtomSource audio;
    // Start is called before the first frame update

    void Awake() 
    {
        //CRI�ߒl���擾
        mainSpeaker = soundManeger.GetComponent<CriAtomCont>();
        sendLevel = mainSpeaker.mainVolumeControll();
        audio = (CriAtomSource)GetComponent("CriAtomSource");
    }
    void Start()
    {

    }

    //�����蔻��N���b�N���A�R���|�[�l���g�ɐݒ��CRI���y�f�[�^�Đ�
    void OnMouseDown()
    {
        //CRICue�w��Đ�
        audio.cueSheet = "NumeralForceCueSheet";
        audio = (CriAtomSource)GetComponent("CriAtomSource");
        audio.Play(1);
    }

    // Update is called once per frame
    void Update()
    {
        //CRI�������ʔ��f
        sendLevel = mainSpeaker.mainVolumeControll();
        audio.SetBusSendLevel(0, sendLevel);
    }
}
