// file "Triangle.cpp"
#include "Triangle.h"
namespace math {
    namespace geometry {
        Triangle::Triangle(float a, float b, float c) {
            this->a = a;
            this->b = b;
            this->c = c;
        }
        Triangle::~Triangle(){

        }
        float Triangle::length(){
            return a + b + c;
        }
    }
}