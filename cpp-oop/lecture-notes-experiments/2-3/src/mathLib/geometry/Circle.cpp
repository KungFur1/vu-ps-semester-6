// file "Circle.cpp"
#include "Circle.h"
namespace math {
    namespace geometry {
        Circle::Circle(float radius) {
            this->radius = radius;
        }
        Circle::~Circle() {
            
        }
        float Circle::length() {
            return 2 * Circle::PI * this->radius;
        }
    }
}