using UnityEngine;

public class movePlayer : MonoBehaviour
{
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 15 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -15 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(15 * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-15 * Time.deltaTime, 0, 0);
        }  
    }
}
