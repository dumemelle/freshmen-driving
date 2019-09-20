using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int mincount;
    public static int seccount;
    public static float millicount;
    public static string millidisplay;
    public GameObject minbox;
    public GameObject secbox;
    public GameObject millibox;

    void Update()
    {
        millicount += Time.deltaTime * 10;
        millidisplay = millicount.ToString("F0");
        millibox.GetComponent<Text>().text = "" + millidisplay;

        if (millicount >= 10)
         { 
            millicount = 0;
            seccount += 1;
        }
        if (seccount <= 9)
        {
            secbox.GetComponent<Text>().text  = "0" + seccount + ".";
        }
        else
        {
            secbox.GetComponent<Text>().text = "" + seccount + ".";
        }
        if (seccount >= 60)
        {
            seccount = 0;
            mincount += 1;
        }
        if(mincount <= 9)
        {
            minbox.GetComponent<Text>().text = "0" + mincount + ":";
        }
        else
        {
            minbox.GetComponent<Text>().text = "" + mincount + ":";
        }
    }
}
