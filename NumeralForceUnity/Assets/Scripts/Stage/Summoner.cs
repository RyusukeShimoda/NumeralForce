using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Summoner : MonoBehaviour
{
    int SumPattern;
    [SerializeField] Vector3 startPos;
    [SerializeField] GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        SumPattern = Random.Range(0, 3);
        if(SumPattern==0)Summon();
        else if (SumPattern == 1) Summon2();
        else if (SumPattern == 2) Summon3();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag != "PoneP" && this.tag != "PoneE") canvas.SetActive(true);
        else canvas.SetActive(false);
    }

    void Summon() 
    {
        startPos = this.transform.position;
        this.transform.DOMove(new Vector3(startPos.x, startPos.y-15, startPos.z), 0.9f).SetEase(Ease.InOutQuad);
        this.transform.DORotate(new Vector3(-720f, 0, 0), 0.9f, RotateMode.FastBeyond360);
        this.transform.DOMoveY(1.12f, 0.1f).SetDelay(0.9f);
    }

    void Summon2()
    {
        startPos = this.transform.position;
        this.transform.DOMove(new Vector3(startPos.x, startPos.y - 15, startPos.z), 0.9f).SetEase(Ease.InOutQuad);
        this.transform.DORotate(new Vector3(0, 0, -720f), 0.9f, RotateMode.FastBeyond360);
        this.transform.DOMoveY(1.12f, 0.1f).SetDelay(0.9f);
    }

    void Summon3()
    {
        startPos = this.transform.position;
        this.transform.DOMove(new Vector3(startPos.x, startPos.y - 15, startPos.z), 0.9f).SetEase(Ease.InOutQuad);
        this.transform.DORotate(new Vector3(0, 0, -720f), 0.9f, RotateMode.FastBeyond360);
        this.transform.DOMoveY(1.12f, 0.1f).SetDelay(0.9f);
    }
}
