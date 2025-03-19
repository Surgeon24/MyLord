using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DialogTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public GameObject dialogueWindow;
    private Image highlightImage;

    void Start()
    {
        highlightImage = GetComponent<Image>();
        if (highlightImage != null)
        {
            highlightImage.color = new Color(1, 1, 1, 0);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (highlightImage != null)
        {
            highlightImage.color = new Color(1, 1, 1, 0.3f);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (highlightImage != null)
        {
            highlightImage.color = new Color(1, 1, 1, 0);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (dialogueWindow != null)
        {
            dialogueWindow.SetActive(true);
        }
    }
}


