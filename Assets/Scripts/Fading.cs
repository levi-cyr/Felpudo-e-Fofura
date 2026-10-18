using System.Collections;
using UnityEngine;

public class Fading : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeDuration = 5f;
    public bool fadeIn = false;
    /*
    public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(canvasGroup, canvasGroup.alpha, 0, fadeDuration));
    }

    IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float duration)
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            cg.alpha = Mathf.Lerp(start, end, elapsedTime);
            yield return null;
        }
        cg.alpha = end;
    } */
}
