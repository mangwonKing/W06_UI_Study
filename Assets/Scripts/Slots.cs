using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slots : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler
{
    
    public Item item;
    Image image;

    IllusionItem illusionItem;
    Image illusionImage;

    private void Awake()
    {
        illusionItem = GameObject.FindAnyObjectByType<IllusionItem>();
        illusionImage = illusionItem.GetComponent<Image>();
    }

    private void Start()
    {
        image = GetComponent<Image>();

    }

    public void SetItem(Item newItem)
    {
        item = newItem;
        if (newItem == null)
        {
            image.sprite = null;
        }
        else
        {
            image.sprite = item.image;

        }
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

    public void OnPointerClick(PointerEventData eventData)
    {
        
        if(illusionItem.GetItem() == null)
        {
            if (item == null) return;
            illusionItem.lastSlot = this;
            illusionImage.sprite = image.sprite;

            illusionImage.color = new Color(illusionImage.color.r, illusionImage.color.g, illusionImage.color.b, 0.75f);
            illusionImage.gameObject.SetActive(true);
            illusionItem.SetItem(item);
        }
        else
        {

            illusionItem.lastSlot.SetItem(item);
            SetItem(illusionItem.GetItem());

            illusionItem.SetItem(null);
            illusionImage.color = new Color(illusionImage.color.r, illusionImage.color.g, illusionImage.color.b, 0f);
            
        }
    }

}
