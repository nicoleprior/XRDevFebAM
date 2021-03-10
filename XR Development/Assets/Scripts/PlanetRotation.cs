using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlanetRotation : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float planetSpeed = 2f;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(transform.rotation.eulerAngles);

        meshRenderer.material.SetFloat("_Size", Random.Range(10, 100));

        meshRenderer.material.SetColor("_ColorA", Color.HSVToRGB(Random.value, 1, 1));
        meshRenderer.material.SetColor("_ColorB", Color.HSVToRGB(Random.value, 1, 1));

    }

    // Update is called once per frame
    private void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + planetSpeed, transform.rotation.eulerAngles.z);
    }


    public void OnOffToggle()
    {
        if (gameObject.activeSelf == true)
        {
            Debug.Log("The object is on");
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("The object is off");
            gameObject.SetActive(true);
        }
    }

 

}
