using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPickup : MonoBehaviour
{
    private bool inArea;

    [SerializeField] private GameObject collectText;

    public static event System.Action OnPickup;
    // Start is called before the first frame update
    void Start()
    {
        collectText.SetActive(false);
        inArea = false;
    }

    // Update is called once per frame
    void Update()
    {
        //enable tooltip when in the area of a piece of trash
        if (inArea)
        {
            collectText.SetActive(true);

            //On click disable piece of trash
            if(Input.GetMouseButtonDown(0))
            {
                gameObject.SetActive(false);
                collectText.SetActive(false);

                //invoke event to increment trash float in another script
                OnPickup.Invoke();


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
