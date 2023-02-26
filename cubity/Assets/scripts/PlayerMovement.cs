using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Transform player;
    public float forwardForce = 5000f;
    public float sidewaysForce = 100f;
    public int x = 250;
    /*void Start()
    {
        rb.AddForce(0,200,500);
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        if(Input.GetKey("d")|| Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(sidewaysForce* Time.deltaTime,0,0,ForceMode.VelocityChange);

        }
        else if(Input.GetKey("a")|| Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-sidewaysForce* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(x != 0 && (int) player.position.z == x){
            forwardForce += 200;
            sidewaysForce += 1;
            x += 250;
        }
        if(rb.position.y <= -1f){
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}

