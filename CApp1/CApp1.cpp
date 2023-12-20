#include <iostream>

void f1()
{
    std::cout << "Function F1\n";
}
void f2()
{
    std::cout << "Function F2\n";
}
void f3()
{
    std::cout << "Function F3\n";
}


int main()
{
    void* func[3] = { f1,f2,f3 };
    for (int i=0; i<3; i++)
        ((void(*)(void))(func[i]))(); //(*)(func)()
    //[3] = { f1, f2, f3 };
}
