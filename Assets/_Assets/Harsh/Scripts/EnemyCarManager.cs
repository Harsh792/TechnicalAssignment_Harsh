using UnityEngine;
using HarshData;

public class EnemyCarManager : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Vector3 startPosition;
    [SerializeField] private float backwardForce = 8f;
    [SerializeField] private float upwardForce = 5f;
    [SerializeField] private float spinForce = 6f;

    private void Awake()
    {
        startPosition = transform.localPosition;
    }

    private void Update()
    {
        if (GameManager.instance.isGameEnd)
            return;
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        Rigidbody rb = other.attachedRigidbody;

        Vector3 hitPoint = other.ClosestPoint(transform.position);

        Instantiate(
            GameManager.instance.crashEffect,
            hitPoint,
            Quaternion.identity
        );

        if (rb != null)
        {
            //this.GetComponent<SphereCollider>().enabled = false;
            other.transform.GetComponent<CarController>().enabled = false;
            rb.useGravity = true;
            // Optional: clear previous motion
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            // Launch the car
            Vector3 force = (-transform.forward * backwardForce) + (Vector3.up * upwardForce);
            rb.AddForce(force, ForceMode.Impulse);

            // Make it tumble
            rb.AddTorque(
                Random.Range(-1f, 1f),
                Random.Range(-0.5f, 0.5f),
                Random.Range(-1f, 1f)
            * spinForce, ForceMode.Impulse);

            GameManager.instance.SetIsGameEnd(true);
        }


       
    }


    public void ResetCarPosition()
    {
        transform.localPosition = startPosition;
        //Debug.Log("CarPositionReset");
    }

}