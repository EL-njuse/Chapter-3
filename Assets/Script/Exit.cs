using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    private void OnTriggerEnter2D(Collider2D other)
    {      // Start is called before the first frame update
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
    if (isEntered && Input.GetKeyDown(KeyCode.Q))
    {
            Application.Quit();
        }

}

}
