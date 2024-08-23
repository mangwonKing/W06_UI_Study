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

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        originalPosition = rectTransform.anchoredPosition;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        print("�巡��");
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("�巡�� ��");
        if (RectTransformUtility.RectangleContainsScreenPoint(targetPanel, Input.mousePosition, canvas.worldCamera))
        {
            Debug.Log("Dropped on the panel!");
            // �г� ���� ������ ����� ó��
            changeObject.SetActive(true);
            //changeObject.transform.position = eventData.position;
            changeObject.GetComponent<RectTransform>().anchoredPosition = eventData.position;
            eventData.pointerDrag.SetActive(false);
        }
        else
        {

        }
    }
}
