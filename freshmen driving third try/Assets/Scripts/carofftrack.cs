using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carofftrack : MonoBehaviour
{
    public GameObject OffTrackTrig;
    public GameObject car;
    public float carX;
    public float carY;
    public float carZ;
    public void Update()
    {
        carX = car.transform.position.x;
        carY = car.transform.position.y;
        carZ = car.transform.position.z;
        Debug.Log("x:" + carX + "y:" + carY + "z:" + carZ);
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
