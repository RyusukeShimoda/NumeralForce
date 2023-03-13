using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreSkill : MonoBehaviour
{
    public GameObject info;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            info.SetActive(false);
        }
    }

    IEnumerator ActivateWait()
    {
        yield return null;
        info.SetActive(true);
    }

    void OnMouseUp()
    {
        StartCoroutine(ActivateWait());
    }
}
