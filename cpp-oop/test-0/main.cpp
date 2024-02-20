#include "Time/Date.h"
#include "Helmet.cpp"
#include <iostream>
using namespace std;

int main(){
    Date today(20, 2, 2024);
    std::cout << "Today: " << today.Yo();

    Helmet areo_helmet(445);
    std::cout << "Weight: " << areo_helmet.get_weight();


    return 0;
}