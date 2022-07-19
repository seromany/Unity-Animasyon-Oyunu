using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sure : MonoBehaviour
{
    public GameObject rekorText;
    TextMesh rekorTextMesh;
    TextMesh sureTextMesh;
    int sureDegeri = 0;
    int rekor;
    // Start is called before the first frame update
    void Start()
    {
        sureTextMesh = GetComponent<TextMesh>();
        rekor = PlayerPrefs.GetInt("rekor");
        if (rekor > 0)
        {
            rekorTextMesh = rekorText.GetComponent<TextMesh>();
            rekorTextMesh.text = "Rekor: " + rekor;
        }
        InvokeRepeating("sureArttir",1f,1f);
    }

    void sureArttir()
    {
        sureDegeri++;
        sureTextMesh.text = "Sure: " + sureDegeri;
        rekor = PlayerPrefs.GetInt("rekor");
        if (rekor < sureDegeri)
        {
            PlayerPrefs.SetInt("rekor", sureDegeri);
        }
    }
}
