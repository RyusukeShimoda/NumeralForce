using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCamera : MonoBehaviour
{
    [SerializeField] TurnManager TM;

    // Start is called before the first frame update
    void Start()
    {
        TM = GameObject.Find("GrandAdvisor").GetComponent<TurnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TM.offline == false||TM.PlayerTurn) 
        {
            if (this.transform.root.tag == "SA1P" || this.transform.root.tag == "SB1P" || this.transform.root.tag == "SC1P" || this.transform.root.tag == "SA1E" || this.transform.root.tag == "SB1E" || this.transform.root.tag == "SC1E")
            {
                transform.localPosition = new Vector3(0, 0, -1);
                transform.rotation = Quaternion.Euler(25, 0, 0);
            }
            else if (this.transform.root.tag == "SA2P" || this.transform.root.tag == "SB2P" || this.transform.root.tag == "SC2P" || this.transform.root.tag == "SA2E" || this.transform.root.tag == "SB2E" || this.transform.root.tag == "SC2E")
            {
                transform.localPosition = new Vector3(0, 0.5f, -1);
                transform.rotation = Quaternion.Euler(25, 0, 0);
            }
            else if (this.transform.root.tag == "SA3P" || this.transform.root.tag == "SB3P" || this.transform.root.tag == "SC3P" || this.transform.root.tag == "SA3E" || this.transform.root.tag == "SB3E" || this.transform.root.tag == "SC3E")
            {
                transform.localPosition = new Vector3(0, 1.5f, -1);
                transform.rotation = Quaternion.Euler(30, 0, 0);
            }
            else if (this.transform.root.tag == "SA4P" || this.transform.root.tag == "SB4P" || this.transform.root.tag == "SC4P" || this.transform.root.tag == "SA4E" || this.transform.root.tag == "SB4E" || this.transform.root.tag == "SC4E")
            {
                transform.localPosition = new Vector3(0, 3, -0.5f);
                transform.rotation = Quaternion.Euler(40, 0, 0);
            }
        }
        else if (TM.EnemyTurn && TM.offline)
        {
            if (this.transform.root.tag == "SA1P" || this.transform.root.tag == "SB1P" || this.transform.root.tag == "SC1P" || this.transform.root.tag == "SA1E" || this.transform.root.tag == "SB1E" || this.transform.root.tag == "SC1E")
            {
                transform.localPosition = new Vector3(0, 3, 0.5f);
                transform.rotation = Quaternion.Euler(40, 180, 0);
            }
            else if (this.transform.root.tag == "SA2P" || this.transform.root.tag == "SB2P" || this.transform.root.tag == "SC2P" || this.transform.root.tag == "SA2E" || this.transform.root.tag == "SB2E" || this.transform.root.tag == "SC2E")
            {
                transform.localPosition = new Vector3(0, 1.5f, 1);
                transform.rotation = Quaternion.Euler(30, 180, 0);
            }
            else if (this.transform.root.tag == "SA3P" || this.transform.root.tag == "SB3P" || this.transform.root.tag == "SC3P" || this.transform.root.tag == "SA3E" || this.transform.root.tag == "SB3E" || this.transform.root.tag == "SC3E")
            {
                transform.localPosition = new Vector3(0, 0.5f, 1);
                transform.rotation = Quaternion.Euler(25, 180, 0);
            }
            else if (this.transform.root.tag == "SA4P" || this.transform.root.tag == "SB4P" || this.transform.root.tag == "SC4P" || this.transform.root.tag == "SA4E" || this.transform.root.tag == "SB4E" || this.transform.root.tag == "SC4E")
            {
                transform.localPosition = new Vector3(0, 0, 1);
                transform.rotation = Quaternion.Euler(25, 180, 0);
            }
        }
    }
}
