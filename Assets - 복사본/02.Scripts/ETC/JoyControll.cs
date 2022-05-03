using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class JoyControll : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private Image joyBack;
    private Image joyPront;
    private Vector2 touchPosition;

    private void Awake()
    {
        joyBack = GetComponent<Image>();
        joyPront = transform.GetChild(0).GetComponent<Image>();
    }

    public void OnDrag(PointerEventData eventData)   // ��ġ ������ �� �� ������ ȣ�� 
    {
        touchPosition = Vector2.zero;
        
        if ( RectTransformUtility.ScreenPointToLocalPointInRectangle(
            joyBack.rectTransform, eventData.position, eventData.pressEventCamera, out touchPosition) )

        {
            touchPosition.x = (touchPosition.x / joyBack.rectTransform.sizeDelta.x);
            touchPosition.y = (touchPosition.y / joyBack.rectTransform.sizeDelta.y);

            touchPosition = new Vector2(touchPosition.x * 2 - 1, touchPosition.y * 2 - 1);

            touchPosition = (touchPosition.magnitude > 1) ? touchPosition.normalized : touchPosition;

            joyPront.rectTransform.anchoredPosition = new Vector2(
                touchPosition.x * joyBack.rectTransform.sizeDelta.x / 2,
                touchPosition.y * joyPront.rectTransform.sizeDelta.y / 2);
        }
    }   

    public void OnPointerDown(PointerEventData eventData)   // ��ġ ���� �� 1ȸ ȣ��
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)   // ��ġ ���� �� ��Ʈ�ѷ��� �߾����� �ű��.
    {
        joyPront.rectTransform.anchoredPosition = Vector2.zero;
        touchPosition = Vector2.zero;
    }

    public float Horizontal()
    {
        return touchPosition.x;
    }   
    public float Vertical()
    {
        return touchPosition.y;
    }
}
