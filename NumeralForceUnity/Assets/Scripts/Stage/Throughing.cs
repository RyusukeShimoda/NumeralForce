using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throughing : MonoBehaviour
{
    public GameObject pone;
    public GameObject[] selector;
    [SerializeField] Material Through;
    [SerializeField] Material Orange;
    [SerializeField] BoxCollider BoxCol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selector = GameObject.FindGameObjectsWithTag("Selected");
        if (selector.Length == 0)
        {
            pone.GetComponent<Renderer>().material = Orange;
            BoxCol.enabled = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Selected")
        {
            pone.GetComponent<Renderer>().material = Through;
            BoxCol.enabled = false;
        }
    }
}
