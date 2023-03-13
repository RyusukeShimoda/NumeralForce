using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CriWare;

public class CriAtomCont : MonoBehaviour
{
    public float mainVolume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        CriAtom.AttachDspBusSetting("DspBusSetting_0");
        CriAtom.SetBusAnalyzer(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float mainVolumeControll()
    {
        float mainV = mainVolume;
        return mainV;
    }
}
