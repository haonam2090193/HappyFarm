using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCutable : Tools
{
    [SerializeField] GameObject pickUpDrop;
    [SerializeField] int dropCount = 5;
    [SerializeField] float spread = 0.7f;
    public override void ToolsHit()
    {
        while(dropCount > 0)
        {
            dropCount -= 1;
            Vector3 position = transform.position;
            position.x += spread * Random.value - spread / 2;
            position.y += spread * Random.value - spread / 2;
            GameObject go = Instantiate(pickUpDrop);
            go.transform.position = position;
        }

        Debug.Log("Hit");
        Destroy(gameObject);
    }
}
