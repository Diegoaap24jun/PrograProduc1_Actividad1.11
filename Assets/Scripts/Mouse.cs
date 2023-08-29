using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : Device
{
    float dpi;

    public Mouse(string id, int dpi) : base(id)
    {
        this.dpi = dpi;
    }

    public override string ToString()
    {
        return base.ToString() + ", Device Type: Mouse with "+ dpi + " DPI.";
    }
}
