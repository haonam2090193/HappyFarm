using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootContainerInteract : InteractableObject
{
    [SerializeField] GameObject closedChest;
    [SerializeField] GameObject openedChest;
    [SerializeField] Animator animator;
    [SerializeField] bool opened;


    /*private void Update()
    {
        if (opened == false)
        {
            //opened = true;
            animator.Play("OpenChest");
        }
        else
        {
            //opened = false;
            animator.Play("CloseChest");
        }
    }*/
    public override void Interact(PlayerManager player)
    {
        if (opened == false)
        {
            opened = true;
            animator.Play("OpenChest");
        }
        else
        {
            opened = false;
            animator.Play("CloseChest");
        }
    }
}
