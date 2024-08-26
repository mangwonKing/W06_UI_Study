using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllusionItem : MonoBehaviour
{

    Item item;

    public Slots lastSlot;
    private void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void SetItem(Item newItem)
    {
        item = newItem;
    }
    public Item GetItem()
    {
        return item;
    }
}
