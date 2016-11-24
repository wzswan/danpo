using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour {

    public GameObject target;

    // Use this for initialization
    void Start () {

        Invoke("ChangeTo", 30);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ChangeTo(string scenceToChangeTo)
    {
        SceneManager.LoadScene("wzs");
    }
}
