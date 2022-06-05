using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    [TextArea(1, 3)]
    public string[] lines;
    public bool hasName = true;

    public bool ifNext = false;//是否有下一步trigger
    public GameObject nextTrigger;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = false;
        }
    }

    private void Update()
    {
        if (isEntered && Input.GetKeyDown(KeyCode.E) && Manger.instance.dialogueBox.activeInHierarchy == false)
        {
            Manger.instance.ShowDialogue(lines);
        }

        if (ifNext && Manger.instance.ifFinished)
        {
            nextTrigger.SetActive(true);
        }
    }

}
