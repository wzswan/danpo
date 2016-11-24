using UnityEngine;
using System.Collections;

public class MoveDown : MonoBehaviour {

    public GameObject GvrMain;
    //Start
    private Vector3 startPos;
    //End
    private Vector3 endPos;
    //Distance
    private float distance = 20f;

    public bool moveForward;

    // public float toggleAngle = 30.0f;

    //public Transform vrCamera;

    //Time to take from start to end
    private float lerpTime = 5;
    //This will update the lerp time
    private float currentLerpTime = 0;

    // Use this for initialization
    void Start () {

        startPos = GvrMain.transform.position;
        endPos = GvrMain.transform.position + Vector3.down * distance;

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Transform()
    {
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime >= lerpTime)
        {
            currentLerpTime = lerpTime;
        }
        float Perc = currentLerpTime / lerpTime;
        GvrMain.transform.position = Vector3.Lerp(startPos, endPos, Perc);


    }
}
