using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // Yatay giriþ deðerleri alýnýr.
        verticalInput = Input.GetAxis("Vertical"); // Dikey giriþ deðerleri alýnýr.
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput); // Alýnan dikey girdiye atanan tuþlara göre aracýn hareketi saðlanýr.
        if (verticalInput == 0) // Araç durduðu yerde dönmemesi için ufak bir karar kontrol yapýsý. 
        {
            turnSpeed = 0f;
        }
        else
        {
            turnSpeed = 50f;
        }
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput); // Alýnan yatay girdiye atanan tuþlara göre aracýn rotasyonu belirlenir.
        
        


    }
}
