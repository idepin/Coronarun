using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jumpPower;
    float distToGround;
    public string buttonName;

    float jumpPressure;
    float minJump;
    float maxjumpPressure;

    public Slider jumpPowerSlider;

    public bool getButton, getButtonUp;
    public void GetButton()
    {
        getButton = true;
        getButtonUp = false;
    }

    public void GetButtonUp()
    {
        getButton = false;
        getButtonUp = true;
    }
    private void Start()
    {
        jumpPressure = 0f;
        minJump = 5f;
        maxjumpPressure = 10f;
        rb = GetComponent<Rigidbody>();
        distToGround = GetComponent<Collider>().bounds.extents.y;
    }
    bool IsGrounded(){
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.3f);
    }
private void FixedUpdate()
    {
        if(speed < 2f)
            speed += 0.005f * Time.deltaTime;

        rb.MovePosition(rb.position + Vector3.forward * speed);
        if (IsGrounded())
        {
            if (getButton)
            {
                if (jumpPressure < maxjumpPressure)
                {
                    jumpPressure += Time.deltaTime * jumpPower;
                }
                else
                {
                    jumpPressure = maxjumpPressure;
                }
                
                
            }
            else
            {
                if (getButtonUp)
                {
                    rb.AddTorque(Vector3.right * 900);
                    print("lepas");
                    getButtonUp = false;
                }
                if (jumpPressure > 0f)
                {
                    jumpPressure = jumpPressure + minJump;
                    rb.velocity = new Vector3(0f, jumpPressure, 0f);
                    jumpPressure = 0f;
                }
            }
            jumpPowerSlider.value = jumpPressure;

            
        }
        else
        {
            
        }



    }
}
