using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Slots[] slots;
    public Transform slotParent;

    public Item[] testItem;
    private void Start()
    {
        slots = slotParent.GetComponentsInChildren<Slots>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            int itemIdx = Random.Range(0, testItem.Length);
            SetItem(testItem[itemIdx]);
        }
    }
    public void SetItem(Item newItem)
    {

        foreach (var slot in slots)
        {
            if (slot.item == newItem) continue;
            if(slot.item == null)
            {
                slot.SetItem(newItem);
                break;
            }
            else
            {

            }
        }

    }
}
