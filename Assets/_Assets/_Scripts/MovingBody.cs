using UnityEngine;
using HarshData;

public class MovingBody : MonoBehaviour
{
	//[SerializeField] private float speed = 10f;
    
    private void Update()
    {
        if (GameManager.instance.isGameEnd)
            return;
        transform.position -= Vector3.forward * GameManager.instance.GetCarSpeed() * Time.deltaTime;
    }
}
