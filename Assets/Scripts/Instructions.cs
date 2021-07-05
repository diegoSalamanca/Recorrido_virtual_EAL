using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{

    public bool active;

    public string[] copys;

    public GameObject[] arrows;

    public CanvasGroup canvasGroup;

    public TMPro.TextMeshProUGUI text;

    public static int state;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayInstructions(0, 1));
    }

    public IEnumerator DelayInstructions(int index, float delay)
    {
        yield return new WaitForSeconds(delay);
        SetInstruction(index);
    }
   

    public void SetInstruction(int index)
    {

        state = index;

        if (active)
        {
            foreach (var item in arrows)
            {
                item.SetActive(false);
            }

            arrows[index].SetActive(true);
            text.text = copys[index];

            canvasGroup.alpha = 1;
        }        
    }

    public void removeInstruction()
    {
        canvasGroup.alpha = 0;
        if (state == 0)
        {
            StartCoroutine(DelayInstructions(1, 3));
        }
        if (state == 1)
        {
            StartCoroutine(DelayInstructions(2, 3));
        }
    }




}
