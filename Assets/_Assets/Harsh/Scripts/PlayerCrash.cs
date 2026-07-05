using UnityEngine;
using HarshData;

[RequireComponent(typeof(Rigidbody))]
public class PlayerCrash : MonoBehaviour
{
    [SerializeField] private float impactForce = 10f;
    [SerializeField] private float torqueForce = 8f;

    private Rigidbody rb;
    private bool crashed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        // Before the crash
        rb.useGravity = false;
        //rb.isKinematic = true; // Or keep false if you're already using physics
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hArsh");
        if (crashed)
            return;

        // Make player physics-driven
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");
            Crash(collision);
           
        }
    }

    private void Crash(Collision collision)
    {
        crashed = true;

        rb.isKinematic = false;
        //rb.useGravity = true;

        Vector3 forceDir = (transform.position - collision.transform.position).normalized;
        rb.AddForce(forceDir * impactForce, ForceMode.Impulse);
        rb.AddTorque(Random.insideUnitSphere * torqueForce, ForceMode.Impulse);

        // Disable your player movement script here if needed
        // GetComponent<PlayerController>().enabled = false;
    }
}