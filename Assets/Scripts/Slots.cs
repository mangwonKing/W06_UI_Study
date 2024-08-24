using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    public Item item;
    Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void SetItem(Item newItem)
    {
        item = newItem;
        image.sprite = item.image;
    }
}
