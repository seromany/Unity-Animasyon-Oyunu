using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engeller : MonoBehaviour
{
    public GameObject buyukEngel;
    public GameObject kucukEngel;
    public GameObject player;
    public float[] konumlar = new float[] { -2.5f, 4.5f };
    public GameObject[] objeler = new GameObject[2];
    // Start is called before the first frame update
    void Start()
    {
        objeler[0] = buyukEngel;
        objeler[1] = kucukEngel;
        InvokeRepeating("engelOlustur", 10f, 5f);
    }

    void engelOlustur()
    {
        float mesafe = player.transform.position.z;
        GameObject engel = objeler[Random.Range(0, 2)];
        if (engel.tag == "buyukEngel")
        {
            Vector3 pos = new Vector3(0.6f, 0.5f, Random.Range(mesafe * 5, mesafe * 7));
            Instantiate(engel, pos, engel.transform.rotation);
        }
        else
        {
            Vector3 pos = new Vector3(konumlar[Random.Range(0, 2)], 0.5f, Random.Range(mesafe * 5, mesafe * 7));
            Instantiate(engel, pos, engel.transform.rotation);
        }
    }

}
