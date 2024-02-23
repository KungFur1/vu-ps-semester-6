// file "Integral.cpp"
#include "Integral.h"

namespace math {
    namespace calculus {
        float integral_y_const(float x1, float x2, float y_const) {
            return (x1 - x2) * y_const;
        }
    }
}