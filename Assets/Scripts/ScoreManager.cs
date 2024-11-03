using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float trash;
    private float money;
    private float timer = 60f;

    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text cash;
    [SerializeField] private TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        TrashPickup.OnPickup += TrashIncrement;
        TrashDeposit.OnDeposit += MoneyUp;

        TrashDeposit.OnDeposit += TrashReset;
    }

    // Update is called once per frame
    void Update()
    {
        //Constantly Update the trash and money counts to the screen
        score.text = "Trash: " + trash;
        cash.text = "Cash : $" + money;
        timerText.text = "Time: " + timer;

        timer -= Time.deltaTime;
        timer = Mathf.Round(timer*100f)/100f;

    }

    public void TrashIncrement()
    {
        trash++;
    }

    public void TrashReset()
    {
        trash = 0;
    }

    public void MoneyUp()
    {
        money += trash;
    }
}
