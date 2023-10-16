using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCutable : Tools
{
    public override void ToolsHit()
    {
        Destroy(gameObject);
    }
}
