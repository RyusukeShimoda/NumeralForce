using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class TurnManager : MonoBehaviour
{
    public bool PlayerTurn = false;
    public bool EnemyTurn = false;
    [SerializeField] GameObject protector;
    public GameObject TurnBack;
    public GameObject TurnTxP;
    public GameObject TurnTxE;
    public GameObject Canvas;
    public GameObject CanvasR;
    public GameObject TurnBackR;
    public GameObject TxPR;
    public GameObject TxER;
    [SerializeField] GameObject sceneEx;
    [SerializeField] CriAtomSource cas;
    [SerializeField] CriAtomSource cas2;
    [SerializeField] int cas2Time;
    [SerializeField] NumbersAdvice NA;
    [SerializeField] TheAI AI;
    [SerializeField] TheAIEasy AIE;
    [SerializeField] bool tutrial;
    public bool easy;
    public bool offline;
    [SerializeField] GameObject camera;
    [SerializeField] TutrialStageCount tsc;
    [SerializeField] int scene;
    [SerializeField] int storyScene;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerTurn == true) 
        {
            protector.SetActive(false);
        }
        else if(offline && EnemyTurn == true) 
        {
            protector.SetActive(false);
        }
        else
        {
            protector.SetActive(true);
        }
    }

    public void TurnTurnP() 
    {
        if(NA.playerLife > 0 && NA.enemyLife > 0) 
        {
            TurnBack.transform.DOLocalRotate(new Vector3(67, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => TurnTxP.SetActive(true));
            DOVirtual.DelayedCall(1, () => TurnTxE.SetActive(false));
            TurnBack.transform.DOLocalRotate(new Vector3(0, 0, 0), 1f).SetDelay(1f);
            DOVirtual.DelayedCall(2, () => PlayerTurn = true);
            if (offline) 
            {
                this.transform.DOMove(new Vector3(0, 0, -2.3f), 2.0f).SetEase(Ease.InOutQuad);
                camera.transform.DOMove(new Vector3(12, 6.9f, 0), 1.0f).SetEase(Ease.InOutQuad);
                camera.transform.DOMove(new Vector3(0, 13.8f, -8), 1.0f).SetDelay(1.0f).SetEase(Ease.InOutQuad);
            }
        }
    }

    public void TurnTurnPOfflineStart()
    {
        if (NA.playerLife > 0 && NA.enemyLife > 0)
        {
            TurnBack.transform.DOLocalRotate(new Vector3(67, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => TurnTxP.SetActive(true));
            DOVirtual.DelayedCall(1, () => TurnTxE.SetActive(false));
            TurnBack.transform.DOLocalRotate(new Vector3(0, 0, 0), 1f).SetDelay(1f);
            DOVirtual.DelayedCall(2, () => PlayerTurn = true);
        }
    }

    public void TurnTurnE()
    {
        if(NA.playerLife > 0 && NA.enemyLife > 0) 
        {
            if(tutrial) DOVirtual.DelayedCall(2, () => tsc.CountUp());
            TurnBack.transform.DOLocalRotate(new Vector3(67, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => TurnTxE.SetActive(true));
            DOVirtual.DelayedCall(1, () => TurnTxP.SetActive(false));
            TurnBack.transform.DOLocalRotate(new Vector3(0, 0, 0), 1f).SetDelay(1f);
            DOVirtual.DelayedCall(2, () => EnemyTurn = true);
            if (offline == false && easy == false) DOVirtual.DelayedCall(3, () => AI.AIAnalyze());
            else if (easy) DOVirtual.DelayedCall(3, () => AIE.AIAnalyze());
            else 
            {
                this.transform.DOMove(new Vector3(0, 0, 2.3f), 2.0f).SetEase(Ease.InOutQuad);
                camera.transform.DOMove(new Vector3(-12, 6.9f, 0), 1.0f).SetEase(Ease.InOutQuad);
                camera.transform.DOMove(new Vector3(0, 13.8f, 8), 1.0f).SetDelay(1.0f).SetEase(Ease.InOutQuad);
            }
        }
    }

    public void YouWin() 
    {
        Canvas.SetActive(false);
        CanvasR.SetActive(true);
        TxPR.SetActive(true);
        cas.Stop();
        cas2Time += 1;
        if (cas2Time >= 10000) cas2Time = 10;
        else if (cas2Time == 1) DOVirtual.DelayedCall(1, () => cas2.Play());
        if (storyScene != 0) scene = storyScene;
        TurnBackR.transform.DOLocalRotate(new Vector3(0, 0, 0), 1f).SetDelay(1f);
        DOVirtual.DelayedCall(2, () => sceneEx.SetActive(true));
    }

    public void YouLose()
    {
        Canvas.SetActive(false);
        CanvasR.SetActive(true);
        TxER.SetActive(true);
        cas.Stop();
        scene = 0;
        if (offline) 
        {
            cas2Time += 1;
            if (cas2Time >= 10000) cas2Time = 10;
            else if (cas2Time == 1) DOVirtual.DelayedCall(1, () => cas2.Play());
        }
        TurnBackR.transform.DOLocalRotate(new Vector3(0, 0, 0), 1f).SetDelay(1f);
        DOVirtual.DelayedCall(2, () => sceneEx.SetActive(true));
    }

    public void SceneExiter() 
    {
        SceneManager.LoadScene(scene);
    }
}
