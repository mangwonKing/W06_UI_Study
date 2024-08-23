using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour ,IPointerEnterHandler
{
    public GameObject inventory;
    //public void OnDrop(PointerEventData eventData)
    //{
    //    if(eventData.pointerDrag != null) //드래그 중일 때
    //    {
    //        print("드롭존");
    //        inventory.SetActive(true);

    //        eventData.pointerDrag.SetActive(false);
    //    }
    //}
    public void OnPointerEnter(PointerEventData eventData)
    {
        //if(eventData.pointerDrag!= null)
        //{
        //    print("드롭존");
        //    inventory.SetActive(true);

        //    eventData.pointerDrag.SetActive(false);
        //}

        
    }
}
