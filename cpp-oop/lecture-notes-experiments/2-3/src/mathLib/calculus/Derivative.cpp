// file "Derivative.cpp"
#include "Derivative.h"

namespace math {
    namespace calculus {
        float calculate_derivative(float x1, float x2, float y1, float y2) {
            return (y2 - y1)/(x2 - x1);
        }
    }
}
