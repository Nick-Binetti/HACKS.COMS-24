using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPickup : MonoBehaviour
{
    private bool inArea;
    [SerializeField] private GameObject collectText;
    // Start is called before the first frame update
    void Start()
    {
        collectText.SetActive(false);
        inArea = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inArea)
        {
            collectText.SetActive(true);
            if(Input.GetMouseButtonDown(0))
            {
            }
        }
        else
        {
            collectText.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        inArea = true;
    }

    public void OnTriggerExit(Collider other)
    {
        inArea = false;
    }
}
