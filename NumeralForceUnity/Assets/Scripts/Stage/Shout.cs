using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Shout : MonoBehaviour
{
    int ShoutPattern;
    [SerializeField] Vector3 startPos;
    [SerializeField] GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        ShoutPattern = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag != "PoneP" && this.tag != "PoneE") canvas.SetActive(true);
        else canvas.SetActive(false);
    }

    public void Jump() 
    {
        if(this.name == "PoneBlue(Clone)") 
        {
            if (ShoutPattern == 0) Shoutt();
            else if (ShoutPattern == 1) Shoutt2();
            else if (ShoutPattern == 2) Shoutt3();
        }
        else if (this.name == "PoneOrange(Clone)" || this.name == "PoneOrangeP(Clone)")
        {
            if (ShoutPattern == 0) ShouttE();
            else if (ShoutPattern == 1) ShouttE2();
            else if (ShoutPattern == 2) ShouttE3();
        }
    }

    void Shoutt()
    {
        startPos = this.transform.position;
        this.transform.DOLocalMove(new Vector3(startPos.x, startPos.y + 15, startPos.z + 15), 0.9f).SetEase(Ease.InOutQuad);
        this.transform.DOLocalRotate(new Vector3(-360f, 0, 0), 0.9f, RotateMode.FastBeyond360);
        DOVirtual.DelayedCall(1.5f, () => this.GetComponent<TheNumber>().FadeOut());
        
    }

    void Shoutt2()
    {
        startPos = this.transform.position;
        this.transform.DOLocalMove(new Vector3(startPos.x, startPos.y + 15, startPos.z + 15), 0.9f).SetEase(Ease.InOutQuad);
        this.transform.DOLocalRotate(new Vector3(0, 0, -360f), 0.9f, RotateMode.FastBeyond360);
        DOVirtual.DelayedCall(1.5f, () => this.GetComponent<TheNumber>().FadeOut());
    }

    void Shoutt3()
    {
        startPos = this.transform.position;
        this.transform.DOLocalMove(new Vector3(startPos.x, startPos.y + 15, startPos.z + 15), 0.9f).SetEase(Ease.InOutQuad);
        this.transform.DOLocalRotate(new Vector3(0, 0, -360f), 0.9f, RotateMode.FastBeyond360);
        DOVirtual.DelayedCall(1.5f, () => this.GetComponent<TheNumber>().FadeOut());
    }

    void ShouttE()
    {
        startPos = this.transform.position;
        this.transform.DOLocalMove(new Vector3(startPos.x, startPos.y + 15, startPos.z + 15), 0.9f).SetEase(Ease.InOutQuad);
        this.transform.DOLocalRotate(new Vector3(-360f, 0, 0), 0.9f, RotateMode.FastBeyond360);
        DOVirtual.DelayedCall(1.5f, () => this.GetComponent<TheNumber>().FadeOutE());
    }

    void ShouttE2()
    {
        startPos = this.transform.position;
        this.transform.DOLocalMove(new Vector3(startPos.x, startPos.y + 15, startPos.z + 15), 0.9f).SetEase(Ease.InOutQuad);
        this.transform.DOLocalRotate(new Vector3(0, 0, -360f), 0.9f, RotateMode.FastBeyond360);
        DOVirtual.DelayedCall(1.5f, () => this.GetComponent<TheNumber>().FadeOutE());
    }

    void ShouttE3()
    {
        startPos = this.transform.position;
        this.transform.DOLocalMove(new Vector3(startPos.x, startPos.y + 15, startPos.z + 15), 0.9f).SetEase(Ease.InOutQuad);
        this.transform.DOLocalRotate(new Vector3(0, 0, -360f), 0.9f, RotateMode.FastBeyond360);
        DOVirtual.DelayedCall(1.5f, () => this.GetComponent<TheNumber>().FadeOutE());
    }
}
