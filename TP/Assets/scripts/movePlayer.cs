using UnityEngine;

public class movePlayer : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool is_front_walking = false;
        bool is_back_walking = false;
        bool is_left_walking = false;
        bool is_right_walking = false;

        if (Input.GetKey(KeyCode.W))
        {
            is_front_walking = true;
            transform.Translate(0, 0, 15 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            is_back_walking = true;
            transform.Translate(0, 0, -15 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            is_right_walking = true;
            transform.Translate(15 * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            is_left_walking = true;
            transform.Translate(-15 * Time.deltaTime, 0, 0);
        }
        animator.SetBool("is_front_walking", is_front_walking);
        animator.SetBool("is_back_walking", is_back_walking);
        animator.SetBool("is_left_walking", is_left_walking);
        animator.SetBool("is_right_walking", is_right_walking);
        
    }
    public void NewEvent()
    {
    }

}
