using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    Animator animController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      animController = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        float vertical;
        float horizontal;
     

        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        animController.speed = 1.0f;

        if (vertical > 0) //player pressed up 
        { animController.SetInteger("direction", 0); }
        if (vertical < 0) //player pressed down or no vertical input
        { animController.SetInteger("direction", 2); }

        if (horizontal > 0)
        { animController.SetInteger("direction", 1); }
        if (horizontal < 0)
        { animController.SetInteger("direction", 3); }

       

    }
}
