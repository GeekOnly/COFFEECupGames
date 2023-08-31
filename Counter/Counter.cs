using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Counter : MonoBehaviour
{
    //public Text CounterText;
    public TextMeshProUGUI CounterText;

    public GameObject vfxPrefabs;
    private int Count = 0;

    [SerializeField]
    AudioClip CupSFX;
    AudioSource source;

    private void Start()
    {
        Count = 0;
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            Count += 1;
            StartCoroutine(SpawnVFX(other));
            //other.gameObject.SetActive(false);
            CounterText.text = "Count : " + Count;
        }
    }

    IEnumerator SpawnVFX(Collider other)
    {

        if (other.CompareTag("obj"))
        {
            GameManager.instance.AddObj(other.gameObject);
            source.PlayOneShot(CupSFX,2.5f);
            GameObject vfx = Instantiate(vfxPrefabs, new Vector3(other.transform.position.x, 3f, other.transform.position.z), Quaternion.identity) as GameObject;
            Destroy(other);
          //  Debug.Log("Check obj");
        }

        yield return new WaitForSeconds(.2f);
    }
}
