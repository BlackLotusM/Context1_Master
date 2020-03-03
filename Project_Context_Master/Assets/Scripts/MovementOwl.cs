using UnityEngine;

public class MovementOwl : MonoBehaviour
{
    private float _verticalInput = 0;
    private float _horizontalInput2 = 0;

    public GameObject HiddenObjects;
    public float mana;

    public int movementSpeed = 0;
    public int rotationSpeed = 0;

    public bool overuse;
    int time;
    ManaBar ScriptMana;


    Rigidbody2D rb2d;
    void Start()
    {
        mana = 0.50f;
        rb2d = GetComponent<Rigidbody2D>();
        HiddenObjects.SetActive(false);
        overuse = false;

        ScriptMana = GetComponent<ManaBar>();
        ScriptMana.overuse = false;
    }

    void Update()
    {
        GetPlayerInput();
        RotatePlayer();
        MovePlayer();
        SpecialMove();
        OveruseCheck();
    }

    private void OveruseCheck()
    {
        
        if(overuse == true)
        { 
            time = time + 1;
            if(time >= 800)
            {
                overuse = false;
                ScriptMana.overuse = false;
                Debug.Log(time);
            }
        }else if(overuse == false){
            time = 0;
        }
    }


    private void SpecialMove()
    {
        if (Input.GetButton("Fire1")){
            if (overuse == true)
            {
                if (ScriptMana.owo < 1)
                {
                    mana = mana + 0.005f;
                    ScriptMana.owo = mana;
                }
            }
            else
            {
                if (ScriptMana.owo <= 0)
                {
                    HiddenObjects.SetActive(false);
                    overuse = true;
                    ScriptMana.overuse = true;
                }
                else
                {
                    mana = mana - 0.0045f;
                    ScriptMana.owo = mana;
                    HiddenObjects.SetActive(true);
                }
            }
        }
        else
        {
            if(ScriptMana.owo < 1)
            {
                mana = mana + 0.005f;
                ScriptMana.owo = mana;
            }

            HiddenObjects.SetActive(false);
        }
    }

    private void GetPlayerInput()
    {
        _verticalInput = Input.GetAxisRaw("Vertical");
        _horizontalInput2 = Input.GetAxisRaw("Horizontal_2");
    }

    private void RotatePlayer()
    {
        float rotation = -_horizontalInput2 * rotationSpeed;
        transform.Rotate(Vector3.forward * rotation);
    }

    private void MovePlayer()
    {
        rb2d.velocity = transform.up * _verticalInput * movementSpeed;
    }
}