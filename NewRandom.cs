using UnityEngine;
using System.Collections;

public class NewRandom : MonoBehaviour {

    public float velocidadMax;//最大速度

    public float xMax;//x方向最大距离
    public float zMax;//z方向最大距离
    public float yMax;
    public float xMin;//x最小距离
    public float zMin;//z最小距离
    public float yMin;

    private float x;
    private float z;
    private float y;
    private float tiempo;
  //  private float anguloA;
   // private float anguloB;

    // Use this for initialization
    void Start () {

        x = Random.Range(-velocidadMax, velocidadMax);
        z = Random.Range(-velocidadMax, velocidadMax);
        y = Random.Range(-velocidadMax, velocidadMax);
      //  anguloA = Mathf.Atan2(x, z) * (180 / 3.141592f);
      //  anguloB = Mathf.Atan2(x, y) * (180 / 3.141592f) ;
       // transform.localRotation = Quaternion.Euler(0, anguloA, anguloB);

    }
	
	// Update is called once per frame
	void Update () {
        tiempo += Time.deltaTime;

        if (transform.localPosition.x > xMax)
        {
            x = Random.Range(-velocidadMax, 0.0f);
        //    anguloA = Mathf.Atan2(x, z) * (180 / 3.141592f);
        //    anguloB = Mathf.Atan2(x, y) * (180 / 3.141592f);
        //    transform.localRotation = Quaternion.Euler(0, anguloA, anguloB);
            tiempo = 0.0f;
        }
        if (transform.localPosition.x < xMin)
        {
            x = Random.Range(0.0f, velocidadMax);
        //    anguloA = Mathf.Atan2(x, z) * (180 / 3.141592f);
         //   anguloB = Mathf.Atan2(x, y) * (180 / 3.141592f);
        //    transform.localRotation = Quaternion.Euler(0, anguloA, anguloB);
            tiempo = 0.0f;
        }
        if (transform.localPosition.z > zMax)
        {
            z = Random.Range(-velocidadMax, 0.0f);
        //    anguloA = Mathf.Atan2(x, z) * (180 / 3.141592f);
        //    anguloB = Mathf.Atan2(x, y) * (180 / 3.141592f);
        //    transform.localRotation = Quaternion.Euler(0, anguloA, anguloB);
            tiempo = 0.0f;
        }
        if (transform.localPosition.z < zMin)
        {
            z = Random.Range(0.0f, velocidadMax);
        //    anguloA = Mathf.Atan2(x, z) * (180 / 3.141592f);
        //    anguloB = Mathf.Atan2(x, y) * (180 / 3.141592f);
        //    transform.localRotation = Quaternion.Euler(0, anguloA, anguloB);
            tiempo = 0.0f;
        }
        if (transform.localPosition.y > yMax)
        {
            y = Random.Range(-velocidadMax, 0.0f);
         //   anguloA = Mathf.Atan2(x, z) * (180 / 3.141592f);
        //    anguloB = Mathf.Atan2(x, y) * (180 / 3.141592f);
         //   transform.localRotation = Quaternion.Euler(0, anguloA, anguloB);
            tiempo = 0.0f;
        }
        if (transform.localPosition.y < yMin)
        {
            y = Random.Range(0.0f, velocidadMax);
       //     anguloA = Mathf.Atan2(x, z) * (180 / 3.141592f);
       //     anguloB = Mathf.Atan2(x, y) * (180 / 3.141592f);
       //     transform.localRotation = Quaternion.Euler(0, anguloA, anguloB);
            tiempo = 0.0f;
        }


        if (tiempo > 1.0f)
        {
            x = Random.Range(-velocidadMax, velocidadMax);
            z = Random.Range(-velocidadMax, velocidadMax);
      //      anguloA = Mathf.Atan2(x, z) * (180 / 3.141592f);
      //      anguloB = Mathf.Atan2(x, y) * (180 / 3.141592f);
      //      transform.localRotation = Quaternion.Euler(0, anguloA, anguloB);
            tiempo = 0.0f;
        }

        transform.localPosition = new Vector3(transform.localPosition.x + (x * Time.deltaTime), transform.localPosition.y + (y * Time.deltaTime), transform.localPosition.z + (z * Time.deltaTime));

    }
}
