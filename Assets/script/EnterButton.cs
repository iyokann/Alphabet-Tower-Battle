using UnityEngine;
using UnityEngine.EventSystems;

public class EnterButton : MonoBehaviour, IPointerDownHandler
{

    public static bool onButtonDown;//ボタンがクリックされてるかを判定！

    /// <summary>
    /// ボタンが押されたと検出
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerDown(PointerEventData eventData)
    {
        onButtonDown = true;
    }
}