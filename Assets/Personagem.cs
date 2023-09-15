using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public float speed = 20.0f;
    private float horizontalInput;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if(horizontalInput != 0){
            animator.SetBool("Running",true);
        }
        else{
            animator.SetBool("Running",false);
        }
            //animator.SetFloat("Speed",1);
            //animator.SetFloat("Speed", 1);
        //Move o veiculo pra frente
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (horizontalInput > 0) {
            gameObject.transform.localScale = new Vector2(1,1);
        }
        else if (horizontalInput < 0) {
            gameObject.transform.localScale = new Vector2(-1,1);
        }
    }
}
