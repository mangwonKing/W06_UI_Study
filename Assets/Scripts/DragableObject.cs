using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragableObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform targetPanel;
    public GameObject changeObject;

    private RectTransform rectTransform;
    private Vector2 originalPosition;
    private Canvas canvas;

    Vector2 offset;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        //originalPosition = rectTransform.anchoredPosition;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("드래그");
        offset = (Vector2)rectTransform.position - eventData.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.position = eventData.position + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("드래그 끝");
        if (RectTransformUtility.RectangleContainsScreenPoint(targetPanel, Input.mousePosition, canvas.worldCamera))
        {
            Debug.Log("Dropped on the panel!");
            // 패널 위에 놓여진 경우의 처리
            changeObject.SetActive(true);
            changeObject.transform.position = eventData.position;
            //changeObject.GetComponent<RectTransform>().anchoredPosition = eventData.position;
            eventData.pointerDrag.SetActive(false);
        }
        else
        {

        }
    }
}
