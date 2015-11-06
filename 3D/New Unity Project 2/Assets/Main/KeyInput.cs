﻿using UnityEngine;
using System.Collections;

public class KeyInput : MonoBehaviour
{
    static bool UpBTN = false;
    static bool DownBTN = false;
    static bool LeftBTN = false;
    static bool RightBTN = false;
    static bool ForwardBTN = false;
    static bool BackBTN = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void G1PDown()
    {
        Main.Gelenk[1].GetComponent<Gelenk_Parameter>().RotateSpeed.y = 1;
    }

    public void G1MDown()
    {
        Main.Gelenk[1].GetComponent<Gelenk_Parameter>().RotateSpeed.y = -1;
    }

    public void G0PDown()
    {
        Main.Gelenk[0].GetComponent<Gelenk_Parameter>().RotateSpeed.y = 1;
    }

    public void G0MDown()
    {
        Main.Gelenk[0].GetComponent<Gelenk_Parameter>().RotateSpeed.y = -1;
    }

    public void G1PUp()
    {
        Main.Gelenk[1].GetComponent<Gelenk_Parameter>().RotateSpeed.y = 0;
    }

    public void G1MUp()
    {
        Main.Gelenk[1].GetComponent<Gelenk_Parameter>().RotateSpeed.y = 0;
    }

    public void G0PUp()
    {
        Main.Gelenk[0].GetComponent<Gelenk_Parameter>().RotateSpeed.y = 0;
    }

    public void G0MUp()
    {
        Main.Gelenk[0].GetComponent<Gelenk_Parameter>().RotateSpeed.y = 0;
    }

    public static float RotateCamerainYPos(float x)
    {
        return x - Input.GetAxis("Mouse Y");
    }

    public static float RotateCamerainXPos(float y)
    {
        return y + Input.GetAxis("Mouse X");
    }

    public static bool isMouseUp()
    {
        return Input.GetMouseButtonUp(1);
    }

    public static bool isMousDown()
    {
        return Input.GetMouseButtonDown(1);
    }

    public static bool isDown()
    {
        if (DownBTN)
            return true;
        return Input.GetKey(KeyCode.F);
    }

    public static bool isUp()
    {
        if (UpBTN)
            return true;
        return Input.GetKey(KeyCode.R);
    }

    public static bool isLeft()
    {
        if (LeftBTN)
            return true;
        return Input.GetKey(KeyCode.A);
    }

    public static bool isRight()
    {
        if (RightBTN)
            return true;
        return Input.GetKey(KeyCode.D);
    }

    public static bool isBack()
    {
        if (BackBTN)
            return true;
        return Input.GetKey(KeyCode.S);
    }

    public static bool isForward()
    {
        if (ForwardBTN)
            return true;
        return Input.GetKey(KeyCode.W);
    }

    public void setBTN(string keyAndValue)
    {
        string key = keyAndValue.Split(':')[0];
        bool value = keyAndValue.Split(':')[1].Contains("True");
        switch (key)
        {
            case "UpBTN": KeyInput.UpBTN = value; break;
            case "DownBTN": KeyInput.DownBTN = value; break;
            case "LeftBTN": KeyInput.LeftBTN = value; break;
            case "RightBTN": KeyInput.RightBTN = value; break;
            case "ForwardBTN": KeyInput.ForwardBTN = value; break;
            case "BackBTN": KeyInput.BackBTN = value; break;
        }
    }
}
