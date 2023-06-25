using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
   private KeyCode key = KeyCode.A;
    public int mousebotton;
    public float timerest = 1f;
    
    public  VectorIntroduction objecneedmove;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is InputManager run on star");
        objecneedmove = GetComponent<VectorIntroduction>();
    }

    // Update is called once per frame
    void Update()
    {
        InputKeyboard();
    }
    protected void InputGetAxis()
    {
        //Input.GetAxis("Horizontal");
       float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticallAxis = Input.GetAxisRaw("Vertical");
        objecneedmove.Move(new Vector3(horizontalAxis, verticallAxis, 0));
    }
    protected void InputMouseClick()
    {
        bool startclick = Input.GetMouseButtonDown(mousebotton);
        bool holdclick = Input.GetMouseButton(mousebotton);
        bool releaseclick = Input.GetMouseButtonUp(mousebotton);
        if (startclick == true)
        {
            
            Debug.Log("bắt đầu click chuột");
        }
        if (holdclick == true)
        {
            Debug.Log("bắt đầu giữ click chuột");
        }
        if (releaseclick == true)
        {
            Debug.Log("bắt đầu thả click chuột");
        }
    }
    protected void InputKeyboard()
    {
        
        bool startpresskey = Input.GetKeyDown(KeyCode.A);
        bool holdpresskey = Input.GetKey(KeyCode.A);
        bool releasepresskey = Input.GetKeyUp(KeyCode.A);
        if (startpresskey == true)
        {
            Debug.Log("bắt đầu bấm Phím A");
        }
        if (holdpresskey == true)
        {
            Debug.Log("bắt đầu giữ Phím A");
        }
        if (releasepresskey == true)
        {
            Debug.Log("bắt đầu thả Phím A");
        }
    }
}
