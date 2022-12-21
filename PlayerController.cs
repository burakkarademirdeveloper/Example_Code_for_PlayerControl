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
        horizontalInput = Input.GetAxis("Horizontal"); // Yatay giri� de�erleri al�n�r.
        verticalInput = Input.GetAxis("Vertical"); // Dikey giri� de�erleri al�n�r.
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput); // Al�nan dikey girdiye atanan tu�lara g�re arac�n hareketi sa�lan�r.
        if (verticalInput == 0) // Ara� durdu�u yerde d�nmemesi i�in ufak bir karar kontrol yap�s�. 
        {
            turnSpeed = 0f;
        }
        else
        {
            turnSpeed = 50f;
        }
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput); // Al�nan yatay girdiye atanan tu�lara g�re arac�n rotasyonu belirlenir.
        
        


    }
}
