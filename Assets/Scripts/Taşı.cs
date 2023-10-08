using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taşı : MonoBehaviour
{
    Camera cam;
    Vector2 başlangıçPozisyonu;

    GameObject[] kutuDizisi;

    Oyun oyun;

    AudioSource asc;

    private void OnMouseDrag()
    {
        Vector3 pozisyon = cam.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }

    private void Start()
    {
       cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        başlangıçPozisyonu = transform.position;

        kutuDizisi = GameObject.FindGameObjectsWithTag("Kutu");

        oyun = GameObject.Find("Oyun").GetComponent<Oyun>();

        asc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach(GameObject kutu in kutuDizisi)
            {
                if(kutu.name == gameObject.name)
                {
                    float mesafe = Vector3.Distance(kutu.transform.position, transform.position);

                    if(mesafe <= 1)
                    {
                        transform.position = kutu.transform.position;
                        oyun.SayıArttır();
                        this.enabled = false;
                        Destroy(this);
                        asc.Play();
                    }

                    else
                    {
                        transform.position = başlangıçPozisyonu;
                    }
                }
            }
        }
    }
}
