using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Button2 : MonoBehaviour
{
    GameObject Circle;
    public void setrigidbody(GameObject circle)
    {
        circle = GameObject.FindGameObjectWithTag("Player");
        circle.AddComponent<Rigidbody2D>();
        Debug.Log("Sudah Jatuh");
    }   

    public void Onclick2()
    {
        setrigidbody(Circle);
    }
}
