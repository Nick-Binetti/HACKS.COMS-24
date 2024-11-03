using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDeposit : MonoBehaviour
{
    private bool inArea;

    [SerializeField] private GameObject tooltip;

    public static event System.Action OnDeposit;

    // Start is called before the first frame update
    void Start()
    {
        tooltip.SetActive(false);
        inArea = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //enable tooltip when in the area of dumpster
        if (inArea)
        {
            tooltip.SetActive(true);

            //On click disable tooltip
            if (Input.GetMouseButtonDown(0))
            {
                tooltip.SetActive(false);

                //invoke event to get rid of all trash 
                OnDeposit.Invoke();


            }
        }
        else
        {
            tooltip.SetActive(false);
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
