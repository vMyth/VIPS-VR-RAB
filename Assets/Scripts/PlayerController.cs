using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private int count;

    public TextMeshProUGUI countText;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI uNameText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        DisplayText();

        uNameText.text = "Welcome " + PlayerPrefs.GetString("uname");
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            count = count + 1;
            DisplayText();
        }
    }

    void DisplayText()
    {
        countText.text = "Count: " + count.ToString();

        if (count == 10)
        {
            winText.gameObject.SetActive(true);
        }
    }
}
