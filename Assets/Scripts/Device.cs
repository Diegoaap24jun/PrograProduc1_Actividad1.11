using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device : Object
{
    string identificationCode;

    public Device(string id)
    {
        identificationCode = id;
    }

    public virtual string ToString()
    {
        return "Device ID: " + identificationCode;
    }
}
