using UnityEngine;
using System.Collections;

public class RotateDown : MonoBehaviour {

    public Transform target;
    public float orbitDistance = 1.0f;
    public float orbitDegreesPerSec = 30.0f;
    public Vector3 relativeDistance = Vector3.zero;

    // Use this for initialization
    void Start () {

        if (target != null)
        {
            relativeDistance = transform.position - target.position;
        }

    }

    void Orbit()
    {
        if (target != null)
        {
            transform.position = target.position + relativeDistance;
            transform.RotateAround(target.position, Vector3.up, orbitDegreesPerSec * Time.deltaTime);

            relativeDistance = transform.position - target.position;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {

        Orbit();

    }
}
