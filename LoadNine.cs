using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Main Camera")
        {
            SceneManager.LoadScene("islandNine");
        }
    }
}
