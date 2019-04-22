using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testHunt : MonoBehaviour
{
    public GameObject canvasHolder;
    public GameObject placeHolder;
    public GameObject nameholders;
    string canvasName = "Canvas";
    string[] huntNames = {"yes i did sir","have you seen my bear, tibbers" };
    // Start is called before the first frame update
    void Start()
    {
        hunt[] hunts = new hunt[2];

        hunts[0].setHuntName(huntNames[0]);
        Debug.Log(hunts[0].getHuntName());
            /*canvasHolder = GameObject.Find(canvasName);
            GameObject newPlaceHolder = Instantiate(placeHolder, canvasHolder.transform);
            nameholders = placeHolder.transform.GetChild(0).gameObject;
            hunts[0].getHuntName(nameholders);  */      
    }

   
}
