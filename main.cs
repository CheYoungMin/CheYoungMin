using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour //유니티 게임 오브젝트 클래스
{
    int health = 50; //전역함수:함수 바깥에 선언된 변수
    int Level = 5;

    void Start()
    {
        //1.자료형과 변수 (선언>초기화>호출(사용)

        //-선언단계
        int Level; //정수형
        string PlayerName; //문자형 *" "
        float strenght; //소수를 포함한 숫자형 *f
        bool isFullLevel; //논술형 *false/ture

        //*변수:데이터를 메모리에 저장하는 장소

        //-초기화단계(~값을 넣는단계)
        Level = 5;
        strenght = 15.5f;
        PlayerName = "용사";
        isFullLevel = false;

        //-호출(사용)단계
        Debug.Log(Level);
        Debug.Log(PlayerName);
        Debug.Log(strenght);
        Debug.Log(isFullLevel);


        //2,그룹형 변수형

        //(1)자료형[] 변수{};
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        //(2)자로형 변수= new자료형[];
        //자료형[0]=" ";
        //자료형[1]=" ";
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 2;
        monsterLevel[2] = 3;

        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        //(3)List<자료형> 변수=new List<자료형>();
        //변수.Add(" ");

        List<string> items = new List<string>();
        items.Add("회복 물약");
        items.Add("마나 물약");

        //LIst안에 있는 값 삭제
        //items.RemoveAt(0);

        Debug.Log(items[0]);
        Debug.Log(items[1]);
        //이때 items[1]이 [0]이 돼면서 [1]를 호출(사용)하면 크기를 벗어난 탐색으로 오류발생


        //3.연산자

        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        Level = exp / 300;
        strenght = Level * 3.1f;
        int NextLevel = 300 - exp % 300;

        Debug.Log("경험치는?" + exp);
        Debug.Log("플레이어의 힘은?" + strenght);
        Debug.Log("플레이어의 레벨은?" + Level);
        Debug.Log("플레이어가 다음 레벨업까지 남은 경험치는?" + NextLevel);

        int FullLevel = 99;
        isFullLevel = Level == FullLevel;
        Debug.Log("용사는 만렙인가요?" + isFullLevel);

        // int health = 50;
        int mana = 100;

        bool isEndTutorial = Level > 10; //연산자 (>, <, >=, <=, ==, !=) 그 외 *+, +=. -=, /=, %=, ++, -- 등
        Debug.Log("용사는 튜토리얼이 끝났나요?" + isEndTutorial);

        bool isPlayer = Level >= 6 && strenght >= 15.5f; //&&는 그리고로 두가지 전부가 ture여야 실행
        Debug.Log("용사는 초급용사인가요?" + isPlayer);

        bool isCondition = health < 100 || mana > 50;
        Debug.Log("용사는 켠디선이 좋은가요?" + isCondition); //||는 또는으로 두가지 중 한가지만 ture면 실행

        string Condition = isCondition ? "좋습니다" : "나쁩니다"; //? A:B의 A는 ture/B는 false일때 bool형 변수의 값에 따라 실행
        Debug.Log(Condition);


        //4.키워드
        //키워드:프로그래밍 언어를 구성하는 특별한 언어 EX)int, float, string, bool, new, List등

        //*변수로도 값으로도 활용x


        //5.조건문

        //(1)if문 if(ture) {로직}
        if (Condition == "좋습니다")
        {
            Debug.Log("플레이어는 지금 컨디션이 좋습니다.");
        }
        else //위의 식이 ture 때문에 이 명령어는 실행x
        {
            Debug.Log("플레이어는 지금 켠디선이 좋지 않습니다.");
        }

        if (health < 100 && items[1] == "회복 물약") //이 식은 items[1]은 마나 물약으로 false이다 그럼으로 실행x
        {
            items.RemoveAt(0);
            health += 50;
            Debug.Log("회복 물약을 사용하여 회복하였습니다" + health);
        }

        else if (mana < 200 && items[1] == "마나 물약") //위 식이 실행하지 않았음으로 다음으로 실행 *단 위 if식이 ture면 실행X
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나 물약을 사용하여 회복하였습니다" + mana);
        }

        //(2)switch(변수) {
        //case 값1:
        //로직;
        //break;
        //}

        //switch, case:변수의 값에 따라 로직 실행
        switch (monsters[1]) //monsters[1]인 사막뱀이 case문에 존재하지 않기 때문에 default명령어를 실행한다
        {
            case "슬라임":
            case "돌멩이":
                Debug.Log("소형 몬스터 출현");
                break;

            case "악마":
                Debug.Log("중형 몬스터 출현");
                break;

            case "골렘":
                Debug.Log("대형 몬스터 출현");
                break;

            //default:모든 case문을 통과하지 못했을 때 실행된다 default: 로직; break;
            default:
                Debug.Log("알 수 없는 몬스터 출현");
                break;
        }


        //6.반복문
        //반복문:조건에 만족하면 로직을 반복하는 제어문

        //(1)while(조건) {로직}
        while (health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독 데미지를 입었습니다." + health);
            }
            else
            {
                Debug.Log("플레이어가 사망하였습니다.");
            }
            if (health == 10)
            {
                Debug.Log("해독제를 사용하였습니다.");
                break; //반복문을 빠져나간다.

            }
        }
        //(2)for(연산될 변수; 조건; 연산) {로직}
        //for문:변수를 연산하면서 로직 반복 실행한다.
        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("치료중입니다." + health);
        }

        for (int index = 0; index < monsters.Length; index++) //.Length:배열/Count:리스트
        {
            Debug.Log("이 지역에 있는 몬스터는?" + monsters[index]);
        }
        //(3)foreach (자료형 변수 in 그룹형변수) {로직}
        //foreach:for의 그룹형변수 탐색 특화
        foreach (string monster in monsters)
        {
            Debug.Log("이 곳에 있는 몬스터는?" + monster);
        }
        health = Heal(health); //매개변수 *함수의 매개변수 이름은 같을 필요가 없다

        Strat1();//void Start1의 함수를 사용

        //실습
        for (int index = 0; index < monsters.Length; ++index)
        {
            Debug.Log("용사는" + monsters[index] + "에게" + Battle(monsterLevel[index]));
        }

        //7.class
        Person player = new Person();

        player.id = 1;
        player.weapon = "활";
        player.name = "궁수";
        player.title = "전설의";
        player.strength = 30.5f;
        player.level = 10;

        Debug.Log(player.Talk() + "안녕하세요 혹시 가지고 있는 무기가 뭔가요?");
        Debug.Log("제 무기는" + player.Hasweapon() + "입니다");
        player.LeveUp();
        Debug.Log("레벨업에 성공하였습니다");
        Debug.Log(player.title + player.name + "의 레벨은" + player.level + "입니다");


    }
    //7.함수[메소드](기능을 편리하게 사용하도록 구성된 영역)
    int Heal(int health) //반환 데이터가 있는 함수 타입
    {
        health += 10;
        Debug.Log("힘을 받았습니다" + health);
        return health;
    }
    //함수이름 앞에 이 함수가 반환하는 내뱉는 그런 값 자료형 쓰고 괄호 안에는 이 함수가 받을 변수를 적기
    //힐이라는 함수는 이제 현재 체력이라는 수치를 받아서 뭔가를 더한 다음에 int형으로 내뱉는다

    void Strat1()//void;반환 데이터가 없는 함수 타입
    {
        health += 10;
        Debug.Log("힐을 받았습니다." + health);

    }

    //실습
    string Battle(int monsterLevel)
    {
        string result;
        if (Level > monsterLevel)
            result = "이겻습니다.";

        else
            result = "졌습니다.";
        return result;

    }
}