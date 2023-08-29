using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : Device
{
    float numberOfKeys;

    public Keyboard(string id, int keys) : base(id)
    {
        numberOfKeys = keys;
    }

    public override string ToString()
    {
        return base.ToString() + ", Device Type: Keyboard with " + numberOfKeys + " DPI.";
    }
}
