using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    private static int total = 10;

    [Header("Objects")]
    public GameObject[] obj = new GameObject[total];

    [Header("buttons")]
    public GameObject[] whiteButton = new GameObject[total];
    public GameObject[] yellowButton = new GameObject[total];

    public GameObject finalObj;


    public void onClickObj1()
    {
        Debug.Log(1);
        finalObj = obj[0];
        changeColor(0);
    }

    public void onClickObj2()
    {
        Debug.Log(2);
        finalObj = obj[1];
        changeColor(1);
    }

    public void onClickObj3()
    {
        Debug.Log(3);
        finalObj = obj[2];
        changeColor(2);
    }

    public void onClickObj4()
    {
        Debug.Log(4);
        finalObj = obj[3];
        changeColor(3);
    }

    public void onClickObj5()
    {
        Debug.Log(5);
        finalObj = obj[4];
        changeColor(4);
    }

    public void onClickObj6()
    {
        Debug.Log(6);
        finalObj = obj[5];
        changeColor(5);
    }

    public void onClickObj7()
    {
        Debug.Log(7);
        finalObj = obj[6];
        changeColor(6);
    }

    public void onClickObj8()
    {
        Debug.Log(8);
        finalObj = obj[7];
        changeColor(7);
    }

    public void onClickObj9()
    {
        Debug.Log(9);
        finalObj = obj[8];
        changeColor(8);
    }

    public void onClickObj10()
    {
        Debug.Log(10);
        finalObj = obj[9];
        changeColor(9);
    }

    public void changeColor(int temp)
    {
        for (int i = 0; i < total; i++)
        {
            if (i == temp)
            {
                yellowButton[i].SetActive(true);
                whiteButton[i].SetActive(false);
            }
            else
            {
                yellowButton[i].SetActive(false);
                whiteButton[i].SetActive(true);
            }
        }
    }
}
