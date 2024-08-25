using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slots : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
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
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(item != null)
        {
            TooltipManager.tooltipInstance.OnTooltip(item);

        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TooltipManager.tooltipInstance.OffTooltip();

    }
}
