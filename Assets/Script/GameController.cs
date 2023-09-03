using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public GameObject m_stagePrefabs;   // ���������� ����� �д�.


    enum State
    {
        GameIn,     //���� ���� �غ�.
        Game,       //���� ��.
        GameChanging,//�������� ����.
        GameOut,    //���� ���� �غ�.
        GameEnd,    //���� ����.
    };
    State m_state;



    // Start is called before the first frame update
    void Start()
    {
        m_state = State.GameIn;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (m_state)
        {
            case State.GameIn:
                UpdateGameIn();
                break;
            case State.Game:
                UpdateGame();
                break;
            case State.GameChanging:
                //UpdateGameChanging();
                break;
            case State.GameOut:
                //UpdateGameOut();
                break;
            case State.GameEnd:
                //UpdateGameEnd();
                break;
        }
    }

    //���� ���� �غ�.
    void UpdateGameIn()
    {
        //�������� ����.
        /*
        GameObject stage = GameObject.Find("Stage");
        if (stage == null)
        {
            stage = Instantiate(m_stagePrefabs);
            stage.name = "Stage";
            Debug.Log("������������");

            return;
        }
        */
        //���� �������� ��ȯ.
        m_state = State.Game;

        //�߻��� �� �ְ� �մϴ�.
        GameObject[] bars = GameObject.FindGameObjectsWithTag("Bar");
        foreach (GameObject obj in bars)
        {
            BarScript bar = obj.GetComponent<BarScript>();
            bar.SetShotEnable(true);       //�߻��� OFF.
        }
    }


    //���� ��.
    void UpdateGame()
    {

    }


    //���������� �ٲٴ� ����..
    void UpdateGameChanging()
    {

    }


    //���� ���� �غ�.
    void UpdateGameOut()
    {

    }



    //���� ������ true.
    public bool IsEnd()
    {
        return (m_state == State.GameEnd);
    }

}

