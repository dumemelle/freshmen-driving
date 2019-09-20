using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complete : MonoBehaviour
{
    public GameObject CompleteTrig;
    public GameObject StartTrig;

    private void OnTriggerEnter()
    {
        CompleteTrig.SetActive(true);
        StartTrig.SetActive(false);
    }

}
