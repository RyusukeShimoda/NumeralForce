using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Shouter : MonoBehaviour
{
    public GameObject EDamTx;
    public GameObject PDamTx;

    public NumbersAdvice NA;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (NA.TM.offline)
        {
            if (other.tag == "SA1P" || other.tag == "SB1P" || other.tag == "SC1P")
            {
                if (other.gameObject.GetComponent<TheNumber>().number >= 1)
                {
                    other.gameObject.GetComponent<Shout>().Jump();
                    DOVirtual.DelayedCall(0.8f, () => EDamTx.SetActive(true));
                    DOVirtual.DelayedCall(1.3f, () => EnemyDamage());
                    DOVirtual.DelayedCall(1.6f, () => EDamTx.SetActive(false));
                }
            }
            else if (other.tag == "SA4E" || other.tag == "SB4E" || other.tag == "SC4E")
            {
                if (other.gameObject.GetComponent<TheNumber>().number >= 1)
                {
                    other.gameObject.GetComponent<Shout>().Jump();
                    DOVirtual.DelayedCall(0.8f, () => EDamTx.SetActive(true));
                    DOVirtual.DelayedCall(1.3f, () => PlayerDamage());
                    DOVirtual.DelayedCall(1.6f, () => EDamTx.SetActive(false));
                }
            }
        }
        else 
        {
            if (other.tag == "SA1P" || other.tag == "SB1P" || other.tag == "SC1P")
            {
                if (other.gameObject.GetComponent<TheNumber>().number >= 1)
                {
                    other.gameObject.GetComponent<Shout>().Jump();
                    DOVirtual.DelayedCall(0.8f, () => EDamTx.SetActive(true));
                    DOVirtual.DelayedCall(1.3f, () => EnemyDamage());
                    DOVirtual.DelayedCall(1.6f, () => EDamTx.SetActive(false));
                }
            }
            else if (other.tag == "SA4E" || other.tag == "SB4E" || other.tag == "SC4E")
            {
                if (other.gameObject.GetComponent<TheNumber>().number >= 1)
                {
                    other.gameObject.GetComponent<Shout>().Jump();
                    DOVirtual.DelayedCall(0.8f, () => PDamTx.SetActive(true));
                    DOVirtual.DelayedCall(1.3f, () => PlayerDamage());
                    DOVirtual.DelayedCall(1.6f, () => PDamTx.SetActive(false));
                }
            }
        }
    }

    void EnemyDamage() 
    {
        NA.enemyLife -= 5;
    }

    void PlayerDamage()
    {
        NA.playerLife -= 5;
    }
}
