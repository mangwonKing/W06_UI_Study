using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour ,IPointerEnterHandler
{
    public GameObject inventory;
    //public void OnDrop(PointerEventData eventData)
    //{
    //    if(eventData.pointerDrag != null) //�巡�� ���� ��
    //    {
    //        print("�����");
    //        inventory.SetActive(true);

    //        eventData.pointerDrag.SetActive(false);
    //    }
    //}
    public void OnPointerEnter(PointerEventData eventData)
    {
        //if(eventData.pointerDrag!= null)
        //{
        //    print("�����");
        //    inventory.SetActive(true);

        //    eventData.pointerDrag.SetActive(false);
        //}

        
    }
}
