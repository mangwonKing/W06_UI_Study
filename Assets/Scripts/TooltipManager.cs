using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TooltipManager : MonoBehaviour
{
    public static TooltipManager tooltipInstance { get; private set; }

    public GameObject tooltip;
    private void Awake()
    {
        if(tooltipInstance == null)
        {
            tooltipInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnTooltip(Item item)
    {
        string infoText = "";
        tooltip.gameObject.SetActive(true);
        infoText += "name : " + item.itemName +"\n";
        infoText += "number : " + item.number + "\n";

        tooltip.GetComponentInChildren<TextMeshProUGUI>().text = infoText;
    }
    public void OffTooltip()
    {
        tooltip.gameObject.SetActive(false);
    }


}
