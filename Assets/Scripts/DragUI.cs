using GDS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform targetPanel;
    public GameObject inventory;

    private RectTransform rectTransform;
    private Vector2 originalPosition;
    private Canvas canvas;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        originalPosition = rectTransform.anchoredPosition;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("드래그");
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("드래그 끝");
        if (RectTransformUtility.RectangleContainsScreenPoint(targetPanel, Input.mousePosition, canvas.worldCamera))
        {
            Debug.Log("Dropped on the panel!");
            // 패널 위에 놓여진 경우의 처리
            inventory.SetActive(true);
            inventory.transform.position = eventData.position;
            eventData.pointerDrag.SetActive(false);
        }
        else
        {
            
        }

    }
}
