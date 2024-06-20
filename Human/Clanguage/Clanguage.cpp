// Clanguage.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
#include <stdio.h>
#include "Body.h"

using namespace std;

class Human
{
private:
    int passward;

public:
    int age;
    string name;
    float height;

    void ShowMyName();

    Human()
    {
        this->age = 0;
        this->name = "test";
        this->height = 174;
        this->passward = 1234;

    }

    Human(int age)
    {
        this->age = age;
        this->name = "sdgasdgas";
        this->height = 174;
        this->passward = 1234;

    }

    ~Human()
    {

    }

};

void Human::ShowMyName()
{
    std::cout << "ShowMy name : " + this->name << endl;
}


int main()
{
    printf("안녕 친구들 \n");

        
    //string name;
    //cout << "Enter your name: ";
    //cin >> name;
    //cout << "Hello, " << name << "!" << std::endl;

    // 서식문자
    int a;
    float b;
    char c;
    char str[100]; // 문자열을 받을 충분히 큰 배열

    // 입력 받기
    printf("정수를 입력하세요: ");
    scanf_s("%d", &a);

    printf("실수를 입력하세요: ");
    scanf_s("%f", &b);

    // 공백 문자를 무시하고 단일 문자 입력 받기
    printf("문자를 입력하세요: ");
    scanf_s(" %c", &c);

    printf("문자열을 입력하세요: ");
    getchar(); // 이전 입력에서 남아 있는 개행 문자를 제거
    fgets(str, sizeof(str), stdin);

    // fgets는 개행 문자도 포함하므로 이를 제거
    size_t len = strlen(str);
    if (len > 0 && str[len - 1] == '\n') {
        str[len - 1] = '\0';
    }

    // 입력된 값 출력하기
    printf("입력된 정수: %d\n", a);
    printf("입력된 실수: %f\n", b);
    printf("입력된 문자: %c\n", c);
    printf("입력된 문자열: %s\n", str);


    for (int i = 0; i < 10; i++)
    {
        printf("반복문 : %d\n", i);
    }


    Human me(123);
    me.ShowMyName();

    Body body("Chest", 10);

    cout << "Hello, " << body.GetName() << endl;

    string name;
    cin >> name;

    return 0;
}





