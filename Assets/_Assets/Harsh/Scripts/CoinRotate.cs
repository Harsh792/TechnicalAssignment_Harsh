using UnityEngine;
using HarshData;

public class CoinRotate : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 180f;

    private void Update()
    {
        transform.localRotation *= Quaternion.Euler(0f, rotationSpeed * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.TriggerSoundEffect(GameManager.instance.clips[1]);
            GameManager.instance.AddCoin();
            this.gameObject.SetActive(false);

        }
    }



}