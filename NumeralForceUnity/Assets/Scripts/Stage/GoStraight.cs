using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GoStraight : MonoBehaviour
{
    public GameObject pone;
    public GameObject LE;
    public GameObject StE;
    public GameObject RE;
    public GameObject LES;
    public GameObject StES;
    public GameObject RES;

    [SerializeField] Vector3 startPos;

    public TurnManager TM;

    // Start is called before the first frame update
    void Start()
    {
        TM = GameObject.Find("GrandAdvisor").GetComponent<TurnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            LE.SetActive(false);
            StE.SetActive(false);
            RE.SetActive(false);
            LE.GetComponent<BoxCollider>().enabled = false;
            StE.GetComponent<BoxCollider>().enabled = false;
            RE.GetComponent<BoxCollider>().enabled = false;
            LE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = false;
            StE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = false;
            RE.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = false;
            LES.tag = "Untagged";
            StES.tag = "Untagged";
            RES.tag = "Untagged";
        }
    }

    public void OnMouseDown()
    {
        if (this.tag == "Selected")
        {
            LE.SetActive(false);
            StE.SetActive(false);
            RE.SetActive(false);
            startPos = pone.transform.position;
            pone.transform.DORotate(new Vector3(360f, 0, 0), 0.5f, RotateMode.FastBeyond360);
            if (this.transform.parent.gameObject.name == "PoneBlue(Clone)")
            {
                TM.PlayerTurn = false;
                pone.transform.DOLocalMoveY(5f, 0.5f);
                pone.transform.DOLocalMoveY(1.1f, 0.5f).SetDelay(0.5f);
                pone.transform.DOLocalMoveZ(startPos.z + 4.6f, 0.5f).SetDelay(0.5f);
                DOVirtual.DelayedCall(1.5f, () => TM.TurnTurnE());
            }
            else if (this.transform.parent.gameObject.name == "PoneOrangeP(Clone)")
            {
                TM.EnemyTurn = false;
                pone.transform.DOLocalMoveY(5f, 0.5f);
                pone.transform.DOLocalMoveY(1.1f, 0.5f).SetDelay(0.5f);
                pone.transform.DOLocalMoveZ(startPos.z - 4.6f, 0.5f).SetDelay(0.5f);
                DOVirtual.DelayedCall(1.5f, () => TM.TurnTurnP());
            }
        }
    }
}
