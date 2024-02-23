#include "mathLib/math.h"
#include <iostream>
using namespace std;

void A();
void A();
void A();
void A();
void A();

int main(){
    math::geometry::Circle bigCircle(45.5);
    math::geometry::Triangle equilateralTriangle(3, 3, 3);

    cout << "Circle & Triangle lengths: " << bigCircle.length() 
    << " " << equilateralTriangle.length() << endl;

    cout << "Derivative: " << math::calculus::calculate_derivative(1, 2, 0, 3) << endl;
    cout << "Integral: " << math::calculus::integral_y_const(1, 5, 2) << endl;


    return 0;
}
