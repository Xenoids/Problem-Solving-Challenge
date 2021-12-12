using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    public GameObject Circle;
    int count = 0;
    public void setCircle(GameObject circle)
    {
        Instantiate(circle);
    }

    public void OnClick()
    {
        if(count == 0)
        {
        setCircle(Circle);
        count++;
        }
        else Debug.Log("already input circle");
        
    }
}
