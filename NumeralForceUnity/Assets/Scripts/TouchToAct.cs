using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class TouchToAct : MonoBehaviour
{
    [SerializeField] bool alphaOn;
    [SerializeField] float alphaFloat;
    [SerializeField] bool turnOn;

    [SerializeField] Renderer mat;
    [SerializeField] UIMover um;
    [SerializeField] GameObject[] layer;

    [SerializeField] bool alphaMode;
    [SerializeField] bool turnMode;

    [SerializeField] TextMeshProUGUI tx;
    [SerializeField] TextMeshProUGUI txJpn;
    [SerializeField] string txName;
    [SerializeField] string txJpnName;

    // Start is called before the first frame update
    void Start()
    {
        if (alphaMode) 
        {
            mat = this.GetComponent<Renderer>();
            alphaFloat = mat.material.color.a;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (alphaOn) 
        {
            alphaFloat -= 0.03f;
            SetAlpha();
            if (alphaFloat <= 0) 
            {
                alphaOn = false;
                um.Go1();
                ActiveFalse();
            }
        }
        else if (turnOn) 
        {
            //DOTween.Clear();
            TurnDown();
        }
    }

    void OnMouseEnter() 
    {
        if (turnMode) 
        {
            tx.text = txName;
            txJpn.text = txJpnName;
        }
    }

    void OnMouseExit()
    {
        if (turnMode)
        {
            tx.text = "";
            txJpn.text = "";
        }
    }

    void OnMouseUp()
    {
        if (alphaMode) alphaOn = true;
        else if (turnMode) turnOn = true;
    }

    void SetAlpha()
    {
        mat.material.color = new Color(1, 1, 1, alphaFloat);
    }

    void TurnDown() 
    {
        this.transform.DOLocalRotate(new Vector3(90, 0, 0), 0.3f);
        this.GetComponent<BoxCollider2D>().enabled = false;
        for (int i = 0;i <= layer.Length-1; i++) 
        {
            layer[i].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.3f);
            layer[i].GetComponent<BoxCollider2D>().enabled = false;
        }

        if (name == "ButtonTutrialAndStory" || name == "ButtonBack11223") um.Go112();
        else if (name == "ButtonTutrial") um.GoTutrial();
        else if (name == "ButtonStory"||name == "ButtonTurn") um.Go11223();
        else if (name == "Button1s") um.Go1s();
        else if (name == "Button2s") um.Go2s();
        else if (name == "Button3s") um.Go3s();
        else if (name == "Button4s") um.Go4s();
        else if (name == "ButtonNext") um.Go11223b();
        else if (name == "Button5s") um.Go5s();
        else if (name == "ButtonAI" || name == "ButtonBack12213") um.Go122();
        else if (name == "ButtonOfflineOnline" || name == "ButtonBack13213") um.Go132();
        else if (name == "ButtonNormalOffline") um.GoOffline();
        else if (name == "ButtonEasy") um.GoEasy();
        else if (name == "ButtonHard") um.GoHard();
        else if (name == "ButtonCredit") um.Go142();
        else if (name == "ButtonBack112"|| name == "ButtonBack122" || name == "ButtonBack132" || name == "ButtonBack142") um.Go1();
        else if (name == "ButtonNormalBattle") um.Go12213();
        else if (name == "ButtonOffline") um.Go13213();

        turnOn = false;
    }

    void ActiveTrue()
    {
        this.gameObject.SetActive(true);
    }

    void ActiveFalse() 
    {
        this.gameObject.SetActive(false);
    }
}
