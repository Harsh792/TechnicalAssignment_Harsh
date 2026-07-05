using UnityEngine;

public class SpawnerLoop : MonoBehaviour
{
    [SerializeField] private Transform[] movingBodies;
    [SerializeField] private float offCameraZ = -50f;

    private float segmentLength;

    private void Start()
    {
        // Calculate the distance between the first two segments
        segmentLength = Mathf.Abs(movingBodies[1].position.z - movingBodies[0].position.z);
    }

    private void Update()
    {
        foreach (Transform body in movingBodies)
        {
            if (body.position.z <= offCameraZ)
            {
                Transform last = GetLastSegment();

                body.position = new Vector3(
                    body.position.x,
                    body.position.y,
                    last.position.z + segmentLength);

                ResetSegment(body);
            }
        }
    }

    Transform GetLastSegment()
    {
        Transform last = movingBodies[0];

        foreach (Transform t in movingBodies)
        {
            if (t.position.z > last.position.z)
                last = t;
        }

        return last;
    }

    void ResetSegment(Transform body)
    {
        Transform enemyRoot = body.GetChild(4);
        Transform coinRoot = body.GetChild(5);

        foreach (Transform child in enemyRoot)
            child.GetComponent<EnemyCarManager>().ResetCarPosition();

        foreach (Transform child in coinRoot)
            child.gameObject.SetActive(true);
    }
}