using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraMover : MonoBehaviour
{
    public Transform Origin;
    public int TurnDice;
    [SerializeField] TurnManager TM;
    public GameObject Canvas;
    public GameObject CanvasTutrial;

    [SerializeField] bool tutrial;

    // Start is called before the first frame update
    void Start()
    {
        TurnDice = Random.Range(0, 2);
        if (tutrial) TurnDice = 0;
        StartC1();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Origin);
    }

    public void  StartC1() 
    {
        this.transform.position = new Vector3(20,-20,0);
        this.transform.DOMove(new Vector3(-10,-5,-20), 1.0f).SetEase(Ease.InOutQuad);
        this.transform.DOMove(new Vector3(0, 20, -20), 1.0f).SetDelay(0.9f).SetEase(Ease.InOutQuad);
        this.transform.DOMove(new Vector3(0, 13.8f, -8), 1.0f).SetDelay(2.0f).SetEase(Ease.InOutQuad);
        Invoke("StartTurn", 3.0f);
    }

    void StartTurn() 
    {
        Canvas.SetActive(true);
        if (tutrial) CanvasTutrial.SetActive(true);
        if (TurnDice == 0)
        {
            if (TM.offline) TM.TurnTurnPOfflineStart();
            else TM.TurnTurnP();
        }
        else if (TurnDice == 1)
        {
            TM.TurnTurnE();
        }
    }
}
