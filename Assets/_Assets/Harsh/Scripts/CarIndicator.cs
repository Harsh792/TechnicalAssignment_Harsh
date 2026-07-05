using System.Collections;
using UnityEngine;

public class CarIndicator : MonoBehaviour
{
    [Header("Renderer")]
    [SerializeField] private Renderer indicatorRenderer;

    [Header("Materials")]
    [SerializeField] private Material normalMaterial;
    [SerializeField] private Material glowMaterial;

    [Header("Blink Settings")]
    [SerializeField] private float blinkInterval = 0.1f;

    private Coroutine blinkCoroutine;

    public void StartIndicator()
    {
        CancelInvoke();
        StopIndicator();
        if (blinkCoroutine == null)
            blinkCoroutine = StartCoroutine(Blink());
    }

    public void StopIndicator()
    {
        if (blinkCoroutine != null)
        {
            StopCoroutine(blinkCoroutine);
            blinkCoroutine = null;
        }

        // Reset to normal material
        indicatorRenderer.material = normalMaterial;
    }

    private IEnumerator Blink()
    {
        while (true)
        {
            // Glow ON
            indicatorRenderer.material = glowMaterial;
            yield return new WaitForSeconds(blinkInterval);

            // Glow OFF
            indicatorRenderer.material = normalMaterial;
            yield return new WaitForSeconds(blinkInterval);
        }
    }

    public void TriggerIndicatorWithStopDelay()
    {
        StartIndicator();
        Invoke(nameof(StopIndicator), 1.5f);
    }


}